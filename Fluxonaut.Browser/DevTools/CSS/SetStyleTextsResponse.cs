// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CSS
{
    /// <summary>
    /// SetStyleTextsResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class SetStyleTextsResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.CSSStyle> styles
        {
            get;
            set;
        }

        /// <summary>
        /// styles
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.CSSStyle> Styles
        {
            get
            {
                return styles;
            }
        }
    }
}