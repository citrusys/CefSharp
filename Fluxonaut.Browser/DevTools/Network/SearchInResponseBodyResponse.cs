// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Network
{
    /// <summary>
    /// SearchInResponseBodyResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class SearchInResponseBodyResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Debugger.SearchMatch> result
        {
            get;
            set;
        }

        /// <summary>
        /// result
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Debugger.SearchMatch> Result
        {
            get
            {
                return result;
            }
        }
    }
}