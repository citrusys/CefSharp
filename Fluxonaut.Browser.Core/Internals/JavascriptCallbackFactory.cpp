// Copyright © 2015 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

#include "Stdafx.h"
#include "JavascriptCallbackProxy.h"
#include "JavascriptCallbackFactory.h"

namespace Fluxonaut
{
    namespace Browser
    {
        namespace Internals
        {
            IJavascriptCallback^ JavascriptCallbackFactory::Create(JavascriptCallback^ callback)
            {
                return gcnew JavascriptCallbackProxy(callback, _pendingTasks, BrowserAdapter);
            }
        }
    }
}