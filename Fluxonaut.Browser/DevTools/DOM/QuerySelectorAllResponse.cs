// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOM
{
    /// <summary>
    /// QuerySelectorAllResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class QuerySelectorAllResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal int[] nodeIds
        {
            get;
            set;
        }

        /// <summary>
        /// nodeIds
        /// </summary>
        public int[] NodeIds
        {
            get
            {
                return nodeIds;
            }
        }
    }
}