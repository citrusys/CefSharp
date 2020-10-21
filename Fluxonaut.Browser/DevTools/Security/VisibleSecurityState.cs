// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Security
{
    /// <summary>
    /// Security state information about the page.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class VisibleSecurityState : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// The security level of the page.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Security.SecurityState SecurityState
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Security.SecurityState)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Security.SecurityState), securityState));
            }

            set
            {
                securityState = (EnumToString(value));
            }
        }

        /// <summary>
        /// The security level of the page.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("securityState"), IsRequired = (true))]
        internal string securityState
        {
            get;
            set;
        }

        /// <summary>
        /// Security state details about the page certificate.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("certificateSecurityState"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.Security.CertificateSecurityState CertificateSecurityState
        {
            get;
            set;
        }

        /// <summary>
        /// The type of Safety Tip triggered on the page. Note that this field will be set even if the Safety Tip UI was not actually shown.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("safetyTipInfo"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.Security.SafetyTipInfo SafetyTipInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Array of security state issues ids.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("securityStateIssueIds"), IsRequired = (true))]
        public string[] SecurityStateIssueIds
        {
            get;
            set;
        }
    }
}