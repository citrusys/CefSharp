param(
    [ValidateSet("vs2015", "vs2017", "vs2019", "nupkg-only", "gitlink")]
    [Parameter(Position = 0)] 
    [string] $Target = "vs2019",
    [Parameter(Position = 1)]
    [string] $Version = "2.3.0",
    [Parameter(Position = 2)]
    [string] $AssemblyVersion = "2.3.0"
)

$WorkingDir = split-path -parent $MyInvocation.MyCommand.Definition
$FluxonautBrowserSln = Join-Path $WorkingDir 'Fluxonaut.Browser.sln'

# Extract the current CEF Redist version from the Fluxonaut.Browser.Core\packages.config file
# Save having to update this file manually Example 3.2704.1418
$FluxonautBrowserCorePackagesXml = [xml](Get-Content (Join-Path $WorkingDir 'Fluxonaut.Browser.Core\packages.Fluxonaut.Browser.Core.config'))
$RedistVersion = $FluxonautBrowserCorePackagesXml.SelectSingleNode("//packages/package[@id='fluxonaut.browser.sdk']/@version").value

function Write-Diagnostic 
{
    param(
        [Parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
        [string] $Message
    )

    Write-Host
    Write-Host $Message -ForegroundColor Green
    Write-Host
}

# https://github.com/jbake/Powershell_scripts/blob/master/Invoke-BatchFile.ps1
function Invoke-BatchFile 
{
   param(
        [Parameter(Position = 0, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$Path, 
        [Parameter(Position = 1, Mandatory = $true, ValueFromPipeline = $true)]
        [string]$Parameters
   )

   $tempFile = [IO.Path]::GetTempFileName()  

   cmd.exe /c " `"$Path`" $Parameters && set > `"$tempFile`" " 

   Get-Content $tempFile | Foreach-Object {   
       if ($_ -match "^(.*?)=(.*)$")  
       { 
           Set-Content "env:\$($matches[1])" $matches[2]  
       } 
   }  

   Remove-Item $tempFile
}

function Die 
{
    param(
        [Parameter(Position = 0, ValueFromPipeline = $true)]
        [string] $Message
    )

    Write-Host
    Write-Error $Message 
    exit 1
}

function Warn 
{
    param(
        [Parameter(Position = 0, ValueFromPipeline = $true)]
        [string] $Message
    )

    Write-Host
    Write-Host $Message -ForegroundColor Yellow
    Write-Host
}

function TernaryReturn 
{
    param(
        [Parameter(Position = 0, ValueFromPipeline = $true)]
        [bool] $Yes,
        [Parameter(Position = 1, ValueFromPipeline = $true)]
        $Value,
        [Parameter(Position = 2, ValueFromPipeline = $true)]
        $Value2
    )

    if($Yes) {
        return $Value
    }
    
    $Value2
}

function Msvs 
{
    param(
        [ValidateSet('v140', 'v141', 'v142')]
        [Parameter(Position = 0, ValueFromPipeline = $true)]
        [string] $Toolchain, 

        [Parameter(Position = 1, ValueFromPipeline = $true)]
        [ValidateSet('Debug', 'Release')]
        [string] $Configuration, 

        [Parameter(Position = 2, ValueFromPipeline = $true)]
        [ValidateSet('x86', 'x64')]
        [string] $Platform
    )

    Write-Diagnostic "Targeting $Toolchain using configuration $Configuration on platform $Platform"

    $VisualStudioVersion = $null
    $VXXCommonTools = $null

    $VS_VER=16;
    $VS_OFFICIAL_VER=2019;

    $programFilesDir = (${env:ProgramFiles(x86)}, ${env:ProgramFiles} -ne $null)[0]

    $vswherePath = Join-Path $programFilesDir 'Microsoft Visual Studio\Installer\vswhere.exe'
    #Check if we already have vswhere which is included in newer versions of VS2017/VS2019
    if(-not (Test-Path $vswherePath))
    {
        Write-Diagnostic "Downloading VSWhere as no install found at $vswherePath"
                
        # Check if we already have a local copy and download if required
        $vswherePath = Join-Path $WorkingDir \vswhere.exe
                
        # TODO: Check hash and download if hash differs
        if(-not (Test-Path $vswherePath))
        {
            $client = New-Object System.Net.WebClient;
            $client.DownloadFile('https://github.com/Microsoft/vswhere/releases/download/2.2.11/vswhere.exe', $vswherePath);
        }
    }
            
    Write-Diagnostic "VSWhere path $vswherePath"
            
    $versionSearchStr = "[$VS_VER.0," + ($VS_VER+1) + ".0)"
    $VS2019InstallPath = & $vswherePath -version $versionSearchStr -property installationPath
            
    Write-Diagnostic "$($VS_OFFICIAL_VER)InstallPath: $VS2019InstallPath"
                
    if(-not (Test-Path $VS2019InstallPath))
    {
        Die "Visual Studio $VS_OFFICIAL_VER is not installed on your development machine, unable to continue."
    }
                
    $MSBuildExe = "msbuild.exe"
    $VisualStudioVersion = "$VS_VER.0"
    $VXXCommonTools = Join-Path $VS2019InstallPath VC\Auxiliary\Build

    if ($VXXCommonTools -eq $null -or (-not (Test-Path($VXXCommonTools)))) {
        Die 'Error unable to find any visual studio environment'
    }

    $VCVarsAll = Join-Path $VXXCommonTools vcvarsall.bat
    if (-not (Test-Path $VCVarsAll)) {
        Die "Unable to find $VCVarsAll"
    }

    # Only configure build environment once
    if($env:FLUXONAUT_BROWSER_BUILD_IS_BOOTSTRAPPED -eq $null) {
        Invoke-BatchFile $VCVarsAll $Platform
        $env:FLUXONAUT_BROWSER_BUILD_IS_BOOTSTRAPPED = $true
    }

    $Arch = TernaryReturn ($Platform -eq 'x64') 'x64' 'win32'

    $Arguments = @(
        "$FluxonautBrowserSln",
        "/t:rebuild",
        "/p:VisualStudioVersion=$VisualStudioVersion",
        "/p:Configuration=$Configuration",
        "/p:Platform=$Arch",
        "/verbosity:normal"
    )

    $StartInfo = New-Object System.Diagnostics.ProcessStartInfo
    $StartInfo.FileName = $MSBuildExe
    $StartInfo.Arguments = $Arguments

    $StartInfo.EnvironmentVariables.Clear()

    Get-ChildItem -Path env:* | ForEach-Object {
        $StartInfo.EnvironmentVariables.Add($_.Name, $_.Value)
    }

    $StartInfo.UseShellExecute = $false
    $StartInfo.CreateNoWindow = $false
    $StartInfo.RedirectStandardError = $true
    $StartInfo.RedirectStandardOutput = $true

    $Process = New-Object System.Diagnostics.Process
    $Process.StartInfo = $startInfo
    $Process.Start()
    
    $stdout = $Process.StandardOutput.ReadToEnd()
    $stderr = $Process.StandardError.ReadToEnd()
    
    $Process.WaitForExit()

    if($Process.ExitCode -ne 0)
    {
        Write-Host "stdout: $stdout"
        Write-Host "stderr: $stderr"
        Die "Build failed"
    }
}

function VSX 
{
    param(
        [ValidateSet('v140', 'v141', 'v142')]
        [Parameter(Position = 0, ValueFromPipeline = $true)]
        [string] $Toolchain
    )

    Write-Diagnostic "Starting to build targeting toolchain $Toolchain"

    Msvs "$Toolchain" 'Release' 'x86'
    Msvs "$Toolchain" 'Release' 'x64'

    Write-Diagnostic "Finished build targeting toolchain $Toolchain"
}

function NugetPackageRestore
{
    $nuget = Join-Path $WorkingDir .\nuget\NuGet.exe
    if(-not (Test-Path $nuget)) {
        Die "Please install nuget. More information available at: http://docs.nuget.org/docs/start-here/installing-nuget"
    }

    Write-Diagnostic "Restore Nuget Packages"

    # Restore packages
    . $nuget restore $FluxonautBrowserSln
}

function Nupkg
{
    if (Test-Path Env:\APPVEYOR_PULL_REQUEST_NUMBER)
    {
        Write-Diagnostic "Pr Number: $env:APPVEYOR_PULL_REQUEST_NUMBER"
        Write-Diagnostic "Skipping Nupkg"
        return
    }
    
    $nuget = Join-Path $WorkingDir .\nuget\NuGet.exe
    if(-not (Test-Path $nuget)) {
        Die "Please install nuget. More information available at: http://docs.nuget.org/docs/start-here/installing-nuget"
    }

    Write-Diagnostic "Building nuget package"

    # Build old packages
    . $nuget pack nuget\Fluxonaut.Browser.Common.nuspec -NoPackageAnalysis -Version $Version -OutputDirectory nuget -Properties "RedistVersion=$RedistVersion"
    . $nuget pack nuget\Fluxonaut.Browser.Wpf.nuspec -NoPackageAnalysis -Version $Version -OutputDirectory nuget
}

function DownloadNuget()
{
    $nuget = Join-Path $WorkingDir .\nuget\NuGet.exe
    if(-not (Test-Path $nuget))
    {
        $client = New-Object System.Net.WebClient;
        $client.DownloadFile('https://dist.nuget.org/win-x86-commandline/latest/nuget.exe', $nuget);
    }
}

function WriteAssemblyVersion
{
    param()

    $Filename = Join-Path $WorkingDir Fluxonaut.Browser\Properties\AssemblyInfo.cs
    $Regex = 'public const string AssemblyVersion = "(.*)"';
    $Regex2 = 'public const string AssemblyFileVersion = "(.*)"'
    $Regex3 = 'public const string AssemblyCopyright = "Copyright © .* The CefSharp Authors"'
    
    $AssemblyInfo = Get-Content -Encoding UTF8 $Filename
    $CurrentYear = Get-Date -Format yyyy
    
    $NewString = $AssemblyInfo -replace $Regex, "public const string AssemblyVersion = ""$AssemblyVersion"""
    $NewString = $NewString -replace $Regex2, "public const string AssemblyFileVersion = ""$AssemblyVersion.0"""
    $NewString = $NewString -replace $Regex3, "public const string AssemblyCopyright = ""Copyright © $CurrentYear The CefSharp Authors"""
    
    $Utf8NoBomEncoding = New-Object System.Text.UTF8Encoding $False
    [System.IO.File]::WriteAllLines($Filename, $NewString, $Utf8NoBomEncoding)
}

function WriteVersionToManifest($manifest)
{
    $Filename = Join-Path $WorkingDir $manifest
    $Regex = 'assemblyIdentity version="(.*?)"';
    
    $ManifestData = Get-Content -Encoding UTF8 $Filename
    $NewString = $ManifestData -replace $Regex, "assemblyIdentity version=""$AssemblyVersion.0"""
    
    $Utf8NoBomEncoding = New-Object System.Text.UTF8Encoding $False
    [System.IO.File]::WriteAllLines($Filename, $NewString, $Utf8NoBomEncoding)
}

function WriteVersionToResourceFile($resourceFile)
{
    $Filename = Join-Path $WorkingDir $resourceFile
    $Regex1 = 'VERSION .*';
    $Regex2 = 'Version", ".*?"';
    $Regex3 = 'Copyright © .* The CefSharp Authors'
    
    $ResourceData = Get-Content -Encoding UTF8 $Filename
    $CurrentYear = Get-Date -Format yyyy
    #Assembly version with comma instead of dot
    $CppAssemblyVersion = $AssemblyVersion -replace '\.', ','
    
    $NewString = $ResourceData -replace $Regex1, "VERSION $CppAssemblyVersion"
    $NewString = $NewString -replace $Regex2, "Version"", ""$AssemblyVersion"""
    $NewString = $NewString -replace $Regex3, "Copyright © $CurrentYear The CefSharp Authors"
    
    $Utf8NoBomEncoding = New-Object System.Text.UTF8Encoding $False
    [System.IO.File]::WriteAllLines($Filename, $NewString, $Utf8NoBomEncoding)
}

function WriteVersionToShfbproj
{
    $Filename = Join-Path $WorkingDir Fluxonaut.Browser.shfbproj
    $Regex1 = '<HelpFileVersion>.*<\/HelpFileVersion>';
    $Regex2 = '<HeaderText>Version .*<\/HeaderText>';
    
    $ShfbprojData = Get-Content -Encoding UTF8 $Filename
    $NewString = $ShfbprojData -replace $Regex1, "<HelpFileVersion>$AssemblyVersion</HelpFileVersion>"
    $NewString = $NewString -replace $Regex2, "<HeaderText>Version $AssemblyVersion</HeaderText>"
    
    $Utf8NoBomEncoding = New-Object System.Text.UTF8Encoding $False
    [System.IO.File]::WriteAllLines($Filename, $NewString, $Utf8NoBomEncoding)
}

Write-Diagnostic "CEF Redist Version = $RedistVersion"

DownloadNuget

NugetPackageRestore

WriteAssemblyVersion
WriteVersionToShfbproj

WriteVersionToManifest "Fluxonaut.Browser.BrowserSubprocess\app.manifest"
WriteVersionToManifest "Fluxonaut.Browser.Wpf.Example\app.manifest"

WriteVersionToResourceFile "Fluxonaut.Browser.BrowserSubprocess.Core\Resource.rc"
WriteVersionToResourceFile "Fluxonaut.Browser.Core\Resource.rc"

switch -Exact ($Target)
{
    "nupkg-only"
    {
        Nupkg
    }
    "vs2019"
    {
        VSX v142
        Nupkg
    }
}
