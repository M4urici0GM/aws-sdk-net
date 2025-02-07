/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CollapsedResultDetail Object
    /// </summary>  
    public class CollapsedResultDetailUnmarshaller : IUnmarshaller<CollapsedResultDetail, XmlUnmarshallerContext>, IUnmarshaller<CollapsedResultDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CollapsedResultDetail IUnmarshaller<CollapsedResultDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CollapsedResultDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CollapsedResultDetail unmarshalledObject = new CollapsedResultDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DocumentAttribute", targetDepth))
                {
                    var unmarshaller = DocumentAttributeUnmarshaller.Instance;
                    unmarshalledObject.DocumentAttribute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpandedResults", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ExpandedResultItem, ExpandedResultItemUnmarshaller>(ExpandedResultItemUnmarshaller.Instance);
                    unmarshalledObject.ExpandedResults = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CollapsedResultDetailUnmarshaller _instance = new CollapsedResultDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CollapsedResultDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}