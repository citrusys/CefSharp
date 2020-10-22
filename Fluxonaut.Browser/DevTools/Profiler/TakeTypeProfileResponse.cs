// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Profiler
{
    /// <summary>
    /// TakeTypeProfileResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class TakeTypeProfileResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Profiler.ScriptTypeProfile> result
        {
            get;
            set;
        }

        /// <summary>
        /// result
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Profiler.ScriptTypeProfile> Result
        {
            get
            {
                return result;
            }
        }
    }
}