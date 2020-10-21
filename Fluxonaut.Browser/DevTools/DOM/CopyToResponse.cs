// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOM
{
    /// <summary>
    /// CopyToResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class CopyToResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal int nodeId
        {
            get;
            set;
        }

        /// <summary>
        /// nodeId
        /// </summary>
        public int NodeId
        {
            get
            {
                return nodeId;
            }
        }
    }
}