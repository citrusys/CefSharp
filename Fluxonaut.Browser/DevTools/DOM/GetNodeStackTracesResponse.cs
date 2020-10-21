// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOM
{
    /// <summary>
    /// GetNodeStackTracesResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetNodeStackTracesResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Runtime.StackTrace creation
        {
            get;
            set;
        }

        /// <summary>
        /// creation
        /// </summary>
        public Fluxonaut.Browser.DevTools.Runtime.StackTrace Creation
        {
            get
            {
                return creation;
            }
        }
    }
}