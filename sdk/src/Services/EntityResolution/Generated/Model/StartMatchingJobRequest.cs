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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Container for the parameters to the StartMatchingJob operation.
    /// Starts the <code>MatchingJob</code> of a workflow. The workflow must have previously
    /// been created using the <code>CreateMatchingWorkflow</code> endpoint.
    /// </summary>
    public partial class StartMatchingJobRequest : AmazonEntityResolutionRequest
    {
        private string _workflowName;

        /// <summary>
        /// Gets and sets the property WorkflowName. 
        /// <para>
        /// The name of the matching job to be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string WorkflowName
        {
            get { return this._workflowName; }
            set { this._workflowName = value; }
        }

        // Check to see if WorkflowName property is set
        internal bool IsSetWorkflowName()
        {
            return this._workflowName != null;
        }

    }
}