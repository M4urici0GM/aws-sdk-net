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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ControlTower.Model;

namespace Amazon.ControlTower
{
    /// <summary>
    /// Interface for accessing ControlTower
    ///
    /// These interfaces allow you to apply the AWS library of pre-defined <i>controls</i>
    /// to your organizational units, programmatically. In AWS Control Tower, the terms "control"
    /// and "guardrail" are synonyms. .
    /// 
    ///  
    /// <para>
    /// To call these APIs, you'll need to know:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// the <code>controlIdentifier</code> for the control--or guardrail--you are targeting.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// the ARN associated with the target organizational unit (OU), which we call the <code>targetIdentifier</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>To get the <code>controlIdentifier</code> for your AWS Control Tower control:</b>
    /// 
    /// </para>
    ///  
    /// <para>
    /// The <code>controlIdentifier</code> is an ARN that is specified for each control. You
    /// can view the <code>controlIdentifier</code> in the console on the <b>Control details</b>
    /// page, as well as in the documentation.
    /// </para>
    ///  
    /// <para>
    /// The <code>controlIdentifier</code> is unique in each AWS Region for each control.
    /// You can find the <code>controlIdentifier</code> for each Region and control in the
    /// <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-metadata-tables.html">Tables
    /// of control metadata</a> in the <i>AWS Control Tower User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// A quick-reference list of control identifers for the AWS Control Tower legacy <i>Strongly
    /// recommended</i> and <i>Elective</i> controls is given in <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-identifiers.html.html">Resource
    /// identifiers for APIs and guardrails</a> in the <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-identifiers.html">Controls
    /// reference guide section</a> of the <i>AWS Control Tower User Guide</i>. Remember that
    /// <i>Mandatory</i> controls cannot be added or removed.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>ARN format:</b> <code>arn:aws:controltower:{REGION}::control/{CONTROL_NAME}</code>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Example:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:aws:controltower:us-west-2::control/AWS-GR_AUTOSCALING_LAUNCH_CONFIG_PUBLIC_IP_DISABLED</code>
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>To get the <code>targetIdentifier</code>:</b> 
    /// </para>
    ///  
    /// <para>
    /// The <code>targetIdentifier</code> is the ARN for an OU.
    /// </para>
    ///  
    /// <para>
    /// In the AWS Organizations console, you can find the ARN for the OU on the <b>Organizational
    /// unit details</b> page associated with that OU.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>OU ARN format:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <code>arn:${Partition}:organizations::${MasterAccountId}:ou/o-${OrganizationId}/ou-${OrganizationalUnitId}</code>
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Details and examples</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">Control
    /// API input and output examples with CLI</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/enable-controls.html">Enable
    /// controls with CloudFormation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-metadata-tables.html">Control
    /// metadata tables</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-identifiers.html">List
    /// of identifiers for legacy controls</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/controls.html">Controls
    /// reference guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/controls-reference.html">Controls
    /// library groupings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/creating-resources-with-cloudformation.html">Creating
    /// AWS Control Tower resources with AWS CloudFormation</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To view the open source resource repository on GitHub, see <a href="https://github.com/aws-cloudformation/aws-cloudformation-resource-providers-controltower">aws-cloudformation/aws-cloudformation-resource-providers-controltower</a>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Recording API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS Control Tower supports AWS CloudTrail, a service that records AWS API calls for
    /// your AWS account and delivers log files to an Amazon S3 bucket. By using information
    /// collected by CloudTrail, you can determine which requests the AWS Control Tower service
    /// received, who made the request and when, and so on. For more about AWS Control Tower
    /// and its support for CloudTrail, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/logging-using-cloudtrail.html">Logging
    /// AWS Control Tower Actions with AWS CloudTrail</a> in the AWS Control Tower User Guide.
    /// To learn more about CloudTrail, including how to turn it on and find your log files,
    /// see the AWS CloudTrail User Guide.
    /// </para>
    /// </summary>
    public partial interface IAmazonControlTower : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IControlTowerPaginatorFactory Paginators { get; }

        
        #region  DisableControl


