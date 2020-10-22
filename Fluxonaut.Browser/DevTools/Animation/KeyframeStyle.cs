// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Animation
{
    /// <summary>
    /// Keyframe Style
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class KeyframeStyle : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Keyframe's time offset.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("offset"), IsRequired = (true))]
        public string Offset
        {
            get;
            set;
        }

        /// <summary>
        /// `AnimationEffect`'s timing function.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("easing"), IsRequired = (true))]
        public string Easing
        {
            get;
            set;
        }
    }
}