// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Memory
{
    /// <summary>
    /// Memory pressure level.
    /// </summary>
    public enum PressureLevel
    {
        /// <summary>
        /// moderate
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("moderate"))]
        Moderate,
        /// <summary>
        /// critical
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("critical"))]
        Critical
    }
}