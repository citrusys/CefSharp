// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOM
{
    /// <summary>
    /// GetFlattenedDocumentResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetFlattenedDocumentResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.DOM.Node> nodes
        {
            get;
            set;
        }

        /// <summary>
        /// nodes
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.DOM.Node> Nodes
        {
            get
            {
                return nodes;
            }
        }
    }
}