// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.IO
{
    /// <summary>
    /// ResolveBlobResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class ResolveBlobResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string uuid
        {
            get;
            set;
        }

        /// <summary>
        /// uuid
        /// </summary>
        public string Uuid
        {
            get
            {
                return uuid;
            }
        }
    }
}