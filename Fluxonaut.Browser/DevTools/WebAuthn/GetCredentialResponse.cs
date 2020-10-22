// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.WebAuthn
{
    /// <summary>
    /// GetCredentialResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetCredentialResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.WebAuthn.Credential credential
        {
            get;
            set;
        }

        /// <summary>
        /// credential
        /// </summary>
        public Fluxonaut.Browser.DevTools.WebAuthn.Credential Credential
        {
            get
            {
                return credential;
            }
        }
    }
}