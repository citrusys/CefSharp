// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Debugger
{
    /// <summary>
    /// GetPossibleBreakpointsResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetPossibleBreakpointsResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Debugger.BreakLocation> locations
        {
            get;
            set;
        }

        /// <summary>
        /// locations
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Debugger.BreakLocation> Locations
        {
            get
            {
                return locations;
            }
        }
    }
}