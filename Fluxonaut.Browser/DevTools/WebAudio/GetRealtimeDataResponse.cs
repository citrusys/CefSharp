// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.WebAudio
{
    /// <summary>
    /// GetRealtimeDataResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetRealtimeDataResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.WebAudio.ContextRealtimeData realtimeData
        {
            get;
            set;
        }

        /// <summary>
        /// realtimeData
        /// </summary>
        public Fluxonaut.Browser.DevTools.WebAudio.ContextRealtimeData RealtimeData
        {
            get
            {
                return realtimeData;
            }
        }
    }
}