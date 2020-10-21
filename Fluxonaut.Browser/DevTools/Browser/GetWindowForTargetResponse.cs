// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Browser
{
    /// <summary>
    /// GetWindowForTargetResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetWindowForTargetResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal int windowId
        {
            get;
            set;
        }

        /// <summary>
        /// windowId
        /// </summary>
        public int WindowId
        {
            get
            {
                return windowId;
            }
        }

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