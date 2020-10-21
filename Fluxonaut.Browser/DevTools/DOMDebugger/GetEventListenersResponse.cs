// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOMDebugger
{
    /// <summary>
    /// GetEventListenersResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetEventListenersResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.DOMDebugger.EventListener> listeners
        {
            get;
            set;
        }

        /// <summary>
        /// listeners
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.DOMDebugger.EventListener> Listeners
        {
            get
            {
                return listeners;
            }
        }
    }
}