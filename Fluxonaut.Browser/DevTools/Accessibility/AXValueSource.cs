// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Accessibility
{
    /// <summary>
    /// A single source for a computed AX property.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class AXValueSource : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// What type of source this is.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Accessibility.AXValueSourceType Type
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Accessibility.AXValueSourceType)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Accessibility.AXValueSourceType), type));
            }

            set
            {
                type = (EnumToString(value));
            }
        }

        /// <summary>
        /// What type of source this is.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("type"), IsRequired = (true))]
        internal string type
        {
            get;
            set;
        }

        /// <summary>
        /// The value of this property source.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("value"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.Accessibility.AXValue Value
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the relevant attribute, if any.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("attribute"), IsRequired = (false))]
        public string Attribute
        {
            get;
            set;
        }

        /// <summary>
        /// The value of the relevant attribute, if any.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("attributeValue"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.Accessibility.AXValue AttributeValue
        {
            get;
            set;
        }

        /// <summary>
        /// Whether this source is superseded by a higher priority source.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("superseded"), IsRequired = (false))]
        public bool? Superseded
        {
            get;
            set;
        }

        /// <summary>
        /// The native markup source for this value, e.g. a <label> element.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Accessibility.AXValueNativeSourceType? NativeSource
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Accessibility.AXValueNativeSourceType? )(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Accessibility.AXValueNativeSourceType? ), nativeSource));
            }

            set
            {
                nativeSource = (EnumToString(value));
            }
        }

        /// <summary>
        /// The native markup source for this value, e.g. a <label> element.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("nativeSource"), IsRequired = (false))]
        internal string nativeSource
        {
            get;
            set;
        }

        /// <summary>
        /// The value, such as a node or node list, of the native source.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("nativeSourceValue"), IsRequired = (false))]
        public Fluxonaut.Browser.DevTools.Accessibility.AXValue NativeSourceValue
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the value for this property is invalid.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("invalid"), IsRequired = (false))]
        public bool? Invalid
        {
            get;
            set;
        }

        /// <summary>
        /// Reason for the value being invalid, if it is.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("invalidReason"), IsRequired = (false))]
        public string InvalidReason
        {
            get;
            set;
        }
    }
}