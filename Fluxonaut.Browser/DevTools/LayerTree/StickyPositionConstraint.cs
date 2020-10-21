// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.LayerTree
{
    /// <summary>
    /// Sticky position constraints.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class StickyPositionConstraint : Fluxonaut.Browser.DevTools.DevToolsDomainEntityBase
    {
        /// <summary>
        /// Layout rectangle of the sticky element before being shifted
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("stickyBoxRect"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.DOM.Rect StickyBoxRect
        {
            get;
            set;
        }

        /// <summary>
        /// Layout rectangle of the containing block of the sticky element
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("containingBlockRect"), IsRequired = (true))]
        public Fluxonaut.Browser.DevTools.DOM.Rect ContainingBlockRect
        {
            get;
            set;
        }

        /// <summary>
        /// The nearest sticky layer that shifts the sticky box
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("nearestLayerShiftingStickyBox"), IsRequired = (false))]
        public string NearestLayerShiftingStickyBox
        {
            get;
            set;
        }

        /// <summary>
        /// The nearest sticky layer that shifts the containing block
        /// </summary>
        [System.Runtime.Serialization.DataMemberAttribute(Name = ("nearestLayerShiftingContainingBlock"), IsRequired = (false))]
        public string NearestLayerShiftingContainingBlock
        {
            get;
            set;
        }
    }
}