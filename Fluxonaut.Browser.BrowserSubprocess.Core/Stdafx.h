// Copyright © 2014 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

#pragma once

#ifdef EXPORT
#define DECL __declspec(dllexport)
#else
#define DECL __declspec(dllimport)
#endif

#include <vector>

#include <include/cef_base.h>

#include ".\..\Fluxonaut.Browser.Core.Runtime\Internals\MCefRefPtr.h"
#include ".\..\Fluxonaut.Browser.Core.Runtime\Internals\StringUtils.h"
#include "vcclr_local.h"

using namespace System;
using namespace Fluxonaut::Browser;
using namespace Fluxonaut::Browser::Internals;
