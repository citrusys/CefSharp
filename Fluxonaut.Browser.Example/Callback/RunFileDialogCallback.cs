// Copyright © 2018 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System.Collections.Generic;
using Fluxonaut.Browser.Callback;

namespace Fluxonaut.Browser.Example.Callback
{
    public class RunFileDialogCallback : IRunFileDialogCallback
    {
        void IRunFileDialogCallback.OnFileDialogDismissed(int selectedAcceptFilter, IList<string> filePaths)
        {
            
        }
    }
}
