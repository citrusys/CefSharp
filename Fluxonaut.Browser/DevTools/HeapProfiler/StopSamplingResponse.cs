// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.HeapProfiler
{
    /// <summary>
    /// StopSamplingResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class StopSamplingResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
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