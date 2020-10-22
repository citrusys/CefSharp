// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Audits
{
    /// <summary>
    /// This information is currently necessary, as the front-end has a difficult
    /// time finding a specific cookie. With this, we can convey specific error
    /// information without the cookie.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class SameSiteCookieIssueDetails : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Cookie
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("cookie"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.Audits.AffectedCookie Cookie
        {
            get;
            set;
        }

        /// <summary>
        /// CookieWarningReasons
        /// </summary>
        public Fluxonaut.Browser.DevTools.Audits.SameSiteCookieWarningReason[] CookieWarningReasons
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Audits.SameSiteCookieWarningReason[])(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Audits.SameSiteCookieWarningReason[]), cookieWarningReasons));
            }

            set
            {
                cookieWarningReasons = (EnumToString(value));
            }
        }

        /// <summary>
        /// CookieWarningReasons
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("cookieWarningReasons"), IsRequired = (true))]
        internal string cookieWarningReasons
        {
            get;
            set;
        }

        /// <summary>
        /// CookieExclusionReasons
        /// </summary>
        public Fluxonaut.Browser.DevTools.Audits.SameSiteCookieExclusionReason[] CookieExclusionReasons
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Audits.SameSiteCookieExclusionReason[])(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Audits.SameSiteCookieExclusionReason[]), cookieExclusionReasons));
            }

            set
            {
                cookieExclusionReasons = (EnumToString(value));
            }
        }

        /// <summary>
        /// CookieExclusionReasons
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("cookieExclusionReasons"), IsRequired = (true))]
        internal string cookieExclusionReasons
        {
            get;
            set;
        }

        /// <summary>
        /// Optionally identifies the site-for-cookies and the cookie url, which
        /// may be used by the front-end as additional context.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Audits.SameSiteCookieOperation Operation
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Audits.SameSiteCookieOperation)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Audits.SameSiteCookieOperation), operation));
            }

            set
            {
                operation = (EnumToString(value));
            }
        }

        /// <summary>
        /// Optionally identifies the site-for-cookies and the cookie url, which
        /// may be used by the front-end as additional context.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("operation"), IsRequired = (true))]
        internal string operation
        {
            get;
            set;
        }

        /// <summary>
        /// SiteForCookies
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("siteForCookies"), IsRequired = (false))]
        public string SiteForCookies
        {
            get;
            set;
        }

        /// <summary>
        /// CookieUrl
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("cookieUrl"), IsRequired = (false))]
        public string CookieUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Request
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("request"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.Audits.AffectedRequest Request
        {
            get;
            set;
        }
    }
}