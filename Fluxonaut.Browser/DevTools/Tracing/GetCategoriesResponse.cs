// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Tracing
{
    /// <summary>
    /// GetCategoriesResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetCategoriesResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string[] categories
        {
            get;
            set;
        }

        /// <summary>
        /// categories
        /// </summary>
        public string[] Categories
        {
            get
            {
                return categories;
            }
        }
    }
}