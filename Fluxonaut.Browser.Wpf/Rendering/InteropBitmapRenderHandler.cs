// Copyright © 2018 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.IO.MemoryMappedFiles;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Threading;
using Rect = Fluxonaut.Browser.Structs.Rect;

namespace Fluxonaut.Browser.Wpf.Rendering
{
    /// <summary>
    /// InteropBitmapRenderHandler - creates/updates an InteropBitmap
    /// Uses a MemoryMappedFile for double buffering when the size matches
    /// or creates a new InteropBitmap when required
    /// </summary>
    /// <seealso cref="Fluxonaut.Browser.Wpf.IRenderHandler" />
    public class InteropBitmapRenderHandler : AbstractRenderHandler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteropBitmapRenderHandler"/> class.
        /// </summary>
        /// <param name="dispatcherPriority">priority at which the bitmap will be updated on the UI thread</param>
        public InteropBitmapRenderHandler(DispatcherPriority dispatcherPriority = DispatcherPriority.Render)
        {
            this.dispatcherPriority = dispatcherPriority;
        }

        protected override void CreateOrUpdateBitmap(bool isPopup, Rect dirtyRect, IntPtr buffer, int width, int height, Image image, ref Size currentSize, ref MemoryMappedFile mappedFile, ref MemoryMappedViewAccessor viewAccessor)
        {
            var createNewBitmap = false;

            lock (lockObject)
            {
                int pixels = width * height;
                int numberOfBytes = pixels * BytesPerPixel;

                createNewBitmap = mappedFile == null || currentSize.Height != height || currentSize.Width != width;

                if (createNewBitmap)
                {
                    //If the MemoryMappedFile is smaller than we need then create a larger one
                    //If it's larger then we need then rather than going through the costly expense of
                    //allocating a new one we'll just use the old one and only access the number of bytes we require.
                    if (viewAccessor == null || viewAccessor.Capacity < numberOfBytes)
                    {
                        ReleaseMemoryMappedView(ref mappedFile, ref viewAccessor);

                        mappedFile = MemoryMappedFile.CreateNew(null, numberOfBytes, MemoryMappedFileAccess.ReadWrite);

                        viewAccessor = mappedFile.CreateViewAccessor();
                    }

                    currentSize.Height = height;
                    currentSize.Width = width;
                }

                NativeMethodWrapper.MemoryCopy(viewAccessor.SafeMemoryMappedViewHandle.DangerousGetHandle(), buffer, numberOfBytes);

                //Take a reference to the backBufferHandle, once we're on the UI thread we need to check if it's still valid
                var backBufferHandle = mappedFile.SafeMemoryMappedFileHandle;

                //Invoke on the WPF UI Thread
                image.Dispatcher.BeginInvoke((Action)(() =>
                {
                    lock (lockObject)
                    {
                        if (backBufferHandle.IsClosed || backBufferHandle.IsInvalid)
                        {
                            return;
                        }

                        if (createNewBitmap)
                        {
                            if (image.Source != null)
                            {
                                image.Source = null;
                                //TODO: Is this still required in newer versions of .Net?
                                GC.Collect(1);
                            }

                            var stride = width * BytesPerPixel;
                            var bitmap = (InteropBitmap)Imaging.CreateBitmapSourceFromMemorySection(backBufferHandle.DangerousGetHandle(), width, height, PixelFormat, stride, 0);
                            image.Source = bitmap;
                        }
                        else if (image.Source != null)
                        {
                            var sourceRect = new Int32Rect(dirtyRect.X, dirtyRect.Y, dirtyRect.Width, dirtyRect.Height);
                            var bitmap = (InteropBitmap)image.Source;
                            bitmap.Invalidate(sourceRect);
                        }
                    }
                }), dispatcherPriority);
            }
        }
    }
}
