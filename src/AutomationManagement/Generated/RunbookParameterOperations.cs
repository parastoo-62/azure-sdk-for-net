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
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.Automation
{
    /// <summary>
    /// Service operation for automation runbook parameters.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
    /// more information)
    /// </summary>
    internal partial class RunbookParameterOperations : IServiceOperations<AutomationManagementClient>, IRunbookParameterOperations
    {
        /// <summary>
        /// Initializes a new instance of the RunbookParameterOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal RunbookParameterOperations(AutomationManagementClient client)
        {
            this._client = client;
        }
        
        private AutomationManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.Automation.AutomationManagementClient.
        /// </summary>
        public AutomationManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Retrieve a list of runbook versions filtered by parameters.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookVersionId'>
        /// Required. The runbook version id.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list runbook parameter operation.
        /// </returns>
        public async Task<RunbookParameterListResponse> ListByRunbookVersionIdAsync(string automationAccount, string runbookVersionId, CancellationToken cancellationToken)
        {
            // Validate
            if (automationAccount == null)
            {
                throw new ArgumentNullException("automationAccount");
            }
            if (runbookVersionId == null)
            {
                throw new ArgumentNullException("runbookVersionId");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("automationAccount", automationAccount);
                tracingParameters.Add("runbookVersionId", runbookVersionId);
                Tracing.Enter(invocationId, this, "ListByRunbookVersionIdAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/" + (this.Client.Credentials.SubscriptionId != null ? this.Client.Credentials.SubscriptionId.Trim() : "") + "/cloudservices/OaaSCS/resources/automation/~/Accounts/" + automationAccount.Trim() + "/RunbookParameters?";
            bool appendFilter = true;
            appendFilter = false;
            url = url + "$filter=" + "RunbookVersionID eq guid'" + Uri.EscapeDataString(runbookVersionId.Trim()) + "'";
            url = url + "&api-version=2014-03-13_Preview";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json");
                httpRequest.Headers.Add("MaxDataServiceVersion", "3.0");
                httpRequest.Headers.Add("MinDataServiceVersion", "3.0");
                httpRequest.Headers.Add("x-ms-version", "2013-06-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    RunbookParameterListResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new RunbookParameterListResponse();
                    JToken responseDoc = null;
                    if (string.IsNullOrEmpty(responseContent) == false)
                    {
                        responseDoc = JToken.Parse(responseContent);
                    }
                    
                    if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                    {
                        JToken valueArray = responseDoc["value"];
                        if (valueArray != null && valueArray.Type != JTokenType.Null)
                        {
                            foreach (JToken valueValue in ((JArray)valueArray))
                            {
                                RunbookParameter runbookParameterInstance = new RunbookParameter();
                                result.RunbookParameters.Add(runbookParameterInstance);
                                
                                JToken runbookVersionIDValue = valueValue["RunbookVersionID"];
                                if (runbookVersionIDValue != null && runbookVersionIDValue.Type != JTokenType.Null)
                                {
                                    string runbookVersionIDInstance = ((string)runbookVersionIDValue);
                                    runbookParameterInstance.RunbookVersionId = runbookVersionIDInstance;
                                }
                                
                                JToken nameValue = valueValue["Name"];
                                if (nameValue != null && nameValue.Type != JTokenType.Null)
                                {
                                    string nameInstance = ((string)nameValue);
                                    runbookParameterInstance.Name = nameInstance;
                                }
                                
                                JToken typeValue = valueValue["Type"];
                                if (typeValue != null && typeValue.Type != JTokenType.Null)
                                {
                                    string typeInstance = ((string)typeValue);
                                    runbookParameterInstance.Type = typeInstance;
                                }
                                
                                JToken isMandatoryValue = valueValue["IsMandatory"];
                                if (isMandatoryValue != null && isMandatoryValue.Type != JTokenType.Null)
                                {
                                    bool isMandatoryInstance = ((bool)isMandatoryValue);
                                    runbookParameterInstance.IsMandatory = isMandatoryInstance;
                                }
                                
                                JToken positionValue = valueValue["Position"];
                                if (positionValue != null && positionValue.Type != JTokenType.Null)
                                {
                                    int positionInstance = ((int)positionValue);
                                    runbookParameterInstance.Position = positionInstance;
                                }
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}