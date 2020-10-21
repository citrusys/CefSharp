// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Target
{
    /// <summary>
    /// GetTargetInfoResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetTargetInfoResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Target.TargetInfo targetInfo
        {
            get;
            set;
        }

        /// <summary>
        /// targetInfo
        /// </summary>
        public Fluxonaut.Browser.DevTools.Target.TargetInfo TargetInfo
        {
            get
            {
                return targetInfo;
            }
        }
    }
}