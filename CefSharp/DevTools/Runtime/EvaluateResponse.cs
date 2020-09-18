// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace CefSharp.DevTools.Runtime
{
    /// <summary>
    /// EvaluateResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class EvaluateResponse : CefSharp.DevTools.DevToolsDomainResponseBase
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal CefSharp.DevTools.Runtime.RemoteObject result
        {
            get;
            set;
        }

        /// <summary>
        /// Evaluation result.
        /// </summary>
        public CefSharp.DevTools.Runtime.RemoteObject Result
        {
            get
            {
                return result;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute]
        internal CefSharp.DevTools.Runtime.ExceptionDetails exceptionDetails
        {
            get;
            set;
        }

        /// <summary>
        /// Exception details.
        /// </summary>
        public CefSharp.DevTools.Runtime.ExceptionDetails ExceptionDetails
        {
            get
            {
                return exceptionDetails;
            }
        }
    }
}