// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CSS
{
    /// <summary>
    /// SetRuleSelectorResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class SetRuleSelectorResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.CSS.SelectorList selectorList
        {
            get;
            set;
        }

        /// <summary>
        /// selectorList
        /// </summary>
        public Fluxonaut.Browser.DevTools.CSS.SelectorList SelectorList
        {
            get
            {
                return selectorList;
            }
        }
    }
}