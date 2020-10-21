// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.HeapProfiler
{
    /// <summary>
    /// GetSamplingProfileResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetSamplingProfileResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.HeapProfiler.SamplingHeapProfile profile
        {
            get;
            set;
        }

        /// <summary>
        /// profile
        /// </summary>
        public Fluxonaut.Browser.DevTools.HeapProfiler.SamplingHeapProfile Profile
        {
            get
            {
                return profile;
            }
        }
    }
}