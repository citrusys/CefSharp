// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Page
{
    /// <summary>
    /// The installability error
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class InstallabilityError : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// The error id (e.g. 'manifest-missing-suitable-icon').
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("errorId"), IsRequired = (true))]
        public string ErrorId
        {
            get;
            set;
        }

        /// <summary>
        /// The list of error arguments (e.g. {name:'minimum-icon-size-in-pixels', value:'64'}).
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("errorArguments"), IsRequired = (true))]
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Page.InstallabilityErrorArgument> ErrorArguments
        {
            get;
            set;
        }
    }
}