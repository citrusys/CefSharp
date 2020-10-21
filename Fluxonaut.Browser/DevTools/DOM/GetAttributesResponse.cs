// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOM
{
    /// <summary>
    /// GetAttributesResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetAttributesResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string[] attributes
        {
            get;
            set;
        }

        /// <summary>
        /// attributes
        /// </summary>
        public string[] Attributes
        {
            get
            {
                return attributes;
            }
        }
    }
}