﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using RandomContact;
//
//    var userModel = UserModel.FromJson(jsonString);

namespace RandomContact
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class UserModel
    {
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public Result[] Results { get; set; }

        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public Info Info { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("seed", NullValueHandling = NullValueHandling.Ignore)]
        public string Seed { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public long? Results { get; set; }

        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public long? Page { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public Gender? Gender { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Name Name { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("login", NullValueHandling = NullValueHandling.Ignore)]
        public Login Login { get; set; }

        [JsonProperty("dob", NullValueHandling = NullValueHandling.Ignore)]
        public Dob Dob { get; set; }

        [JsonProperty("registered", NullValueHandling = NullValueHandling.Ignore)]
        public Dob Registered { get; set; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [JsonProperty("cell", NullValueHandling = NullValueHandling.Ignore)]
        public string Cell { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Id Id { get; set; }

        [JsonProperty("picture", NullValueHandling = NullValueHandling.Ignore)]
        public Picture Picture { get; set; }

        [JsonProperty("nat", NullValueHandling = NullValueHandling.Ignore)]
        public string Nat { get; set; }
    }

    public partial class Dob
    {
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public long? Age { get; set; }
    }

    public partial class Id
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("street", NullValueHandling = NullValueHandling.Ignore)]
        public Street Street { get; set; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("postcode", NullValueHandling = NullValueHandling.Ignore)]
        public Postcode? Postcode { get; set; }

        [JsonProperty("coordinates", NullValueHandling = NullValueHandling.Ignore)]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public Timezone Timezone { get; set; }
    }

    public partial class Coordinates
    {
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Latitude { get; set; }

        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Longitude { get; set; }
    }

    public partial class Street
    {
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public long? Number { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public partial class Timezone
    {
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public partial class Login
    {
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Uuid { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        [JsonProperty("salt", NullValueHandling = NullValueHandling.Ignore)]
        public string Salt { get; set; }

        [JsonProperty("md5", NullValueHandling = NullValueHandling.Ignore)]
        public string Md5 { get; set; }

        [JsonProperty("sha1", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha1 { get; set; }

        [JsonProperty("sha256", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha256 { get; set; }
    }

    public partial class Name
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; }

        [JsonProperty("first", NullValueHandling = NullValueHandling.Ignore)]
        public string First { get; set; }

        [JsonProperty("last", NullValueHandling = NullValueHandling.Ignore)]
        public string Last { get; set; }
    }

    public partial class Picture
    {
        [JsonProperty("large", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Large { get; set; }

        [JsonProperty("medium", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Medium { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Thumbnail { get; set; }
    }

    public enum Gender { Female, Male };

    public enum Title { Madame, Miss, Monsieur, Mr, Mrs, Ms };

    public partial struct Postcode
    {
        public long? Integer;
        public string String;

        public static implicit operator Postcode(long Integer) => new Postcode { Integer = Integer };
        public static implicit operator Postcode(string String) => new Postcode { String = String };
    }

    public partial class UserModel
    {
        public static UserModel FromJson(string json) => JsonConvert.DeserializeObject<UserModel>(json, RandomContact.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this UserModel self) => JsonConvert.SerializeObject(self, RandomContact.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                GenderConverter.Singleton,
                PostcodeConverter.Singleton,
                TitleConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class GenderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Gender) || t == typeof(Gender?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "female":
                    return Gender.Female;
                case "male":
                    return Gender.Male;
            }
            throw new Exception("Cannot unmarshal type Gender");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Gender)untypedValue;
            switch (value)
            {
                case Gender.Female:
                    serializer.Serialize(writer, "female");
                    return;
                case Gender.Male:
                    serializer.Serialize(writer, "male");
                    return;
            }
            throw new Exception("Cannot marshal type Gender");
        }

        public static readonly GenderConverter Singleton = new GenderConverter();
    }

    internal class PostcodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Postcode) || t == typeof(Postcode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Postcode { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Postcode { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type Postcode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Postcode)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type Postcode");
        }

        public static readonly PostcodeConverter Singleton = new PostcodeConverter();
    }

    internal class TitleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Title) || t == typeof(Title?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Madame":
                    return Title.Madame;
                case "Miss":
                    return Title.Miss;
                case "Monsieur":
                    return Title.Monsieur;
                case "Mr":
                    return Title.Mr;
                case "Mrs":
                    return Title.Mrs;
                case "Ms":
                    return Title.Ms;
            }
            throw new Exception("Cannot unmarshal type Title");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Title)untypedValue;
            switch (value)
            {
                case Title.Madame:
                    serializer.Serialize(writer, "Madame");
                    return;
                case Title.Miss:
                    serializer.Serialize(writer, "Miss");
                    return;
                case Title.Monsieur:
                    serializer.Serialize(writer, "Monsieur");
                    return;
                case Title.Mr:
                    serializer.Serialize(writer, "Mr");
                    return;
                case Title.Mrs:
                    serializer.Serialize(writer, "Mrs");
                    return;
                case Title.Ms:
                    serializer.Serialize(writer, "Ms");
                    return;
            }
            throw new Exception("Cannot marshal type Title");
        }

        public static readonly TitleConverter Singleton = new TitleConverter();
    }
}
