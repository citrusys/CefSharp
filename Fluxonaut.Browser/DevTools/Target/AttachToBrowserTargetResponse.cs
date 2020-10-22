// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Target
{
    /// <summary>
    /// AttachToBrowserTargetResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class AttachToBrowserTargetResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string sessionId
        {
            get;
            set;
        }

        /// <summary>
        /// sessionId
        /// </summary>
        public string SessionId
        {
            get
            {
                return sessionId;
            }
        }
    }
}