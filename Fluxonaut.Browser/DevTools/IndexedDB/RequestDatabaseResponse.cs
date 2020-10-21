// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.IndexedDB
{
    /// <summary>
    /// RequestDatabaseResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class RequestDatabaseResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.IndexedDB.DatabaseWithObjectStores databaseWithObjectStores
        {
            get;
            set;
        }

        /// <summary>
        /// databaseWithObjectStores
        /// </summary>
        public Fluxonaut.Browser.DevTools.IndexedDB.DatabaseWithObjectStores DatabaseWithObjectStores
        {
            get
            {
                return databaseWithObjectStores;
            }
        }
    }
}