// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOM
{
    /// <summary>
    /// GetDocumentResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetDocumentResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.DOM.Node root
        {
            get;
            set;
        }

        /// <summary>
        /// root
        /// </summary>
        public Fluxonaut.Browser.DevTools.DOM.Node Root
        {
            get
            {
                return root;
            }
        }
    }
}