// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

//NOTE:Classes in the Fluxonaut.Browser.Core namespace have been hidden from intellisnse so users don't use them directly

namespace Fluxonaut.Browser
{
    /// <inheritdoc/>
    public class PostDataElement : Fluxonaut.Browser.Core.PostDataElement
    {
        /// <summary>
        /// Create a new instance of <see cref="IPostDataElement"/>
        /// </summary>
        /// <returns>PostDataElement</returns>
        public static IPostDataElement Create()
        {
            return new Fluxonaut.Browser.Core.PostDataElement();
        }
    }
}
