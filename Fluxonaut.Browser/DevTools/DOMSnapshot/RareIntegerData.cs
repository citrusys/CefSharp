// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOMSnapshot
{
    /// <summary>
    /// RareIntegerData
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class RareIntegerData : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
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

        /// <summary>
        /// Value
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("value"), IsRequired = (true))]
        public int[] Value
        {
            get;
            set;
        }
    }
}