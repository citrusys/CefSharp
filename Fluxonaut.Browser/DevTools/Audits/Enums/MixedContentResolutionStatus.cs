// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Audits
{
    /// <summary>
    /// MixedContentResolutionStatus
    /// </summary>
    public enum MixedContentResolutionStatus
    {
        /// <summary>
        /// MixedContentBlocked
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("MixedContentBlocked"))]
        MixedContentBlocked,
        /// <summary>
        /// MixedContentAutomaticallyUpgraded
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("MixedContentAutomaticallyUpgraded"))]
        MixedContentAutomaticallyUpgraded,
        /// <summary>
        /// MixedContentWarning
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("MixedContentWarning"))]
        MixedContentWarning
    }
}