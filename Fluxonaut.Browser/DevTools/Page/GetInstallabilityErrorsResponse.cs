// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Page
{
    /// <summary>
    /// GetInstallabilityErrorsResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetInstallabilityErrorsResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Page.InstallabilityError> installabilityErrors
        {
            get;
            set;
        }

        /// <summary>
        /// installabilityErrors
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Page.InstallabilityError> InstallabilityErrors
        {
            get
            {
                return installabilityErrors;
            }
        }
    }
}