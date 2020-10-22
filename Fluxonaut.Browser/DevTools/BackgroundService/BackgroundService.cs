// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace Fluxonaut.Browser.DevTools.BackgroundService
{
    using System.Linq;

    /// <summary>
    /// Defines events for background web platform features.
    /// </summary>
    public partial class BackgroundService : DevToolsDomainBase
    {
        private Fluxonaut.Browser.DevTools.IDevToolsClient _client;
        public BackgroundService(Fluxonaut.Browser.DevTools.IDevToolsClient client)
        {
            _client = (client);
        }

        partial void ValidateStartObserving(Fluxonaut.Browser.DevTools.BackgroundService.ServiceName service);
        /// <summary>
        /// Enables event updates for the service.
        /// </summary>
        /// <param name = "service">service</param>
        /// <returns>returns System.Threading.Tasks.Task&lt;DevToolsMethodResponse&gt;</returns>
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> StartObservingAsync(Fluxonaut.Browser.DevTools.BackgroundService.ServiceName service)
        {
            ValidateStartObserving(service);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("service", this.EnumToString(service));
            var methodResult = await _client.ExecuteDevToolsMethodAsync("BackgroundService.startObserving", dict);
            return methodResult;
        }

        partial void ValidateStopObserving(Fluxonaut.Browser.DevTools.BackgroundService.ServiceName service);
        /// <summary>
        /// Disables event updates for the service.
        /// </summary>
        /// <param name = "service">service</param>
        /// <returns>returns System.Threading.Tasks.Task&lt;DevToolsMethodResponse&gt;</returns>
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> StopObservingAsync(Fluxonaut.Browser.DevTools.BackgroundService.ServiceName service)
        {
            ValidateStopObserving(service);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("service", this.EnumToString(service));
            var methodResult = await _client.ExecuteDevToolsMethodAsync("BackgroundService.stopObserving", dict);
            return methodResult;
        }

        partial void ValidateSetRecording(bool shouldRecord, Fluxonaut.Browser.DevTools.BackgroundService.ServiceName service);
        /// <summary>
        /// Set the recording state for the service.
        /// </summary>
        /// <param name = "shouldRecord">shouldRecord</param>
        /// <param name = "service">service</param>
        /// <returns>returns System.Threading.Tasks.Task&lt;DevToolsMethodResponse&gt;</returns>
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> SetRecordingAsync(bool shouldRecord, Fluxonaut.Browser.DevTools.BackgroundService.ServiceName service)
        {
            ValidateSetRecording(shouldRecord, service);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("shouldRecord", shouldRecord);
            dict.Add("service", this.EnumToString(service));
            var methodResult = await _client.ExecuteDevToolsMethodAsync("BackgroundService.setRecording", dict);
            return methodResult;
        }

        partial void ValidateClearEvents(Fluxonaut.Browser.DevTools.BackgroundService.ServiceName service);
        /// <summary>
        /// Clears all stored data for the service.
        /// </summary>
        /// <param name = "service">service</param>
        /// <returns>returns System.Threading.Tasks.Task&lt;DevToolsMethodResponse&gt;</returns>
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> ClearEventsAsync(Fluxonaut.Browser.DevTools.BackgroundService.ServiceName service)
        {
            ValidateClearEvents(service);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("service", this.EnumToString(service));
            var methodResult = await _client.ExecuteDevToolsMethodAsync("BackgroundService.clearEvents", dict);
            return methodResult;
        }
    }
}