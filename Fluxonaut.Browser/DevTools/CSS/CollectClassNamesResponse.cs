// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CSS
{
    /// <summary>
    /// CollectClassNamesResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class CollectClassNamesResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string[] classNames
        {
            get;
            set;
        }

        /// <summary>
        /// classNames
        /// </summary>
        public string[] ClassNames
        {
            get
            {
                return classNames;
            }
        }
    }
}