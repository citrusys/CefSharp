// Copyright © 2020 The Fluxonaut Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System.Threading;


namespace Fluxonaut.Browser.Internals
{
    public interface IBrowserRefCounter
    {
        void Increment();
        bool Decrement();
        int Count { get; }
        void WaitForBrowsersToClose(int timeoutInMiliseconds = 500);
        void WaitForBrowsersToClose(int timeoutInMiliseconds, CancellationToken cancellationToken);
    }
}
