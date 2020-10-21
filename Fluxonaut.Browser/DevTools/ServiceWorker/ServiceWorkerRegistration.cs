// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.ServiceWorker
{
    /// <summary>
    /// ServiceWorker registration.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class ServiceWorkerRegistration : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// RegistrationId
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("registrationId"), IsRequired = (true))]
        public string RegistrationId
        {
            get;
            set;
        }

        /// <summary>
        /// ScopeURL
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("scopeURL"), IsRequired = (true))]
        public string ScopeURL
        {
            get;
            set;
        }

        /// <summary>
        /// IsDeleted
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("isDeleted"), IsRequired = (true))]
        public bool IsDeleted
        {
            get;
            set;
        }
    }
}