// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOMStorage
{
    /// <summary>
    /// DOM Storage identifier.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class StorageId : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Security origin for the storage.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("securityOrigin"), IsRequired = (true))]
        public string SecurityOrigin
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the storage is local storage (not session storage).
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("isLocalStorage"), IsRequired = (true))]
        public bool IsLocalStorage
        {
            get;
            set;
        }
    }
}