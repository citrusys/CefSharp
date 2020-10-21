// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Animation
{
    /// <summary>
    /// GetCurrentTimeResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetCurrentTimeResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal long currentTime
        {
            get;
            set;
        }

        /// <summary>
        /// currentTime
        /// </summary>
        public long CurrentTime
        {
            get
            {
                return currentTime;
            }
        }
    }
}