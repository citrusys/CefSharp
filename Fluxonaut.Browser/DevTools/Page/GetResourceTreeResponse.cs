// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Page
{
    /// <summary>
    /// GetResourceTreeResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetResourceTreeResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Page.FrameResourceTree frameTree
        {
            get;
            set;
        }

        /// <summary>
        /// frameTree
        /// </summary>
        public Fluxonaut.Browser.DevTools.Page.FrameResourceTree FrameTree
        {
            get
            {
                return frameTree;
            }
        }
    }
}