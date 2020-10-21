// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.SystemInfo
{
    /// <summary>
    /// GetProcessInfoResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetProcessInfoResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.SystemInfo.ProcessInfo> processInfo
        {
            get;
            set;
        }

        /// <summary>
        /// processInfo
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.SystemInfo.ProcessInfo> ProcessInfo
        {
            get
            {
                return processInfo;
            }
        }
    }
}