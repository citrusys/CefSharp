// Copyright © 2014 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

namespace Fluxonaut.Browser.Internals
{
    public class RenderprocessClientFactory
    {
        private const string BaseAddress = "net.pipe://localhost";
        private const string ServiceName = "FluxonautBrowserSubProcessProxy";

        public static string GetServiceName(int parentProcessId, int browserId)
        {
            return string.Join("/", BaseAddress, ServiceName, parentProcessId, browserId);
        }
    }
}
