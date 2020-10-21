// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.IndexedDB
{
    /// <summary>
    /// Object store index.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class ObjectStoreIndex : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Index name.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("name"), IsRequired = (true))]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Index key path.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("keyPath"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.IndexedDB.KeyPath KeyPath
        {
            get;
            set;
        }

        /// <summary>
        /// If true, index is unique.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("unique"), IsRequired = (true))]
        public bool Unique
        {
            get;
            set;
        }

        /// <summary>
        /// If true, index allows multiple entries for a key.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("multiEntry"), IsRequired = (true))]
        public bool MultiEntry
        {
            get;
            set;
        }
    }
}