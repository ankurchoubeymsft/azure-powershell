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
    [Cmdlet("New", "AzureRmVmssConfig")]
    [OutputType(typeof(VirtualMachineScaleSet))]
    public class NewAzureRmVmssConfigCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        public string ProvisioningState { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public bool? OverProvision { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string Location { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public Hashtable Tag { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string SkuName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipelineByPropertyName = true)]
        public string SkuTier { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true)]
        public Int64? SkuCapacity { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true)]
        public UpgradeMode? UpgradePolicyMode { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 8,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetOSProfile OsProfile { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 9,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetStorageProfile StorageProfile { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 10,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetNetworkConfiguration [] NetworkInterfaceConfiguration { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 11,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetExtension [] Extension { get; set; }

        protected override void ProcessRecord()
        {
            // Sku
            var vSku = new Microsoft.Azure.Management.Compute.Models.Sku();

            // UpgradePolicy
            var vUpgradePolicy = new Microsoft.Azure.Management.Compute.Models.UpgradePolicy();

            // VirtualMachineProfile
            var vVirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();

            // NetworkProfile
            vVirtualMachineProfile.NetworkProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetNetworkProfile();

            // ExtensionProfile
            vVirtualMachineProfile.ExtensionProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetExtensionProfile();
            vSku.Name = this.SkuName;
            vSku.Tier = this.SkuTier;
            vSku.Capacity = this.SkuCapacity;
            vUpgradePolicy.Mode = this.UpgradePolicyMode;
            vVirtualMachineProfile.OsProfile = this.OsProfile;
            vVirtualMachineProfile.StorageProfile = this.StorageProfile;
            vVirtualMachineProfile.NetworkProfile.NetworkInterfaceConfigurations = this.NetworkInterfaceConfiguration;
            vVirtualMachineProfile.ExtensionProfile.Extensions = this.Extension;

            var vVirtualMachineScaleSet = new VirtualMachineScaleSet
            {
                ProvisioningState = this.ProvisioningState,
                OverProvision = this.OverProvision,
                Location = this.Location,
                Tags = (this.Tag == null) ? null : this.Tag.Cast<DictionaryEntry>().ToDictionary(ht => (string)ht.Key, ht => (string)ht.Value),
                Sku = vSku,
                UpgradePolicy = vUpgradePolicy,
                VirtualMachineProfile = vVirtualMachineProfile,
            };

            WriteObject(vVirtualMachineScaleSet);
        }
    }
}

