// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Animation
{
    /// <summary>
    /// ResolveAnimationResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class ResolveAnimationResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Runtime.RemoteObject remoteObject
        {
            get;
            set;
        }

        /// <summary>
        /// remoteObject
        /// </summary>
        public Fluxonaut.Browser.DevTools.Runtime.RemoteObject RemoteObject
        {
            get
            {
                return remoteObject;
            }
        }
    }
}