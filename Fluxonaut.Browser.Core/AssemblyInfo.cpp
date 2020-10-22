// Copyright © 2010 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

#include "Stdafx.h"

using namespace System;
using namespace System::Reflection;
using namespace System::Runtime::CompilerServices;
using namespace System::Runtime::InteropServices;
using namespace System::Security::Permissions;
using namespace Fluxonaut::Browser;

[assembly:AssemblyTitle("Fluxonaut.Browser.Core")];
[assembly:AssemblyDescription("FluxonautBrowser Core Library (VC++)")];
[assembly:AssemblyCompany(AssemblyInfo::AssemblyCompany)];
[assembly:AssemblyProduct(AssemblyInfo::AssemblyProduct)];
[assembly:AssemblyCopyright(AssemblyInfo::AssemblyCopyright)];

[assembly:AssemblyVersion(AssemblyInfo::AssemblyVersion)];
[assembly:ComVisible(AssemblyInfo::ComVisible)];
[assembly:CLSCompliant(AssemblyInfo::ClsCompliant)];

[assembly:AssemblyConfiguration("")];
[assembly:AssemblyTrademark("")];
[assembly:AssemblyCulture("")];

[assembly:InternalsVisibleTo(AssemblyInfo::FluxonautBrowserBrowserSubprocessCoreProject)];
[assembly:InternalsVisibleTo(AssemblyInfo::FluxonautBrowserBrowserSubprocessProject)];
[assembly:InternalsVisibleTo(AssemblyInfo::FluxonautBrowserWpfProject)];
[assembly:InternalsVisibleTo(AssemblyInfo::FluxonautBrowserOffScreenProject)];
