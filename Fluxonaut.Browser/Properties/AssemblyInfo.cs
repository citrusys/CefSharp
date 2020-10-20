using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Fluxonaut.Browser;

[assembly: AssemblyTitle("Fluxonaut.Browser")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AssemblyCompany(AssemblyInfo.AssemblyCompany)]
[assembly: AssemblyProduct(AssemblyInfo.AssemblyProduct)]
[assembly: AssemblyCopyright(AssemblyInfo.AssemblyCopyright)]
[assembly: ComVisible(AssemblyInfo.ComVisible)]
[assembly: AssemblyVersion(AssemblyInfo.AssemblyVersion)]
[assembly: AssemblyFileVersion(AssemblyInfo.AssemblyFileVersion)]
[assembly: CLSCompliant(AssemblyInfo.ClsCompliant)]

[assembly: InternalsVisibleTo(AssemblyInfo.FluxonautBrowserCoreProject)]
[assembly: InternalsVisibleTo(AssemblyInfo.FluxonautBrowserBrowserSubprocessProject)]
[assembly: InternalsVisibleTo(AssemblyInfo.FluxonautBrowserBrowserSubprocessCoreProject)]
[assembly: InternalsVisibleTo(AssemblyInfo.FluxonautBrowserWpfProject)]
[assembly: InternalsVisibleTo(AssemblyInfo.FluxonautBrowserOffScreenProject)]


namespace Fluxonaut.Browser
{
    /// <exclude />
    public static class AssemblyInfo
    {
        public const bool ClsCompliant = false;
        public const bool ComVisible = false;
        public const string AssemblyCompany = "The Fluxonaut Authors";
        public const string AssemblyProduct = "Fluxonaut Browser";
        public const string AssemblyVersion = "2.2.3";
        public const string AssemblyFileVersion = "2.2.3.0";
        public const string AssemblyCopyright = "Copyright © 2020 The Fluxonaut Authors";
        public const string FluxonautBrowserCoreProject = "Fluxonaut.Browser.Core";
        public const string FluxonautBrowserBrowserSubprocessProject = "Fluxonaut.Browser.BrowserSubprocess";
        public const string FluxonautBrowserBrowserSubprocessCoreProject = "Fluxonaut.Browser.BrowserSubprocess.Core";
        public const string FluxonautBrowserWpfProject = "Fluxonaut.Browser.Wpf";
        public const string FluxonautBrowserOffScreenProject = "Fluxonaut.Browser.OffScreen";
    }
}
