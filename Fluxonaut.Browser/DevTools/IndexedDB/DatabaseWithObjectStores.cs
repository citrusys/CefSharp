// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.IndexedDB
{
    /// <summary>
    /// Database with an array of object stores.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class DatabaseWithObjectStores : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Database name.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("name"), IsRequired = (true))]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Database version (type is not 'integer', as the standard
        /// requires the version number to be 'unsigned long long')
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("version"), IsRequired = (true))]
        public long Version
        {
            get;
            set;
        }

        /// <summary>
        /// Object stores in this database.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("objectStores"), IsRequired = (true))]
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.IndexedDB.ObjectStore> ObjectStores
        {
            get;
            set;
        }
    }
}