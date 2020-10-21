// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Debugger
{
    /// <summary>
    /// RestartFrameResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class RestartFrameResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Debugger.CallFrame> callFrames
        {
            get;
            set;
        }

        /// <summary>
        /// callFrames
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Debugger.CallFrame> CallFrames
        {
            get
            {
                return callFrames;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Runtime.StackTrace asyncStackTrace
        {
            get;
            set;
        }

        /// <summary>
        /// asyncStackTrace
        /// </summary>
        public Fluxonaut.Browser.DevTools.Runtime.StackTrace AsyncStackTrace
        {
            get
            {
                return asyncStackTrace;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.Runtime.StackTraceId asyncStackTraceId
        {
            get;
            set;
        }

        /// <summary>
        /// asyncStackTraceId
        /// </summary>
        public Fluxonaut.Browser.DevTools.Runtime.StackTraceId AsyncStackTraceId
        {
            get
            {
                return asyncStackTraceId;
            }
        }
    }
}