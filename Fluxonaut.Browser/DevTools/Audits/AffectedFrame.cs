// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Audits
{
    /// <summary>
    /// Information about the frame affected by an inspector issue.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class AffectedFrame : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// FrameId
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("frameId"), IsRequired = (true))]
        public string FrameId
        {
            get;
            set;
        }
    }
}