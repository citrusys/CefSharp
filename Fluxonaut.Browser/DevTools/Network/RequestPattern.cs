// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Network
{
    /// <summary>
    /// Request pattern for interception.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class RequestPattern : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Wildcards ('*' -> zero or more, '?' -> exactly one) are allowed. Escape character is
        /// backslash. Omitting is equivalent to "*".
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("urlPattern"), IsRequired = (false))]
        public string UrlPattern
        {
            get;
            set;
        }

        /// <summary>
        /// If set, only requests for matching resource types will be intercepted.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Network.ResourceType? ResourceType
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Network.ResourceType? )(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Network.ResourceType? ), resourceType));
            }

            set
            {
                resourceType = (EnumToString(value));
            }
        }

        /// <summary>
        /// If set, only requests for matching resource types will be intercepted.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("resourceType"), IsRequired = (false))]
        internal string resourceType
        {
            get;
            set;
        }

        /// <summary>
        /// Stage at wich to begin intercepting requests. Default is Request.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Network.InterceptionStage? InterceptionStage
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Network.InterceptionStage? )(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Network.InterceptionStage? ), interceptionStage));
            }

            set
            {
                interceptionStage = (EnumToString(value));
            }
        }

        /// <summary>
        /// Stage at wich to begin intercepting requests. Default is Request.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("interceptionStage"), IsRequired = (false))]
        internal string interceptionStage
        {
            get;
            set;
        }
    }
}