// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.Debugger
{
    /// <summary>
    /// Enum of possible script languages.
    /// </summary>
    public enum ScriptLanguage
    {
        /// <summary>
        /// JavaScript
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("JavaScript"))]
        JavaScript,
        /// <summary>
        /// WebAssembly
        /// </summary>
        [System.Runtime.Serialization.EnumMemberAttribute(Value = ("WebAssembly"))]
        WebAssembly
    }
}