// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOMSnapshot
{
    /// <summary>
    /// A subset of the full ComputedStyle as defined by the request whitelist.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class ComputedStyle : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Name/value pairs of computed style properties.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("properties"), IsRequired = (true))]
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.DOMSnapshot.NameValue> Properties
        {
            get;
            set;
        }
    }
}