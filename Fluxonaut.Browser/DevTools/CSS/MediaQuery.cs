// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CSS
{
    /// <summary>
    /// Media query descriptor.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class MediaQuery : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Array of media query expressions.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("expressions"), IsRequired = (true))]
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.MediaQueryExpression> Expressions
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the media query condition is satisfied.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("active"), IsRequired = (true))]
        public bool Active
        {
            get;
            set;
        }
    }
}