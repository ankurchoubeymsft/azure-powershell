﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSComputeNode
    {
        
        internal Microsoft.Azure.Batch.ComputeNode omObject;
        
        private IReadOnlyList<PSCertificateReference> certificateReferences;
        
        private IReadOnlyList<PSComputeNodeError> errors;
        
        private IReadOnlyList<PSTaskInformation> recentTasks;
        
        private PSStartTask startTask;
        
        private PSStartTaskInformation startTaskInformation;
        
        internal PSComputeNode(Microsoft.Azure.Batch.ComputeNode omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public string AffinityId
        {
            get
            {
                return this.omObject.AffinityId;
            }
        }
        
        public System.DateTime? AllocationTime
        {
            get
            {
                return this.omObject.AllocationTime;
            }
        }
        
        public IReadOnlyList<PSCertificateReference> CertificateReferences
        {
            get
            {
                if (((this.certificateReferences == null) 
                            && (this.omObject.CertificateReferences != null)))
                {
                    List<PSCertificateReference> list;
                    list = new List<PSCertificateReference>();
                    IEnumerator<Microsoft.Azure.Batch.CertificateReference> enumerator;
                    enumerator = this.omObject.CertificateReferences.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSCertificateReference(enumerator.Current));
                    }
                    this.certificateReferences = list.AsReadOnly();
                }
                return this.certificateReferences;
            }
        }
        
        public IReadOnlyList<PSComputeNodeError> Errors
        {
            get
            {
                if (((this.errors == null) 
                            && (this.omObject.Errors != null)))
                {
                    List<PSComputeNodeError> list;
                    list = new List<PSComputeNodeError>();
                    IEnumerator<Microsoft.Azure.Batch.ComputeNodeError> enumerator;
                    enumerator = this.omObject.Errors.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSComputeNodeError(enumerator.Current));
                    }
                    this.errors = list.AsReadOnly();
                }
                return this.errors;
            }
        }
        
        public string Id
        {
            get
            {
                return this.omObject.Id;
            }
        }
        
        public string IPAddress
        {
            get
            {
                return this.omObject.IPAddress;
            }
        }
        
        public System.DateTime? LastBootTime
        {
            get
            {
                return this.omObject.LastBootTime;
            }
        }
        
        public IReadOnlyList<PSTaskInformation> RecentTasks
        {
            get
            {
                if (((this.recentTasks == null) 
                            && (this.omObject.RecentTasks != null)))
                {
                    List<PSTaskInformation> list;
                    list = new List<PSTaskInformation>();
                    IEnumerator<Microsoft.Azure.Batch.TaskInformation> enumerator;
                    enumerator = this.omObject.RecentTasks.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSTaskInformation(enumerator.Current));
                    }
                    this.recentTasks = list.AsReadOnly();
                }
                return this.recentTasks;
            }
        }
        
        public Microsoft.Azure.Batch.Common.SchedulingState? SchedulingState
        {
            get
            {
                return this.omObject.SchedulingState;
            }
        }
        
        public PSStartTask StartTask
        {
            get
            {
                if (((this.startTask == null) 
                            && (this.omObject.StartTask != null)))
                {
                    this.startTask = new PSStartTask(this.omObject.StartTask);
                }
                return this.startTask;
            }
        }
        
        public PSStartTaskInformation StartTaskInformation
        {
            get
            {
                if (((this.startTaskInformation == null) 
                            && (this.omObject.StartTaskInformation != null)))
                {
                    this.startTaskInformation = new PSStartTaskInformation(this.omObject.StartTaskInformation);
                }
                return this.startTaskInformation;
            }
        }
        
        public Microsoft.Azure.Batch.Common.ComputeNodeState? State
        {
            get
            {
                return this.omObject.State;
            }
        }
        
        public System.DateTime? StateTransitionTime
        {
            get
            {
                return this.omObject.StateTransitionTime;
            }
        }
        
        public System.Int32? TotalTasksRun
        {
            get
            {
                return this.omObject.TotalTasksRun;
            }
        }
        
        public string Url
        {
            get
            {
                return this.omObject.Url;
            }
        }
        
        public string VirtualMachineSize
        {
            get
            {
                return this.omObject.VirtualMachineSize;
            }
        }
    }
}
