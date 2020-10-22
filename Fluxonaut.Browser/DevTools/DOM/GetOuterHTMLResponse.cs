// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOM
{
    /// <summary>
    /// GetOuterHTMLResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetOuterHTMLResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string outerHTML
        {
            get;
            set;
        }

        /// <summary>
        /// outerHTML
        /// </summary>
        public string OuterHTML
        {
            get
            {
                return outerHTML;
            }
        }
    }
}