// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Fetch
{
    /// <summary>
    /// GetResponseBodyResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetResponseBodyResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string body
        {
            get;
            set;
        }

        /// <summary>
        /// body
        /// </summary>
        public string Body
        {
            get
            {
                return body;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal bool base64Encoded
        {
            get;
            set;
        }

        /// <summary>
        /// base64Encoded
        /// </summary>
        public bool Base64Encoded
        {
            get
            {
                return base64Encoded;
            }
        }
    }
}