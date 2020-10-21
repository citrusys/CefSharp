// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Target
{
    /// <summary>
    /// GetBrowserContextsResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetBrowserContextsResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string[] browserContextIds
        {
            get;
            set;
        }

        /// <summary>
        /// browserContextIds
        /// </summary>
        public string[] BrowserContextIds
        {
            get
            {
                return browserContextIds;
            }
        }
    }
}