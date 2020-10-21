// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.HeapProfiler
{
    /// <summary>
    /// GetObjectByHeapObjectIdResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetObjectByHeapObjectIdResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Runtime.RemoteObject result
        {
            get;
            set;
        }

        /// <summary>
        /// result
        /// </summary>
        public Fluxonaut.Browser.DevTools.Runtime.RemoteObject Result
        {
            get
            {
                return result;
            }
        }
    }
}