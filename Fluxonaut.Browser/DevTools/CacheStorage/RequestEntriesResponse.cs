// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CacheStorage
{
    /// <summary>
    /// RequestEntriesResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class RequestEntriesResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CacheStorage.DataEntry> cacheDataEntries
        {
            get;
            set;
        }

        /// <summary>
        /// cacheDataEntries
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CacheStorage.DataEntry> CacheDataEntries
        {
            get
            {
                return cacheDataEntries;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal long returnCount
        {
            get;
            set;
        }

        /// <summary>
        /// returnCount
        /// </summary>
        public long ReturnCount
        {
            get
            {
                return returnCount;
            }
        }
    }
}