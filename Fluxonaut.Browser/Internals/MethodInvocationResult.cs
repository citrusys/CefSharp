// Copyright © 2015 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using Fluxonaut.Browser.JavascriptBinding;

namespace Fluxonaut.Browser.Internals
{
    public sealed class MethodInvocationResult
    {
        public int BrowserId { get; set; }

        public long? CallbackId { get; set; }

        public long FrameId { get; set; }

        public string Message { get; set; }

        public bool Success { get; set; }

        public object Result { get; set; }

        public IJavascriptNameConverter NameConverter { get; set; }
    }
}
