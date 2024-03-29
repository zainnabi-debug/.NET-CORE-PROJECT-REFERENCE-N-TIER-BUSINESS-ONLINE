﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Triton.Model.TritonStaging.External.RWS;
//
//    var rwsWaybillSearch = RwsWaybillSearch.FromJson(jsonString);

namespace Triton.Model.TritonStaging.External.RWS
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RwsWaybillSearch
    {
        [JsonProperty("data")]
        public RwsWaybillSearchData Data { get; set; }
    }

    public partial class RwsWaybillSearchData
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("client_id")]
        public long ClientId { get; set; }

        [JsonProperty("waybill_number")]
        public string WaybillNumber { get; set; }

        [JsonProperty("status_id")]
        public long StatusId { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("job_type")]
        public string JobType { get; set; }

        [JsonProperty("collection_date")]
        public DateTimeOffset CollectionDate { get; set; }

        [JsonProperty("collection_hub_id")]
        public long CollectionHubId { get; set; }

        [JsonProperty("delivery_hub_id")]
        public long DeliveryHubId { get; set; }

        [JsonProperty("collection_address_id")]
        public long CollectionAddressId { get; set; }

        [JsonProperty("delivery_address_id")]
        public long DeliveryAddressId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("total_exc_vat")]
        public double TotalExcVat { get; set; }

        [JsonProperty("total_inc_vat")]
        public double TotalIncVat { get; set; }

        [JsonProperty("collection_address")]
        public Address CollectionAddress { get; set; }

        [JsonProperty("delivery_address")]
        public Address DeliveryAddress { get; set; }

        [JsonProperty("status_tracking")]
        public StatusTracking StatusTracking { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("data")]
        public CollectionAddressData Data { get; set; }
    }

    public partial class CollectionAddressData
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("client_id")]
        public long ClientId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("cell")]
        public string Cell { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("building")]
        public string Building { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("suburb_name")]
        public string SuburbName { get; set; }

        [JsonProperty("suburb_id")]
        public object SuburbId { get; set; }

        [JsonProperty("postal_code")]
        public object PostalCode { get; set; }

        [JsonProperty("town_name")]
        public string TownName { get; set; }

        [JsonProperty("town_id")]
        public long TownId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("accuracy")]
        public long Accuracy { get; set; }

        [JsonProperty("geocoded_date")]
        public object GeocodedDate { get; set; }

        [JsonProperty("hub_id")]
        public long HubId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class StatusTracking
    {
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("status_id")]
        public long StatusId { get; set; }

        [JsonProperty("hub_id")]
        public long HubId { get; set; }

        [JsonProperty("hub")]
        public string Hub { get; set; }

        [JsonProperty("created_at")]
        public CreatedAt CreatedAt { get; set; }
    }

    public partial class CreatedAt
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("timezone_type")]
        public long TimezoneType { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public partial class RwsWaybillSearch
    {
        public static RwsWaybillSearch FromJson(string json) => JsonConvert.DeserializeObject<RwsWaybillSearch>(json, Triton.Model.TritonStaging.External.RWS.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RwsWaybillSearch self) => JsonConvert.SerializeObject(self, Triton.Model.TritonStaging.External.RWS.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
