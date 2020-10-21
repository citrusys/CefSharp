// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Target
{
    /// <summary>
    /// CreateBrowserContextResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class CreateBrowserContextResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string browserContextId
        {
            get;
            set;
        }

        /// <summary>
        /// browserContextId
        /// </summary>
        public string BrowserContextId
        {
            get
            {
                return browserContextId;
            }
        }
    }
}