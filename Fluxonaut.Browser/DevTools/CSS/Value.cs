// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CSS
{
    /// <summary>
    /// Data for a simple selector (these are delimited by commas in a selector list).
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class Value : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Value text.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("text"), IsRequired = (true))]
        public string Text
        {
            get;
            set;
        }

        /// <summary>
        /// Value range in the underlying resource (if available).
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("range"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.CSS.SourceRange Range
        {
            get;
            set;
        }
    }
}