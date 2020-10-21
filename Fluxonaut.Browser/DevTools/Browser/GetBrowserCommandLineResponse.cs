// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Browser
{
    /// <summary>
    /// GetBrowserCommandLineResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetBrowserCommandLineResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string[] arguments
        {
            get;
            set;
        }

        /// <summary>
        /// arguments
        /// </summary>
        public string[] Arguments
        {
            get
            {
                return arguments;
            }
        }
    }
}