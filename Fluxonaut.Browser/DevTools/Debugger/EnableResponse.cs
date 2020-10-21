// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Debugger
{
    /// <summary>
    /// EnableResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class EnableResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string debuggerId
        {
            get;
            set;
        }

        /// <summary>
        /// debuggerId
        /// </summary>
        public string DebuggerId
        {
            get
            {
                return debuggerId;
            }
        }
    }
}