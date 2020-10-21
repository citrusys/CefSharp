// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CSS
{
    /// <summary>
    /// Selector list data.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class SelectorList : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Selectors in the list.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("selectors"), IsRequired = (true))]
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.Value> Selectors
        {
            get;
            set;
        }

        /// <summary>
        /// Rule selector text.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("text"), IsRequired = (true))]
        public string Text
        {
            get;
            set;
        }
    }
}