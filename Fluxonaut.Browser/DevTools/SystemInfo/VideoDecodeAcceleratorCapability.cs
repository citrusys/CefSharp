// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.SystemInfo
{
    /// <summary>
    /// Describes a supported video decoding profile with its associated minimum and
    /// maximum resolutions.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class VideoDecodeAcceleratorCapability : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Video codec profile that is supported, e.g. VP9 Profile 2.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("profile"), IsRequired = (true))]
        public string Profile
        {
            get;
            set;
        }

        /// <summary>
        /// Maximum video dimensions in pixels supported for this |profile|.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("maxResolution"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.SystemInfo.Size MaxResolution
        {
            get;
            set;
        }

        /// <summary>
        /// Minimum video dimensions in pixels supported for this |profile|.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("minResolution"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.SystemInfo.Size MinResolution
        {
            get;
            set;
        }
    }
}