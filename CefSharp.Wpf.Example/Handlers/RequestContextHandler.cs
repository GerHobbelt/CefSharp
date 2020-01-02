// Copyright © 2016 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System.Collections.Generic;

namespace CefSharp.Wpf.Example.Handlers
{
    public class RequestContextHandler : IRequestContextHandler
    {
        //private readonly ICookieManager customCookieManager;

        IResourceRequestHandler IRequestContextHandler.GetResourceRequestHandler(IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
        {
            return null;
        }

        bool IRequestContextHandler.OnBeforePluginLoad(string mimeType, string url, bool isMainFrame, string topOriginUrl, WebPluginInfo pluginInfo, ref PluginPolicy pluginPolicy)
        {
            //pluginPolicy = PluginPolicy.Disable;
            //return true;

            return false;
        }

        void IRequestContextHandler.OnRequestContextInitialized(IRequestContext requestContext)
        {
            //You can set preferences here on your newly initialized request context.
            //Note, there is called on the CEF UI Thread, so you can directly call SetPreference

            //Use this to check that settings preferences are working in your code
            //string errorMessage;
            //var success = requestContext.SetPreference("webkit.webprefs.minimum_font_size", 24, out errorMessage);

            //You can set the proxy with code similar to the code below
            //var v = new Dictionary<string, object>
            //{
            //    ["mode"] = "fixed_servers",
            //    ["server"] = "scheme://host:port"
            //};
            //
            // Example:
            //		[0]	{[mode, fixed_servers]}
            //      [1] {[server, http=127.0.0.1:8118;https=127.0.0.1:8118]}
            //
            //string errorMessage;
            //bool success = requestContext.SetPreference("proxy", v, out errorMessage);

            var p = requestContext.GetPreference("proxy");
            var v = p as Dictionary<string, object>;
        }
    }
}
