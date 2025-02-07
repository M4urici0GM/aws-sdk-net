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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Specifies whether the configuration recorder excludes certain resource types from
    /// being recorded. Use the <code>resourceTypes</code> field to enter a comma-separated
    /// list of resource types you want to exclude from recording.
    /// 
    ///  
    /// <para>
    /// By default, when Config adds support for a new resource type in the Region where you
    /// set up the configuration recorder, including global resource types, Config starts
    /// recording resources of that type automatically.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>How to use</b> 
    /// </para>
    ///  
    /// <para>
    /// To use this option, you must set the <code>useOnly</code> field of <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingStrategy.html">RecordingStrategy</a>
    /// to <code>EXCLUSION_BY_RESOURCE_TYPES</code>.
    /// </para>
    ///  
    /// <para>
    /// Config will then record configuration changes for all supported resource types, except
    /// the resource types that you specify to exclude from being recorded.
    /// </para>
    ///  
    /// <para>
    ///  <b>Globally recorded resources</b> 
    /// </para>
    ///  
    /// <para>
    /// Unless specifically listed as exclusions, <code>AWS::RDS::GlobalCluster</code> will
    /// be recorded automatically in all supported Config Regions were the configuration recorder
    /// is enabled. IAM users, groups, roles, and customer managed policies will be recorded
    /// automatically in all enabled Config Regions where Config was available before February
    /// 2022. This list does not include the following Regions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Asia Pacific (Hyderabad)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Asia Pacific (Melbourne)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Europe (Spain)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Europe (Zurich)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Israel (Tel Aviv)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Middle East (UAE)
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class ExclusionByResourceTypes
    {
        private List<string> _resourceTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// A comma-separated list of resource types to exclude from recording by the configuration
        /// recorder.
        /// </para>
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && this._resourceTypes.Count > 0; 
        }

    }
}