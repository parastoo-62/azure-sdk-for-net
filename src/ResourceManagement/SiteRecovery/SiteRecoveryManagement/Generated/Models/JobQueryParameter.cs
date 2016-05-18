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
using Hyak.Common;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The definition of a JobQueryParameter object.
    /// </summary>
    public partial class JobQueryParameter
    {
        private IList<string> _affectedObjectTypes;
        
        /// <summary>
        /// Optional. List of type of objects to fetch jobs for.
        /// </summary>
        public IList<string> AffectedObjectTypes
        {
            get { return this._affectedObjectTypes; }
            set { this._affectedObjectTypes = value; }
        }
        
        private string _endTime;
        
        /// <summary>
        /// Optional. End range of start UTC time in seconds.
        /// </summary>
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private string _fabricId;
        
        /// <summary>
        /// Optional. Id of affected fabric.
        /// </summary>
        public string FabricId
        {
            get { return this._fabricId; }
            set { this._fabricId = value; }
        }
        
        private IList<string> _jobStatus;
        
        /// <summary>
        /// Optional. List of status the job to be fetched can be in.
        /// </summary>
        public IList<string> JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }
        
        private string _startTime;
        
        /// <summary>
        /// Optional. Start UTC time in seconds.
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobQueryParameter class.
        /// </summary>
        public JobQueryParameter()
        {
            this.AffectedObjectTypes = new LazyList<string>();
            this.JobStatus = new LazyList<string>();
        }
    }
}