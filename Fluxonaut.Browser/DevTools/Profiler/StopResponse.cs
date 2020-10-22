// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Profiler
{
    /// <summary>
    /// StopResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class StopResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Profiler.Profile profile
        {
            get;
            set;
        }

        /// <summary>
        /// profile
        /// </summary>
        public Fluxonaut.Browser.DevTools.Profiler.Profile Profile
        {
            get
            {
                return profile;
            }
        }
    }
}