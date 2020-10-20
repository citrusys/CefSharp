// Copyright © 2015 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

namespace Fluxonaut.Browser.Internals
{
    /// <summary>
    /// Interface to convert a JavascriptCallback dto to a callable implementation.
    /// </summary>
    public interface IJavascriptCallbackFactory
    {
        IJavascriptCallback Create(JavascriptCallback callback);
    }
}
