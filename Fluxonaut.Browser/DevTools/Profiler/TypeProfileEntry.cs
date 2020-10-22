// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Profiler
{
    /// <summary>
    /// Source offset and types for a parameter or return value.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class TypeProfileEntry : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Source offset of the parameter or end of function for return values.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("offset"), IsRequired = (true))]
        public int Offset
        {
            get;
            set;
        }

        /// <summary>
        /// The types for this parameter or return value.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("types"), IsRequired = (true))]
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Profiler.TypeObject> Types
        {
            get;
            set;
        }
    }
}