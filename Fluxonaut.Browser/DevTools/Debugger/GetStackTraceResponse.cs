// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Debugger
{
    /// <summary>
    /// GetStackTraceResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetStackTraceResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Runtime.StackTrace stackTrace
        {
            get;
            set;
        }

        /// <summary>
        /// stackTrace
        /// </summary>
        public Fluxonaut.Browser.DevTools.Runtime.StackTrace StackTrace
        {
            get
            {
                return stackTrace;
            }
        }
    }
}