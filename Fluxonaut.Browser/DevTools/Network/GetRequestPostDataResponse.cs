// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Network
{
    /// <summary>
    /// GetRequestPostDataResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetRequestPostDataResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string postData
        {
            get;
            set;
        }

        /// <summary>
        /// postData
        /// </summary>
        public string PostData
        {
            get
            {
                return postData;
            }
        }
    }
}