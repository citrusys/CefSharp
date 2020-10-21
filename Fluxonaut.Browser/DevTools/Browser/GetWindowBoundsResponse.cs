// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Browser
{
    /// <summary>
    /// GetWindowBoundsResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetWindowBoundsResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Browser.Bounds bounds
        {
            get;
            set;
        }

        /// <summary>
        /// bounds
        /// </summary>
        public Fluxonaut.Browser.DevTools.Browser.Bounds Bounds
        {
            get
            {
                return bounds;
            }
        }
    }
}