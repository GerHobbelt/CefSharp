// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace CefSharp.DevTools.DOM
{
    /// <summary>
    /// GetFlattenedDocumentResponse
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute]
    public class GetFlattenedDocumentResponse
    {
        [System.Runtime.Serialization.DataMemberAttribute]
        internal System.Collections.Generic.IList<Node> nodes
        {
            get;
            set;
        }

        /// <summary>
        /// Resulting node.
        /// </summary>
        public System.Collections.Generic.IList<Node> Nodes
        {
            get
            {
                return nodes;
            }
        }
    }
}