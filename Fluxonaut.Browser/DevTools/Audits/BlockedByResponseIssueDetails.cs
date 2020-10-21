// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Audits
{
    /// <summary>
    /// Details for a request that has been blocked with the BLOCKED_BY_RESPONSE
    /// code. Currently only used for COEP/COOP, but may be extended to include
    /// some CSP errors in the future.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class BlockedByResponseIssueDetails : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Request
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("request"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.Audits.AffectedRequest Request
        {
            get;
            set;
        }

        /// <summary>
        /// Frame
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("frame"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.Audits.AffectedFrame Frame
        {
            get;
            set;
        }

        /// <summary>
        /// Reason
        /// </summary>
        public Fluxonaut.Browser.DevTools.Audits.BlockedByResponseReason Reason
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Audits.BlockedByResponseReason)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Audits.BlockedByResponseReason), reason));
            }

            set
            {
                reason = (EnumToString(value));
            }
        }

        /// <summary>
        /// Reason
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("reason"), IsRequired = (true))]
        internal string reason
        {
            get;
            set;
        }
    }
}