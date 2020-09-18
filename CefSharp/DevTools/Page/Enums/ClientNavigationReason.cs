// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace CefSharp.DevTools.Page
{
    /// <summary>
    /// ClientNavigationReason
    /// </summary>
    public enum ClientNavigationReason
    {
        FormSubmissionGet,
        FormSubmissionPost,
        HttpHeaderRefresh,
        ScriptInitiated,
        MetaTagRefresh,
        PageBlockInterstitial,
        Reload,
        AnchorClick
    }
}