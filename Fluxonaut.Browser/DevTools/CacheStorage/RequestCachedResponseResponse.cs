// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CacheStorage
{
    /// <summary>
    /// RequestCachedResponseResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class RequestCachedResponseResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.CacheStorage.CachedResponse response
        {
            get;
            set;
        }

        /// <summary>
        /// response
        /// </summary>
        public Fluxonaut.Browser.DevTools.CacheStorage.CachedResponse Response
        {
            get
            {
                return response;
            }
        }
    }
}