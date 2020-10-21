// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CacheStorage
{
    /// <summary>
    /// Cache identifier.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class Cache : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// An opaque unique id of the cache.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("cacheId"), IsRequired = (true))]
        public string CacheId
        {
            get;
            set;
        }

        /// <summary>
        /// Security origin of the cache.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("securityOrigin"), IsRequired = (true))]
        public string SecurityOrigin
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the cache.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("cacheName"), IsRequired = (true))]
        public string CacheName
        {
            get;
            set;
        }
    }
}