// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Debugger
{
    /// <summary>
    /// Debug symbols available for a wasm script.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class DebugSymbols : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Type of the debug symbols.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("type"), IsRequired = (true))]
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// URL of the external symbol source.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("externalURL"), IsRequired = (false))]
        public string ExternalURL
        {
            get;
            set;
        }
    }
}