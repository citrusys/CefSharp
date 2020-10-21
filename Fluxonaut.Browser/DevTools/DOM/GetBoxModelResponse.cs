// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.DOM
{
    /// <summary>
    /// GetBoxModelResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetBoxModelResponse : Fluxonaut.Browser.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal Fluxonaut.Browser.DevTools.DOM.BoxModel model
        {
            get;
            set;
        }

        /// <summary>
        /// model
        /// </summary>
        public Fluxonaut.Browser.DevTools.DOM.BoxModel Model
        {
            get
            {
                return model;
            }
        }
    }
}