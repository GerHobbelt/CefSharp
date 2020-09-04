// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace CefSharp.DevTools.Emulation
{
    /// <summary>
    /// CanEmulateResponse
    /// </summary>
    public class CanEmulateResponse
    {
        /// <summary>
        /// True if emulation is supported.
        /// </summary>
        public bool result
        {
            get;
            set;
        }
    }
}