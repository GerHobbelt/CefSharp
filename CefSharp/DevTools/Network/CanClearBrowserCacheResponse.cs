// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace CefSharp.DevTools.Network
{
    /// <summary>
    /// CanClearBrowserCacheResponse
    /// </summary>
    public class CanClearBrowserCacheResponse
    {
        /// <summary>
        /// True if browser cache can be cleared.
        /// </summary>
        public bool result
        {
            get;
            set;
        }
    }
}