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

using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet("New", "AzureRmVmssIpConfig")]
    [OutputType(typeof(VirtualMachineScaleSet))]
    public class NewAzureRmVmssIpConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public string Id { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string SubnetId { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public string [] LoadBalancerBackendAddressPoolsId { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string [] LoadBalancerInboundNatPoolsId { get; set; }

        protected override void ProcessRecord()
        {
            var vIpConfigurations = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetIPConfiguration();

            // Subnet
            vIpConfigurations.Subnet = new Microsoft.Azure.Management.Compute.Models.ApiEntityReference();

            // LoadBalancerBackendAddressPools
            vIpConfigurations.LoadBalancerBackendAddressPools = new List<Microsoft.Azure.Management.Compute.Models.SubResource>();

            // LoadBalancerInboundNatPools
            vIpConfigurations.LoadBalancerInboundNatPools = new List<Microsoft.Azure.Management.Compute.Models.SubResource>();

            vIpConfigurations.Name = this.Name;
            vIpConfigurations.Id = this.Id;
            vIpConfigurations.Subnet.Id = this.SubnetId;
            if (this.LoadBalancerBackendAddressPoolsId != null)
            {
                foreach (var element in this.LoadBalancerBackendAddressPoolsId)
                {
                    var vLoadBalancerBackendAddressPools = new Microsoft.Azure.Management.Compute.Models.SubResource();
                    vLoadBalancerBackendAddressPools.Id = element;
                    vIpConfigurations.LoadBalancerBackendAddressPools.Add(vLoadBalancerBackendAddressPools);
                }
            }

            if (this.LoadBalancerInboundNatPoolsId != null)
            {
                foreach (var element in this.LoadBalancerInboundNatPoolsId)
                {
                    var vLoadBalancerInboundNatPools = new Microsoft.Azure.Management.Compute.Models.SubResource();
                    vLoadBalancerInboundNatPools.Id = element;
                    vIpConfigurations.LoadBalancerInboundNatPools.Add(vLoadBalancerInboundNatPools);
                }
            }

            WriteObject(vIpConfigurations);
        }
    }
}

