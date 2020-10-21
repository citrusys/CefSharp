// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CSS
{
    /// <summary>
    /// GetInlineStylesForNodeResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetInlineStylesForNodeResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.CSS.CSSStyle inlineStyle
        {
            get;
            set;
        }

        /// <summary>
        /// inlineStyle
        /// </summary>
        public Fluxonaut.Browser.DevTools.CSS.CSSStyle InlineStyle
        {
            get
            {
                return inlineStyle;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.CSS.CSSStyle attributesStyle
        {
            get;
            set;
        }

        /// <summary>
        /// attributesStyle
        /// </summary>
        public Fluxonaut.Browser.DevTools.CSS.CSSStyle AttributesStyle
        {
            get
            {
                return attributesStyle;
            }
        }
    }
}