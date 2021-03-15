// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

//NOTE:Classes in the Fluxonaut.Browser.Core namespace have been hidden from intellisnse so users don't use them directly

namespace Fluxonaut.Browser
{
    /// <inheritdoc/>
    public class BrowserSettings : Fluxonaut.Browser.Core.BrowserSettings
    {
        /// <inheritdoc/>
        public BrowserSettings(bool autoDispose = false) : base(autoDispose)
        {

        }

        /// <summary>
        /// Create a new instance of <see cref="IBrowserSettings"/>
        /// </summary>
        /// <param name="autoDispose">set to false if you plan to reuse the instance, otherwise true</param>
        /// <returns>BrowserSettings</returns>
        public static IBrowserSettings Create(bool autoDispose = false)
        {
            return new Fluxonaut.Browser.Core.BrowserSettings(autoDispose);
        }
    }
}
