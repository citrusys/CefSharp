// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Animation
{
    /// <summary>
    /// Keyframes Rule
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class KeyframesRule : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// CSS keyframed animation's name.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("name"), IsRequired = (false))]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// List of animation keyframes.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("keyframes"), IsRequired = (true))]
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Animation.KeyframeStyle> Keyframes
        {
            get;
            set;
        }
    }
}