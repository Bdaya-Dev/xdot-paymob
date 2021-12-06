// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace X.Paymob.CashIn.Models.Orders; 

[PublicAPI]
public class CashInOrderShippingData {
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; init; } = default!;

    [JsonPropertyName("last_name")]
    public string LastName { get; init; } = default!;

    [JsonPropertyName("email")]
    public string Email { get; init; } = default!;

    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; init; } = default!;

    [JsonPropertyName("street")]
    public string Street { get; init; } = "NA";

    [JsonPropertyName("building")]
    public string Building { get; init; } = "NA";

    [JsonPropertyName("floor")]
    public string Floor { get; init; } = "NA";

    [JsonPropertyName("apartment")]
    public string Apartment { get; init; } = "NA";

    [JsonPropertyName("city")]
    public string City { get; init; } = "NA";

    [JsonPropertyName("state")]
    public string State { get; init; } = "NA";

    [JsonPropertyName("country")]
    public string Country { get; init; } = "NA";

    [JsonPropertyName("postal_code")]
    public string PostalCode { get; init; } = "NA";

    [JsonPropertyName("order_id")]
    public int OrderId { get; init; }

    [JsonPropertyName("order")]
    public int Order { get; init; }

    [JsonPropertyName("extra_description")]
    public string ExtraDescription { get; init; } = "NA";

    [JsonPropertyName("shipping_method")]
    public string ShippingMethod { get; init; } = "UNK";

    [JsonExtensionData]
    public IDictionary<string, object?>? ExtensionData { get; init; }
}