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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Container for the parameters to the GetEnabledControl operation.
    /// Provides details about the enabled control. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
    /// <i>the AWS Control Tower User Guide</i> </a>.
    /// 
    ///  
    /// <para>
    ///  <b>Returned values</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// TargetRegions: Shows target AWS Regions where the enabled control is available to
    /// be deployed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// StatusSummary: Provides a detailed summary of the deployment status.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DriftSummary: Provides a detailed summary of the drifted status.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetEnabledControlRequest : AmazonControlTowerRequest
    {
        private string _enabledControlIdentifier;

        /// <summary>
        /// Gets and sets the property EnabledControlIdentifier. 
        /// <para>
        ///  The ARN of the enabled control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EnabledControlIdentifier
        {
            get { return this._enabledControlIdentifier; }
            set { this._enabledControlIdentifier = value; }
        }

        // Check to see if EnabledControlIdentifier property is set
        internal bool IsSetEnabledControlIdentifier()
        {
            return this._enabledControlIdentifier != null;
        }

    }
}