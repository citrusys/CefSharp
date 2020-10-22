// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CSS
{
    /// <summary>
    /// AddRuleResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class AddRuleResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.CSS.CSSRule rule
        {
            get;
            set;
        }

        /// <summary>
        /// rule
        /// </summary>
        public Fluxonaut.Browser.DevTools.CSS.CSSRule Rule
        {
            get
            {
                return rule;
            }
        }
    }
}