// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Runtime
{
    /// <summary>
    /// CompileScriptResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class CompileScriptResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal string scriptId
        {
            get;
            set;
        }

        /// <summary>
        /// scriptId
        /// </summary>
        public string ScriptId
        {
            get
            {
                return scriptId;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Runtime.ExceptionDetails exceptionDetails
        {
            get;
            set;
        }

        /// <summary>
        /// exceptionDetails
        /// </summary>
        public Fluxonaut.Browser.DevTools.Runtime.ExceptionDetails ExceptionDetails
        {
            get
            {
                return exceptionDetails;
            }
        }
    }
}