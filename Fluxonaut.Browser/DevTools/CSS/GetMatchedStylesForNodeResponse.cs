// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CSS
{
    /// <summary>
    /// GetMatchedStylesForNodeResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetMatchedStylesForNodeResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
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

        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.RuleMatch> matchedCSSRules
        {
            get;
            set;
        }

        /// <summary>
        /// matchedCSSRules
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.RuleMatch> MatchedCSSRules
        {
            get
            {
                return matchedCSSRules;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.PseudoElementMatches> pseudoElements
        {
            get;
            set;
        }

        /// <summary>
        /// pseudoElements
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.PseudoElementMatches> PseudoElements
        {
            get
            {
                return pseudoElements;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.InheritedStyleEntry> inherited
        {
            get;
            set;
        }

        /// <summary>
        /// inherited
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.InheritedStyleEntry> Inherited
        {
            get
            {
                return inherited;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.CSSKeyframesRule> cssKeyframesRules
        {
            get;
            set;
        }

        /// <summary>
        /// cssKeyframesRules
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.CSSKeyframesRule> CssKeyframesRules
        {
            get
            {
                return cssKeyframesRules;
            }
        }
    }
}