// Copyright © 2019 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

#pragma once

#include "Stdafx.h"

#include "include\cef_v8.h"

using namespace System::Runtime::InteropServices;
using namespace Fluxonaut::Browser::RenderProcess;

namespace Fluxonaut
{
    namespace Browser
    {
        namespace BrowserSubprocess
        {
            private ref class V8Context : public IV8Context
            {
            private:
                MCefRefPtr<CefV8Context> _context;

            public:
                V8Context(CefRefPtr<CefV8Context> &context)
                    : _context(context)
                {
                }

                !V8Context()
                {
                    _context = NULL;
                }

                ~V8Context()
                {
                    this->!V8Context();
                }

                virtual bool Execute(String^ code, String^ scriptUrl, int startLine, [Out] V8Exception^ %exception)
                {
                    exception = nullptr;

                    CefRefPtr<CefV8Value> result;
                    CefRefPtr<CefV8Exception> ex;

                    if (_context->Eval(StringUtils::ToNative(code), StringUtils::ToNative(scriptUrl), startLine, result, ex))
                    {
                        return true;
                    }

                    exception = gcnew V8Exception(ex->GetEndColumn(),
                        ex->GetEndPosition(),
                        ex->GetLineNumber(),
                        StringUtils::ToClr(ex->GetMessage()),
                        StringUtils::ToClr(ex->GetScriptResourceName()),
                        StringUtils::ToClr(ex->GetSourceLine()),
                        ex->GetStartColumn(),
                        ex->GetStartPosition());

                    return false;
                }
            };
        }
    }
}