// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOM
{
    /// <summary>
    /// DescribeNodeResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class DescribeNodeResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.DOM.Node node
        {
            get;
            set;
        }

        /// <summary>
        /// node
        /// </summary>
        public Fluxonaut.Browser.DevTools.DOM.Node Node
        {
            get
            {
                return node;
            }
        }
    }
}