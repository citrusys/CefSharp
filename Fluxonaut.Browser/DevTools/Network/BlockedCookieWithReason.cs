// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Network
{
    /// <summary>
    /// A cookie with was not sent with a request with the corresponding reason.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class BlockedCookieWithReason : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// The reason(s) the cookie was blocked.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Network.CookieBlockedReason[] BlockedReasons
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Network.CookieBlockedReason[])(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Network.CookieBlockedReason[]), blockedReasons));
            }

            set
            {
                blockedReasons = (EnumToString(value));
            }
        }

        /// <summary>
        /// The reason(s) the cookie was blocked.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("blockedReasons"), IsRequired = (true))]
        internal string blockedReasons
        {
            get;
            set;
        }

        /// <summary>
        /// The cookie object representing the cookie which was not sent.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("cookie"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.Network.Cookie Cookie
        {
            get;
            set;
        }
    }
}