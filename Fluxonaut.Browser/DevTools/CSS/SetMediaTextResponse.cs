// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CSS
{
    /// <summary>
    /// SetMediaTextResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class SetMediaTextResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.CSS.CSSMedia media
        {
            get;
            set;
        }

        /// <summary>
        /// media
        /// </summary>
        public Fluxonaut.Browser.DevTools.CSS.CSSMedia Media
        {
            get
            {
                return media;
            }
        }
    }
}