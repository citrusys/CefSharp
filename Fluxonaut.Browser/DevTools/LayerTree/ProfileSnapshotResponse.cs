// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.LayerTree
{
    /// <summary>
    /// ProfileSnapshotResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class ProfileSnapshotResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal long[] timings
        {
            get;
            set;
        }

        /// <summary>
        /// timings
        /// </summary>
        public long[] Timings
        {
            get
            {
                return timings;
            }
        }
    }
}