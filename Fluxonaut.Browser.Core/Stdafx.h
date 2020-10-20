// Copyright © 2010 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

#pragma once

#ifdef EXPORT
#define DECL __declspec(dllexport)
#else
#define DECL __declspec(dllimport)
#endif

#include <vector>
#include <list>

#include <include/cef_base.h>

#include "Internals\MCefRefPtr.h"
#include "Internals\StringUtils.h"
#include "vcclr_local.h"

using namespace Fluxonaut::Browser;
using namespace Fluxonaut::Browser::Internals;
using namespace System;