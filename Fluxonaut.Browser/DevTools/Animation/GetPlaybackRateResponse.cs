// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Animation
{
    /// <summary>
    /// GetPlaybackRateResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetPlaybackRateResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal long playbackRate
        {
            get;
            set;
        }

        /// <summary>
        /// playbackRate
        /// </summary>
        public long PlaybackRate
        {
            get
            {
                return playbackRate;
            }
        }
    }
}