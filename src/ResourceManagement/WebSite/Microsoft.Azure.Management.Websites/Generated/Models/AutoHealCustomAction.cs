// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Custom action to be executed
    /// when an auto heal rule is triggered.
    /// </summary>
    public partial class AutoHealCustomAction
    {
        /// <summary>
        /// Initializes a new instance of the AutoHealCustomAction class.
        /// </summary>
        public AutoHealCustomAction() { }

        /// <summary>
        /// Initializes a new instance of the AutoHealCustomAction class.
        /// </summary>
        /// <param name="exe">Executable to be run.</param>
        /// <param name="parameters">Parameters for the executable.</param>
        public AutoHealCustomAction(string exe = default(string), string parameters = default(string))
        {
            Exe = exe;
            Parameters = parameters;
        }

        /// <summary>
        /// Gets or sets executable to be run.
        /// </summary>
        [JsonProperty(PropertyName = "exe")]
        public string Exe { get; set; }

        /// <summary>
        /// Gets or sets parameters for the executable.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public string Parameters { get; set; }

    }
}

