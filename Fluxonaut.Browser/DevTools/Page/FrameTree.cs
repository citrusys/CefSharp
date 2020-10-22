// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Page
{
    /// <summary>
    /// Information about the Frame hierarchy.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class FrameTree : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Frame information for this tree item.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("frame"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.Page.Frame Frame
        {
            get;
            set;
        }

        /// <summary>
        /// Child frames.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("childFrames"), IsRequired = (false))]
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Page.FrameTree> ChildFrames
        {
            get;
            set;
        }
    }
}