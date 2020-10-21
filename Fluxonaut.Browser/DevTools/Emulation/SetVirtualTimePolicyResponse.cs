// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Emulation
{
    /// <summary>
    /// SetVirtualTimePolicyResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class SetVirtualTimePolicyResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal long virtualTimeTicksBase
        {
            get;
            set;
        }

        /// <summary>
        /// virtualTimeTicksBase
        /// </summary>
        public long VirtualTimeTicksBase
        {
            get
            {
                return virtualTimeTicksBase;
            }
        }
    }
}