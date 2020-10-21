// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.ApplicationCache
{
    /// <summary>
    /// GetManifestForFrameResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetManifestForFrameResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string manifestURL
        {
            get;
            set;
        }

        /// <summary>
        /// manifestURL
        /// </summary>
        public string ManifestURL
        {
            get
            {
                return manifestURL;
            }
        }
    }
}