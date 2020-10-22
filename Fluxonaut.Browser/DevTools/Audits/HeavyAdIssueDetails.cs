// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Audits
{
    /// <summary>
    /// HeavyAdIssueDetails
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class HeavyAdIssueDetails : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// The resolution status, either blocking the content or warning.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Audits.HeavyAdResolutionStatus Resolution
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Audits.HeavyAdResolutionStatus)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Audits.HeavyAdResolutionStatus), resolution));
            }

            set
            {
                resolution = (EnumToString(value));
            }
        }

        /// <summary>
        /// The resolution status, either blocking the content or warning.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("resolution"), IsRequired = (true))]
        internal string resolution
        {
            get;
            set;
        }

        /// <summary>
        /// The reason the ad was blocked, total network or cpu or peak cpu.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Audits.HeavyAdReason Reason
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Audits.HeavyAdReason)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Audits.HeavyAdReason), reason));
            }

            set
            {
                reason = (EnumToString(value));
            }
        }

        /// <summary>
        /// The reason the ad was blocked, total network or cpu or peak cpu.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("reason"), IsRequired = (true))]
        internal string reason
        {
            get;
            set;
        }

        /// <summary>
        /// The frame that was blocked.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("frame"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.Audits.AffectedFrame Frame
        {
            get;
            set;
        }
    }
}