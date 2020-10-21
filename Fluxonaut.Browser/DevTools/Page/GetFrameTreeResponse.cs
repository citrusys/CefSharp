// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Page
{
    /// <summary>
    /// GetFrameTreeResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetFrameTreeResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Page.FrameTree frameTree
        {
            get;
            set;
        }

        /// <summary>
        /// frameTree
        /// </summary>
        public Fluxonaut.Browser.DevTools.Page.FrameTree FrameTree
        {
            get
            {
                return frameTree;
            }
        }
    }
}