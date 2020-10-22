// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Runtime
{
    /// <summary>
    /// GetPropertiesResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetPropertiesResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Runtime.PropertyDescriptor> result
        {
            get;
            set;
        }

        /// <summary>
        /// result
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Runtime.PropertyDescriptor> Result
        {
            get
            {
                return result;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Runtime.InternalPropertyDescriptor> internalProperties
        {
            get;
            set;
        }

        /// <summary>
        /// internalProperties
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Runtime.InternalPropertyDescriptor> InternalProperties
        {
            get
            {
                return internalProperties;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Runtime.PrivatePropertyDescriptor> privateProperties
        {
            get;
            set;
        }

        /// <summary>
        /// privateProperties
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Runtime.PrivatePropertyDescriptor> PrivateProperties
        {
            get
            {
                return privateProperties;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Runtime.ExceptionDetails exceptionDetails
        {
            get;
            set;
        }

        /// <summary>
        /// exceptionDetails
        /// </summary>
        public Fluxonaut.Browser.DevTools.Runtime.ExceptionDetails ExceptionDetails
        {
            get
            {
                return exceptionDetails;
            }
        }
    }
}