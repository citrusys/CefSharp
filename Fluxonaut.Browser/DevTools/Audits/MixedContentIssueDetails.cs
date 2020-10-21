// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Audits
{
    /// <summary>
    /// MixedContentIssueDetails
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class MixedContentIssueDetails : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// The type of resource causing the mixed content issue (css, js, iframe,
        /// form,...). Marked as optional because it is mapped to from
        /// blink::mojom::RequestContextType, which will be replaced
        /// by network::mojom::RequestDestination
        /// </summary>
        public Fluxonaut.Browser.DevTools.Audits.MixedContentResourceType? ResourceType
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Audits.MixedContentResourceType? )(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Audits.MixedContentResourceType? ), resourceType));
            }

            set
            {
                resourceType = (EnumToString(value));
            }
        }

        /// <summary>
        /// The type of resource causing the mixed content issue (css, js, iframe,
        /// form,...). Marked as optional because it is mapped to from
        /// blink::mojom::RequestContextType, which will be replaced
        /// by network::mojom::RequestDestination
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("resourceType"), IsRequired = (false))]
        internal string resourceType
        {
            get;
            set;
        }

        /// <summary>
        /// The way the mixed content issue is being resolved.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Audits.MixedContentResolutionStatus ResolutionStatus
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Audits.MixedContentResolutionStatus)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Audits.MixedContentResolutionStatus), resolutionStatus));
            }

            set
            {
                resolutionStatus = (EnumToString(value));
            }
        }

        /// <summary>
        /// The way the mixed content issue is being resolved.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("resolutionStatus"), IsRequired = (true))]
        internal string resolutionStatus
        {
            get;
            set;
        }

        /// <summary>
        /// The unsafe http url causing the mixed content issue.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("insecureURL"), IsRequired = (true))]
        public string InsecureURL
        {
            get;
            set;
        }

        /// <summary>
        /// The url responsible for the call to an unsafe url.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("mainResourceURL"), IsRequired = (true))]
        public string MainResourceURL
        {
            get;
            set;
        }

        /// <summary>
        /// The mixed content request.
        /// Does not always exist (e.g. for unsafe form submission urls).
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("request"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.Audits.AffectedRequest Request
        {
            get;
            set;
        }

        /// <summary>
        /// Optional because not every mixed content issue is necessarily linked to a frame.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("frame"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.Audits.AffectedFrame Frame
        {
            get;
            set;
        }
    }
}