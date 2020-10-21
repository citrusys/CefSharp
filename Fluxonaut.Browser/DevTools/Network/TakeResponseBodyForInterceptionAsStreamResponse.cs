// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Network
{
    /// <summary>
    /// TakeResponseBodyForInterceptionAsStreamResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class TakeResponseBodyForInterceptionAsStreamResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string stream
        {
            get;
            set;
        }

        /// <summary>
        /// stream
        /// </summary>
        public string Stream
        {
            get
            {
                return stream;
            }
        }
    }
}