// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOMSnapshot
{
    /// <summary>
    /// RareBooleanData
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class RareBooleanData : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Index
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("index"), IsRequired = (true))]
        public int[] Index
        {
            get;
            set;
        }
    }
}