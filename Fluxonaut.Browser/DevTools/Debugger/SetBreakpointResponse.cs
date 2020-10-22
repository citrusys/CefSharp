// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Debugger
{
    /// <summary>
    /// SetBreakpointResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class SetBreakpointResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string breakpointId
        {
            get;
            set;
        }

        /// <summary>
        /// breakpointId
        /// </summary>
        public string BreakpointId
        {
            get
            {
                return breakpointId;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Debugger.Location actualLocation
        {
            get;
            set;
        }

        /// <summary>
        /// actualLocation
        /// </summary>
        public Fluxonaut.Browser.DevTools.Debugger.Location ActualLocation
        {
            get
            {
                return actualLocation;
            }
        }
    }
}