        /// <summary>
        /// This API call turns off a control. It starts an asynchronous operation that deletes
        /// AWS resources on the specified organizational unit and the accounts it contains. The
        /// resources will vary according to the control that you specify. For usage examples,
        /// see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the AWS Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableControl service method.</param>
        /// 
        /// <returns>The response from the DisableControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded. The limit is 10 concurrent operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DisableControl">REST API Reference for DisableControl Operation</seealso>
        DisableControlResponse DisableControl(DisableControlRequest request);



        /// <summary>
        /// This API call turns off a control. It starts an asynchronous operation that deletes
        /// AWS resources on the specified organizational unit and the accounts it contains. The
        /// resources will vary according to the control that you specify. For usage examples,
        /// see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the AWS Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded. The limit is 10 concurrent operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DisableControl">REST API Reference for DisableControl Operation</seealso>
        Task<DisableControlResponse> DisableControlAsync(DisableControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableControl


        /// <summary>
        /// This API call activates a control. It starts an asynchronous operation that creates
        /// AWS resources on the specified organizational unit and the accounts it contains. The
        /// resources created will vary according to the control that you specify. For usage examples,
        /// see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the AWS Control Tower User Guide</i> </a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableControl service method.</param>
        /// 
        /// <returns>The response from the EnableControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded. The limit is 10 concurrent operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/EnableControl">REST API Reference for EnableControl Operation</seealso>
        EnableControlResponse EnableControl(EnableControlRequest request);



        /// <summary>
        /// This API call activates a control. It starts an asynchronous operation that creates
        /// AWS resources on the specified organizational unit and the accounts it contains. The
        /// resources created will vary according to the control that you specify. For usage examples,
        /// see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the AWS Control Tower User Guide</i> </a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded. The limit is 10 concurrent operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/EnableControl">REST API Reference for EnableControl Operation</seealso>
        Task<EnableControlResponse> EnableControlAsync(EnableControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetControlOperation


        /// <summary>
        /// Returns the status of a particular <code>EnableControl</code> or <code>DisableControl</code>
        /// operation. Displays a message in case of error. Details for an operation are available
        /// for 90 days. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the AWS Control Tower User Guide</i> </a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControlOperation service method.</param>
        /// 
        /// <returns>The response from the GetControlOperation service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetControlOperation">REST API Reference for GetControlOperation Operation</seealso>
        GetControlOperationResponse GetControlOperation(GetControlOperationRequest request);



        /// <summary>
        /// Returns the status of a particular <code>EnableControl</code> or <code>DisableControl</code>
        /// operation. Displays a message in case of error. Details for an operation are available
        /// for 90 days. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the AWS Control Tower User Guide</i> </a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControlOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetControlOperation service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetControlOperation">REST API Reference for GetControlOperation Operation</seealso>
        Task<GetControlOperationResponse> GetControlOperationAsync(GetControlOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEnabledControl


        /// <summary>
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
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledControl service method.</param>
        /// 
        /// <returns>The response from the GetEnabledControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetEnabledControl">REST API Reference for GetEnabledControl Operation</seealso>
        GetEnabledControlResponse GetEnabledControl(GetEnabledControlRequest request);



        /// <summary>
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
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnabledControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetEnabledControl">REST API Reference for GetEnabledControl Operation</seealso>
        Task<GetEnabledControlResponse> GetEnabledControlAsync(GetEnabledControlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEnabledControls


        /// <summary>
        /// Lists the controls enabled by AWS Control Tower on the specified organizational unit
        /// and the accounts it contains. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the AWS Control Tower User Guide</i> </a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledControls service method.</param>
        /// 
        /// <returns>The response from the ListEnabledControls service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListEnabledControls">REST API Reference for ListEnabledControls Operation</seealso>
        ListEnabledControlsResponse ListEnabledControls(ListEnabledControlsRequest request);



        /// <summary>
        /// Lists the controls enabled by AWS Control Tower on the specified organizational unit
        /// and the accounts it contains. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the AWS Control Tower User Guide</i> </a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnabledControls service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListEnabledControls">REST API Reference for ListEnabledControls Operation</seealso>
        Task<ListEnabledControlsResponse> ListEnabledControlsAsync(ListEnabledControlsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}