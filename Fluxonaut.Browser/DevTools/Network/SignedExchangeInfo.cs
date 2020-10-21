// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Network
{
    /// <summary>
    /// Information about a signed exchange response.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class SignedExchangeInfo : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// The outer response of signed HTTP exchange which was received from network.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("outerResponse"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.Network.Response OuterResponse
        {
            get;
            set;
        }

        /// <summary>
        /// Information about the signed exchange header.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("header"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.Network.SignedExchangeHeader Header
        {
            get;
            set;
        }

        /// <summary>
        /// Security details for the signed exchange header.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("securityDetails"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.Network.SecurityDetails SecurityDetails
        {
            get;
            set;
        }

        /// <summary>
        /// Errors occurred while handling the signed exchagne.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("errors"), IsRequired = (false))]
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Network.SignedExchangeError> Errors
        {
            get;
            set;
        }
    }
}