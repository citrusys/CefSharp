// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Performance
{
    /// <summary>
    /// GetMetricsResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetMetricsResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Performance.Metric> metrics
        {
            get;
            set;
        }

        /// <summary>
        /// metrics
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Performance.Metric> Metrics
        {
            get
            {
                return metrics;
            }
        }
    }
}