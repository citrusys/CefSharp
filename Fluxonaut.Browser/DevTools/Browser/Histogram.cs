// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Browser
{
    /// <summary>
    /// Chrome histogram.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class Histogram : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Name.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("name"), IsRequired = (true))]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Sum of sample values.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("sum"), IsRequired = (true))]
        public int Sum
        {
            get;
            set;
        }

        /// <summary>
        /// Total number of samples.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("count"), IsRequired = (true))]
        public int Count
        {
            get;
            set;
        }

        /// <summary>
        /// Buckets.
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("buckets"), IsRequired = (true))]
        public System.Collections.Generic.IList<Fluxonaut.Browser.DevTools.Browser.Bucket> Buckets
        {
            get;
            set;
        }
    }
}