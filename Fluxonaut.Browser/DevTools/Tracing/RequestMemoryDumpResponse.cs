// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Tracing
{
    /// <summary>
    /// RequestMemoryDumpResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class RequestMemoryDumpResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string dumpGuid
        {
            get;
            set;
        }

        /// <summary>
        /// dumpGuid
        /// </summary>
        public string DumpGuid
        {
            get
            {
                return dumpGuid;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal bool success
        {
            get;
            set;
        }

        /// <summary>
        /// success
        /// </summary>
        public bool Success
        {
            get
            {
                return success;
            }
        }
    }
}