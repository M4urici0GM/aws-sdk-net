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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFeatureGroup operation.
    /// Delete the <code>FeatureGroup</code> and any data that was written to the <code>OnlineStore</code>
    /// of the <code>FeatureGroup</code>. Data cannot be accessed from the <code>OnlineStore</code>
    /// immediately after <code>DeleteFeatureGroup</code> is called. 
    /// 
    ///  
    /// <para>
    /// Data written into the <code>OfflineStore</code> will not be deleted. The Amazon Web
    /// Services Glue database and tables that are automatically created for your <code>OfflineStore</code>
    /// are not deleted. 
    /// </para>
    ///  
    /// <para>
    /// Note that it can take approximately 10-15 minutes to delete an <code>OnlineStore</code>
    /// <code>FeatureGroup</code> with the <code>InMemory</code> <code>StorageType</code>.
    /// </para>
    /// </summary>
    public partial class DeleteFeatureGroupRequest : AmazonSageMakerRequest
    {
        private string _featureGroupName;

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name of the <code>FeatureGroup</code> you want to delete. The name must be unique
        /// within an Amazon Web Services Region in an Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FeatureGroupName
        {
            get { return this._featureGroupName; }
            set { this._featureGroupName = value; }
        }

        // Check to see if FeatureGroupName property is set
        internal bool IsSetFeatureGroupName()
        {
            return this._featureGroupName != null;
        }

    }
}