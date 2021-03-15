using System;
using System.Reflection;
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

namespace Fluxonaut.Browser
{
    /// <exclude />
    public static class AssemblyInfo
    {
        public const bool ClsCompliant = false;
        public const bool ComVisible = false;
        public const string AssemblyCompany = "The CefSharp Authors Modified by Fluxonaut";
        public const string AssemblyProduct = "Fluxonaut Browser";
        public const string AssemblyVersion = "2.4.0";
        public const string AssemblyFileVersion = "2.4.0.0";
        public const string AssemblyCopyright = "Copyright © 2021 The CefSharp Authors";
        public const string FluxonautBrowserCoreProject = "Fluxonaut.Browser.Core";
        public const string FluxonautBrowserBrowserSubprocessProject = "Fluxonaut.Browser.BrowserSubprocess";
        public const string FluxonautBrowserBrowserSubprocessCoreProject = "Fluxonaut.Browser.BrowserSubprocess.Core";
        public const string FluxonautBrowserWpfProject = "Fluxonaut.Browser.Wpf";
        public const string FluxonautBrowserOffScreenProject = "Fluxonaut.Browser.OffScreen";
    }
}
