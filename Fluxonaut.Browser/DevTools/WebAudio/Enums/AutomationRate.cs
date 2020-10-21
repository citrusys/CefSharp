// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.WebAudio
{
    /// <summary>
    /// Enum of AudioParam::AutomationRate from the spec
    /// </summary>
    public enum AutomationRate
    {
        /// <summary>
        /// a-rate
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("a-rate"))]
        ARate,
        /// <summary>
        /// k-rate
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("k-rate"))]
        KRate
    }
}