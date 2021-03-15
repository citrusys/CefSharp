// Copyright © 2016 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

namespace Fluxonaut.Browser
{
    /// <summary>
    /// Class representing popup window features. 
    /// </summary>
    public interface IPopupFeatures
    {
        /// <summary>
        /// Gets the x coordinate.
        /// </summary>
        /// <value>
        /// The x coordinate.
        /// </value>
        int? X { get; }
        /// <summary>
        /// Gets the set.
        /// </summary>
        /// <value>
        /// The x coordinate set.
        /// </value>
        int? Y { get; }
        /// <summary>
        /// Gets the set.
        /// </summary>
        /// <value>
        /// The y coordinate set.
        /// </value>
        int? Width { get; }
        /// <summary>
        /// Gets the set the width belongs to.
        /// </summary>
        /// <value>
        /// The width set.
        /// </value>
        int? Height { get; }
        /// <summary>
        /// Gets the set the height belongs to.
        /// </summary>
        /// <value>
        /// The height set.
        /// </value>
        bool MenuBarVisible { get; }
        /// <summary>
        /// Gets a value indicating whether the status bar is visible.
        /// </summary>
        /// <value>
        /// True if status bar visible, false if not.
        /// </value>
        bool StatusBarVisible { get; }
        /// <summary>
        /// Gets a value indicating whether the tool bar is visible.
        /// </summary>
        /// <value>
        /// True if tool bar visible, false if not.
        /// </value>
        bool ToolBarVisible { get; }
        /// <summary>
        /// Gets a value indicating whether the scrollbars is visible.
        /// </summary>
        /// <value>
        /// True if scrollbars visible, false if not.
        /// </value>
        bool ScrollbarsVisible { get; }
    }
}
