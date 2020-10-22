// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.HeapProfiler
{
    /// <summary>
    /// Sampling profile.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class SamplingHeapProfile : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Head
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("head"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.HeapProfiler.SamplingHeapProfileNode Head
        {
            get;
            set;
        }

        /// <summary>
        /// Samples
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("samples"), IsRequired = (true))]
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.HeapProfiler.SamplingHeapProfileSample> Samples
        {
            get;
            set;
        }
    }
}