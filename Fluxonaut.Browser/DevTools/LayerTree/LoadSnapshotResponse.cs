// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.LayerTree
{
    /// <summary>
    /// LoadSnapshotResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class LoadSnapshotResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string snapshotId
        {
            get;
            set;
        }

        /// <summary>
        /// snapshotId
        /// </summary>
        public string SnapshotId
        {
            get
            {
                return snapshotId;
            }
        }
    }
}