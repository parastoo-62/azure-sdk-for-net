// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Management.BackupServices.Models;

namespace Microsoft.Azure.Management.BackupServices
{
    public static partial class CSMProtectionPolicyOperationsExtensions
    {
        /// <summary>
        /// Create new Protection Policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.ICSMProtectionPolicyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='policyName'>
        /// Required. The protection policy Name to be updated.
        /// </param>
        /// <param name='cSMAddProtectionPolicyRequest'>
        /// Required. The protection policy creation request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Add(this ICSMProtectionPolicyOperations operations, string resourceGroupName, string resourceName, string policyName, CSMAddProtectionPolicyRequest cSMAddProtectionPolicyRequest, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICSMProtectionPolicyOperations)s).AddAsync(resourceGroupName, resourceName, policyName, cSMAddProtectionPolicyRequest, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create new Protection Policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.ICSMProtectionPolicyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='policyName'>
        /// Required. The protection policy Name to be updated.
        /// </param>
        /// <param name='cSMAddProtectionPolicyRequest'>
        /// Required. The protection policy creation request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> AddAsync(this ICSMProtectionPolicyOperations operations, string resourceGroupName, string resourceName, string policyName, CSMAddProtectionPolicyRequest cSMAddProtectionPolicyRequest, CustomRequestHeaders customRequestHeaders)
        {
            return operations.AddAsync(resourceGroupName, resourceName, policyName, cSMAddProtectionPolicyRequest, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete a Protection Policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.ICSMProtectionPolicyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='policyName'>
        /// Required. The protection policy Name to be deleted.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this ICSMProtectionPolicyOperations operations, string resourceGroupName, string resourceName, string policyName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICSMProtectionPolicyOperations)s).DeleteAsync(resourceGroupName, resourceName, policyName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete a Protection Policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.ICSMProtectionPolicyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='policyName'>
        /// Required. The protection policy Name to be deleted.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this ICSMProtectionPolicyOperations operations, string resourceGroupName, string resourceName, string policyName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.DeleteAsync(resourceGroupName, resourceName, policyName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Get the list of all Protection Policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.ICSMProtectionPolicyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a CSMProtectionPolicyListOperationResponse.
        /// </returns>
        public static CSMProtectionPolicyListOperationResponse List(this ICSMProtectionPolicyOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICSMProtectionPolicyOperations)s).ListAsync(resourceGroupName, resourceName, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get the list of all Protection Policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.ICSMProtectionPolicyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a CSMProtectionPolicyListOperationResponse.
        /// </returns>
        public static Task<CSMProtectionPolicyListOperationResponse> ListAsync(this ICSMProtectionPolicyOperations operations, string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(resourceGroupName, resourceName, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Update Protection Policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.ICSMProtectionPolicyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='policyName'>
        /// Required. The protection policy Name to be updated.
        /// </param>
        /// <param name='cSMUpdateProtectionPolicyRequest'>
        /// Required. The protection policy creation request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static OperationResponse Update(this ICSMProtectionPolicyOperations operations, string resourceGroupName, string resourceName, string policyName, CSMUpdateProtectionPolicyRequest cSMUpdateProtectionPolicyRequest, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICSMProtectionPolicyOperations)s).UpdateAsync(resourceGroupName, resourceName, policyName, cSMUpdateProtectionPolicyRequest, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update Protection Policy.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.ICSMProtectionPolicyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='policyName'>
        /// Required. The protection policy Name to be updated.
        /// </param>
        /// <param name='cSMUpdateProtectionPolicyRequest'>
        /// Required. The protection policy creation request.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static Task<OperationResponse> UpdateAsync(this ICSMProtectionPolicyOperations operations, string resourceGroupName, string resourceName, string policyName, CSMUpdateProtectionPolicyRequest cSMUpdateProtectionPolicyRequest, CustomRequestHeaders customRequestHeaders)
        {
            return operations.UpdateAsync(resourceGroupName, resourceName, policyName, cSMUpdateProtectionPolicyRequest, customRequestHeaders, CancellationToken.None);
        }
    }
}
