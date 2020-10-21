// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Audits
{
    /// <summary>
    /// An inspector issue reported from the back-end.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class InspectorIssue : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Code
        /// </summary>
        public Fluxonaut.Browser.DevTools.Audits.InspectorIssueCode Code
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Audits.InspectorIssueCode)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Audits.InspectorIssueCode), code));
            }

            set
            {
                code = (EnumToString(value));
            }
        }

        /// <summary>
        /// Code
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("code"), IsRequired = (true))]
        internal string code
        {
            get;
            set;
        }

        /// <summary>
        /// Details
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("details"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.Audits.InspectorIssueDetails Details
        {
            get;
            set;
        }
    }
}