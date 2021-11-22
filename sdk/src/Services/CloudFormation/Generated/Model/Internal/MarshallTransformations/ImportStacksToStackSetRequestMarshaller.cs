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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportStacksToStackSet Request Marshaller
    /// </summary>       
    public class ImportStacksToStackSetRequestMarshaller : IMarshaller<IRequest, ImportStacksToStackSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportStacksToStackSetRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportStacksToStackSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "ImportStacksToStackSet");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCallAs())
                {
                    request.Parameters.Add("CallAs", StringUtils.FromString(publicRequest.CallAs));
                }
                if(publicRequest.IsSetOperationId())
                {
                    request.Parameters.Add("OperationId", StringUtils.FromString(publicRequest.OperationId));
                }
                else if(!(publicRequest.IsSetOperationId()))
                {
                    request.Parameters.Add("OperationId", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetOperationPreferences())
                {
                    if(publicRequest.OperationPreferences.IsSetFailureToleranceCount())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "FailureToleranceCount", StringUtils.FromInt(publicRequest.OperationPreferences.FailureToleranceCount));
                    }
                    if(publicRequest.OperationPreferences.IsSetFailureTolerancePercentage())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "FailureTolerancePercentage", StringUtils.FromInt(publicRequest.OperationPreferences.FailureTolerancePercentage));
                    }
                    if(publicRequest.OperationPreferences.IsSetMaxConcurrentCount())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "MaxConcurrentCount", StringUtils.FromInt(publicRequest.OperationPreferences.MaxConcurrentCount));
                    }
                    if(publicRequest.OperationPreferences.IsSetMaxConcurrentPercentage())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "MaxConcurrentPercentage", StringUtils.FromInt(publicRequest.OperationPreferences.MaxConcurrentPercentage));
                    }
                    if(publicRequest.OperationPreferences.IsSetRegionConcurrencyType())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "RegionConcurrencyType", StringUtils.FromString(publicRequest.OperationPreferences.RegionConcurrencyType));
                    }
                    if(publicRequest.OperationPreferences.IsSetRegionOrder())
                    {
                        int publicRequestOperationPreferenceslistValueIndex = 1;
                        foreach(var publicRequestOperationPreferenceslistValue in publicRequest.OperationPreferences.RegionOrder)
                        {
                            request.Parameters.Add("OperationPreferences" + "." + "RegionOrder" + "." + "member" + "." + publicRequestOperationPreferenceslistValueIndex, StringUtils.FromString(publicRequestOperationPreferenceslistValue));
                            publicRequestOperationPreferenceslistValueIndex++;
                        }
                    }
                }
                if(publicRequest.IsSetOrganizationalUnitIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.OrganizationalUnitIds)
                    {
                        request.Parameters.Add("OrganizationalUnitIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetStackIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.StackIds)
                    {
                        request.Parameters.Add("StackIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetStackIdsUrl())
                {
                    request.Parameters.Add("StackIdsUrl", StringUtils.FromString(publicRequest.StackIdsUrl));
                }
                if(publicRequest.IsSetStackSetName())
                {
                    request.Parameters.Add("StackSetName", StringUtils.FromString(publicRequest.StackSetName));
                }
            }
            return request;
        }
                    private static ImportStacksToStackSetRequestMarshaller _instance = new ImportStacksToStackSetRequestMarshaller();        

        internal static ImportStacksToStackSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportStacksToStackSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}