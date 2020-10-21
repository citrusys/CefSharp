// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Media
{
    /// <summary>
    /// Corresponds to kMediaEventTriggered
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class PlayerEvent : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Timestamp
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("timestamp"), IsRequired = (true))]
        public long Timestamp
        {
            get;
            set;
        }

        /// <summary>
        /// Value
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("value"), IsRequired = (true))]
        public string Value
        {
            get;
            set;
        }
    }
}