// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Page
{
    /// <summary>
    /// GetNavigationHistoryResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetNavigationHistoryResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal int currentIndex
        {
            get;
            set;
        }

        /// <summary>
        /// currentIndex
        /// </summary>
        public int CurrentIndex
        {
            get
            {
                return currentIndex;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Page.NavigationEntry> entries
        {
            get;
            set;
        }

        /// <summary>
        /// entries
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Page.NavigationEntry> Entries
        {
            get
            {
                return entries;
            }
        }
    }
}