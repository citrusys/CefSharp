// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Network
{
    /// <summary>
    /// GetAllCookiesResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetAllCookiesResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Network.Cookie> cookies
        {
            get;
            set;
        }

        /// <summary>
        /// cookies
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Network.Cookie> Cookies
        {
            get
            {
                return cookies;
            }
        }
    }
}