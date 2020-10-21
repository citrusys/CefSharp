// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Network
{
    /// <summary>
    /// Information about the cached resource.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class CachedResource : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Resource URL. This is the url of the original network request.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("url"), IsRequired = (true))]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// Type of this resource.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Network.ResourceType Type
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Network.ResourceType)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Network.ResourceType), type));
            }

            set
            {
                type = (EnumToString(value));
            }
        }

        /// <summary>
        /// Type of this resource.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("type"), IsRequired = (true))]
        internal string type
        {
            get;
            set;
        }

        /// <summary>
        /// Cached response data.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("response"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.Network.Response Response
        {
            get;
            set;
        }

        /// <summary>
        /// Cached response body size.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("bodySize"), IsRequired = (true))]
        public long BodySize
        {
            get;
            set;
        }
    }
}