// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Runtime
{
    /// <summary>
    /// QueryObjectsResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class QueryObjectsResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Runtime.RemoteObject objects
        {
            get;
            set;
        }

        /// <summary>
        /// objects
        /// </summary>
        public Fluxonaut.Browser.DevTools.Runtime.RemoteObject Objects
        {
            get
            {
                return objects;
            }
        }
    }
}