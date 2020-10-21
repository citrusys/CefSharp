// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOM
{
    /// <summary>
    /// ResolveNodeResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class ResolveNodeResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Runtime.RemoteObject @object
        {
            get;
            set;
        }

        /// <summary>
        /// object
        /// </summary>
        public Fluxonaut.Browser.DevTools.Runtime.RemoteObject Object
        {
            get
            {
                return @object;
            }
        }
    }
}