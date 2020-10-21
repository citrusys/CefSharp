// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Browser
{
    /// <summary>
    /// GetHistogramResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetHistogramResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Browser.Histogram histogram
        {
            get;
            set;
        }

        /// <summary>
        /// histogram
        /// </summary>
        public Fluxonaut.Browser.DevTools.Browser.Histogram Histogram
        {
            get
            {
                return histogram;
            }
        }
    }
}