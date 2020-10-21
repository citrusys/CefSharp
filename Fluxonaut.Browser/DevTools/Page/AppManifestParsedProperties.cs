// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Page
{
    /// <summary>
    /// Parsed app manifest properties.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class AppManifestParsedProperties : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Computed scope value
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("scope"), IsRequired = (true))]
        public string Scope
        {
            get;
            set;
        }
    }
}