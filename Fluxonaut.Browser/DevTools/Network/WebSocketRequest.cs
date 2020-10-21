// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Network
{
    /// <summary>
    /// WebSocket request data.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class WebSocketRequest : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// HTTP request headers.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("headers"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.Network.Headers Headers
        {
            get;
            set;
        }
    }
}