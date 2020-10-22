// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

#pragma once

#include "include/cef_v8.h"
#include "..\Fluxonaut.Browser.Core\Internals\Messaging\Messages.h"
#include "..\Fluxonaut.Browser.Core\Internals\Serialization\Primitives.h"
#include "Serialization\V8Serialization.h"

using namespace System;
using namespace Fluxonaut::Browser::Internals::Messaging;
using namespace Fluxonaut::Browser::Internals::Serialization;

namespace Fluxonaut
{
    namespace Browser
    {
        const CefString kSendEvalScriptResponse = CefString("SendEvalScriptResponse");
        const CefString kSendEvalScriptResponseCamelCase = CefString("sendEvalScriptResponse");

        private class JavascriptPromiseHandler : public CefV8Handler
        {
        public:

            virtual bool Execute(const CefString& name,
                CefRefPtr<CefV8Value> object,
                const CefV8ValueList& arguments,
                CefRefPtr<CefV8Value>& retval,
                CefString& exception)
            {
                if (arguments.size() < 2)
                {
                    //TODO: Improve error message
                    exception = "Must specify a callback Id and then/catch.";

                    return true;
                }

                auto callbackId = arguments[0]->GetIntValue();

                if (callbackId == 0)
                {
                    exception = "Invalid callback Id";

                    return true;
                }

                auto success = arguments[1]->GetBoolValue();

                auto response = CefProcessMessage::Create(kEvaluateJavascriptResponse);

                auto responseArgList = response->GetArgumentList();
                //Success
                responseArgList->SetBool(0, success);
                //Callback Id
                SetInt64(responseArgList, 1, callbackId);
                if (exception == "")
                {
                    if (success)
                    {
                        SerializeV8Object(arguments[2], responseArgList, 2, nullptr);
                    }
                    else
                    {
                        auto reason = arguments[2];
                        responseArgList->SetString(2, reason->GetStringValue());
                    }
                }
                else
                {
                    responseArgList->SetString(2, exception);
                }

                auto context = CefV8Context::GetCurrentContext();

                auto frame = context->GetFrame();

                frame->SendProcessMessage(CefProcessId::PID_BROWSER, response);

                return false;
            }

            IMPLEMENT_REFCOUNTING(JavascriptPromiseHandler);
        };
    }
}
