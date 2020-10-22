// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.LayerTree
{
    /// <summary>
    /// Rectangle where scrolling happens on the main thread.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class ScrollRect : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Rectangle itself.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("rect"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.DOM.Rect Rect
        {
            get;
            set;
        }

        /// <summary>
        /// Reason for rectangle to force scrolling on the main thread
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("type"), IsRequired = (true))]
        public string Type
        {
            get;
            set;
        }
    }
}