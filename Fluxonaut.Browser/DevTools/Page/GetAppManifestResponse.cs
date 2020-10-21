// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Page
{
    /// <summary>
    /// GetAppManifestResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetAppManifestResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string url
        {
            get;
            set;
        }

        /// <summary>
        /// url
        /// </summary>
        public string Url
        {
            get
            {
                return url;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Page.AppManifestError> errors
        {
            get;
            set;
        }

        /// <summary>
        /// errors
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Page.AppManifestError> Errors
        {
            get
            {
                return errors;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal string data
        {
            get;
            set;
        }

        /// <summary>
        /// data
        /// </summary>
        public string Data
        {
            get
            {
                return data;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Page.AppManifestParsedProperties parsed
        {
            get;
            set;
        }

        /// <summary>
        /// parsed
        /// </summary>
        public Fluxonaut.Browser.DevTools.Page.AppManifestParsedProperties Parsed
        {
            get
            {
                return parsed;
            }
        }
    }
}