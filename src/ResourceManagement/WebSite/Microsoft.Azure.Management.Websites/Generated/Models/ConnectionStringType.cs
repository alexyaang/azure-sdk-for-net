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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ConnectionStringType.
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConnectionStringType
    {
        [EnumMember(Value = "MySql")]
        MySql,
        [EnumMember(Value = "SQLServer")]
        SQLServer,
        [EnumMember(Value = "SQLAzure")]
        SQLAzure,
        [EnumMember(Value = "Custom")]
        Custom,
        [EnumMember(Value = "NotificationHub")]
        NotificationHub,
        [EnumMember(Value = "ServiceBus")]
        ServiceBus,
        [EnumMember(Value = "EventHub")]
        EventHub,
        [EnumMember(Value = "ApiHub")]
        ApiHub,
        [EnumMember(Value = "DocDb")]
        DocDb,
        [EnumMember(Value = "RedisCache")]
        RedisCache
    }
}

