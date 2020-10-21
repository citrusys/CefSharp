// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Accessibility
{
    /// <summary>
    /// AXProperty
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class AXProperty : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// The name of this property.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Accessibility.AXPropertyName Name
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Accessibility.AXPropertyName)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Accessibility.AXPropertyName), name));
            }

            set
            {
                name = (EnumToString(value));
            }
        }

        /// <summary>
        /// The name of this property.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("name"), IsRequired = (true))]
        internal string name
        {
            get;
            set;
        }

        /// <summary>
        /// The value of this property.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("value"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.Accessibility.AXValue Value
        {
            get;
            set;
        }
    }
}