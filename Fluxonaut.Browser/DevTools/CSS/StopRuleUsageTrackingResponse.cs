// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.CSS
{
    /// <summary>
    /// StopRuleUsageTrackingResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class StopRuleUsageTrackingResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.RuleUsage> ruleUsage
        {
            get;
            set;
        }

        /// <summary>
        /// ruleUsage
        /// </summary>
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.CSS.RuleUsage> RuleUsage
        {
            get
            {
                return ruleUsage;
            }
        }
    }
}