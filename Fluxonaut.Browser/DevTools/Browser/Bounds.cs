// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Browser
{
    /// <summary>
    /// Browser window bounds information
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class Bounds : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// The offset from the left edge of the screen to the window in pixels.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("left"), IsRequired = (false))]
        public int? Left
        {
            get;
            set;
        }

        /// <summary>
        /// The offset from the top edge of the screen to the window in pixels.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("top"), IsRequired = (false))]
        public int? Top
        {
            get;
            set;
        }

        /// <summary>
        /// The window width in pixels.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("width"), IsRequired = (false))]
        public int? Width
        {
            get;
            set;
        }

        /// <summary>
        /// The window height in pixels.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("height"), IsRequired = (false))]
        public int? Height
        {
            get;
            set;
        }

        /// <summary>
        /// The window state. Default to normal.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Browser.WindowState? WindowState
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Browser.WindowState? )(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Browser.WindowState? ), windowState));
            }

            set
            {
                windowState = (EnumToString(value));
            }
        }

        /// <summary>
        /// The window state. Default to normal.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("windowState"), IsRequired = (false))]
        internal string windowState
        {
            get;
            set;
        }
    }
}