// Copyright © 2016 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;

namespace Fluxonaut.Browser.Internals
{
    public class MethodParameter
    {
        public bool IsParamArray { get; set; }
        public Type Type { get; set; }
    }
}
