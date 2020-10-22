// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOMStorage
{
    /// <summary>
    /// GetDOMStorageItemsResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetDOMStorageItemsResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string[] entries
        {
            get;
            set;
        }

        /// <summary>
        /// entries
        /// </summary>
        public string[] Entries
        {
            get
            {
                return entries;
            }
        }
    }
}