// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Storage
{
    /// <summary>
    /// Usage for a storage type.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class UsageForType : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Name of storage type.
        /// </summary>
        public Fluxonaut.Browser.DevTools.Storage.StorageType StorageType
        {
            get
            {
                return (Fluxonaut.Browser.DevTools.Storage.StorageType)(StringToEnum(typeof(Fluxonaut.Browser.DevTools.Storage.StorageType), storageType));
            }

            set
            {
                storageType = (EnumToString(value));
            }
        }

        /// <summary>
        /// Name of storage type.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("storageType"), IsRequired = (true))]
        internal string storageType
        {
            get;
            set;
        }

        /// <summary>
        /// Storage usage (bytes).
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("usage"), IsRequired = (true))]
        public long Usage
        {
            get;
            set;
        }
    }
}