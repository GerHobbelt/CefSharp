// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System.Collections.Generic;

namespace CefSharp.DevTools
{
    public abstract class DevToolsDomainBase
    {
        protected IDictionary<string, object> GetParamDictionary()
        {
            return null;
        }
    }
}
