param(
	[Parameter(Position = 0, Mandatory = $true)] 
	[string] $Version
)

$WorkingDir = Split-Path -Parent $MyInvocation.MyCommand.Definition
$Nuget = Join-Path $WorkingDir \nuget\nuget.exe
$PackagePath = Join-Path $WorkingDir \nuget

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

Write-Diagnostic "Uploading packages to myget"

$Packages = @(
	"$PackagePath\Fluxonaut.Browser.Common.$Version.nupkg",
	"$PackagePath\Fluxonaut.Browser.Wpf.$Version.nupkg"
) 

$Packages | ForEach-Object {
	. $Nuget push $_ -Source GitHub
}