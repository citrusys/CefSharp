// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.SystemInfo
{
    /// <summary>
    /// Describes a supported image decoding profile with its associated minimum and
    /// maximum resolutions and subsampling.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class ImageDecodeAcceleratorCapability : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Image coded, e.g. Jpeg.
        /// </summary>
        public Fluxonaut.Browser.DevTools.SystemInfo.ImageType ImageType
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.SystemInfo.ImageType)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.SystemInfo.ImageType), imageType));
            }

            set
            {
                imageType = (EnumToString(value));
            }
        }

        /// <summary>
        /// Image coded, e.g. Jpeg.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("imageType"), IsRequired = (true))]
        internal string imageType
        {
            get;
            set;
        }

        /// <summary>
        /// Maximum supported dimensions of the image in pixels.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("maxDimensions"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.SystemInfo.Size MaxDimensions
        {
            get;
            set;
        }

        /// <summary>
        /// Minimum supported dimensions of the image in pixels.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("minDimensions"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.SystemInfo.Size MinDimensions
        {
            get;
            set;
        }

        /// <summary>
        /// Optional array of supported subsampling formats, e.g. 4:2:0, if known.
        /// </summary>
        public Fluxonaut.Browser.DevTools.SystemInfo.SubsamplingFormat[] Subsamplings
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.SystemInfo.SubsamplingFormat[])(StringToEnum(typeof(Fluxonaut.Browser.DevTools.SystemInfo.SubsamplingFormat[]), subsamplings));
            }

            set
            {
                subsamplings = (EnumToString(value));
            }
        }

        /// <summary>
        /// Optional array of supported subsampling formats, e.g. 4:2:0, if known.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("subsamplings"), IsRequired = (true))]
        internal string subsamplings
        {
            get;
            set;
        }
    }
}