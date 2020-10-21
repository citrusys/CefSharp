// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.ServiceWorker
{
    /// <summary>
    /// ServiceWorkerVersionRunningStatus
    /// </summary>
    public enum ServiceWorkerVersionRunningStatus
    {
        /// <summary>
        /// stopped
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("stopped"))]
        Stopped,
        /// <summary>
        /// starting
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("starting"))]
        Starting,
        /// <summary>
        /// running
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("running"))]
        Running,
        /// <summary>
        /// stopping
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("stopping"))]
        Stopping
    }
}