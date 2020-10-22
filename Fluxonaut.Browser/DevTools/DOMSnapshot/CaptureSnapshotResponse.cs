// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOMSnapshot
{
    /// <summary>
    /// CaptureSnapshotResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class CaptureSnapshotResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.DOMSnapshot.DocumentSnapshot> documents
        {
            get;
            set;
        }

        /// <summary>
        /// documents
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.DOMSnapshot.DocumentSnapshot> Documents
        {
            get
            {
                return documents;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal string[] strings
        {
            get;
            set;
        }

        /// <summary>
        /// strings
        /// </summary>
        public string[] Strings
        {
            get
            {
                return strings;
            }
        }
    }
}