// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.Attestation
{
    internal partial class TpmAttestationResponse
    {
        internal static TpmAttestationResponse DeserializeTpmAttestationResponse(JsonElement element)
        {
            Optional<string> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"))
                {
                    data = property.Value.GetString();
                    continue;
                }
            }
            return new TpmAttestationResponse(data.Value);
        }
    }
}
