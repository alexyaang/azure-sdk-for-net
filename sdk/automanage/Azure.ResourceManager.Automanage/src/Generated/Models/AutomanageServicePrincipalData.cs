// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automanage.Models
{
    /// <summary> The Service Principal Id for the subscription. </summary>
    public partial class AutomanageServicePrincipalData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AutomanageServicePrincipalData"/>. </summary>
        public AutomanageServicePrincipalData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomanageServicePrincipalData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="servicePrincipalId"> The Service Principal Id for the subscription. </param>
        /// <param name="isAuthorizationSet"> Returns the contributor RBAC Role exist or not for the Service Principal Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomanageServicePrincipalData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string servicePrincipalId, bool? isAuthorizationSet, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ServicePrincipalId = servicePrincipalId;
            IsAuthorizationSet = isAuthorizationSet;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Service Principal Id for the subscription. </summary>
        public string ServicePrincipalId { get; }
        /// <summary> Returns the contributor RBAC Role exist or not for the Service Principal Id. </summary>
        public bool? IsAuthorizationSet { get; }
    }
}
