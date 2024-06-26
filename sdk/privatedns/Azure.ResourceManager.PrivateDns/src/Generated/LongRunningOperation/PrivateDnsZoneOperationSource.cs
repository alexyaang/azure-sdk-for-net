// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PrivateDns
{
    internal class PrivateDnsZoneOperationSource : IOperationSource<PrivateDnsZoneResource>
    {
        private readonly ArmClient _client;

        internal PrivateDnsZoneOperationSource(ArmClient client)
        {
            _client = client;
        }

        PrivateDnsZoneResource IOperationSource<PrivateDnsZoneResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PrivateDnsZoneData.DeserializePrivateDnsZoneData(document.RootElement);
            return new PrivateDnsZoneResource(_client, data);
        }

        async ValueTask<PrivateDnsZoneResource> IOperationSource<PrivateDnsZoneResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PrivateDnsZoneData.DeserializePrivateDnsZoneData(document.RootElement);
            return new PrivateDnsZoneResource(_client, data);
        }
    }
}
