﻿using System.Threading.Tasks;
using EasyMicroservices.Serialization.Newtonsoft.Json.Providers;
using EasyMicroservices.Serialization.Tests.Providers.Models;
using Xunit;

namespace EasyMicroservices.Serialization.Tests.Providers.TextSerialization
{
    public class NewtonsoftJsonSerializationTest : BaseTextSerializationTest
    {
        public NewtonsoftJsonSerializationTest() : base(new NewtonsoftJsonProvider())
        {
        }

        [Theory]
        [InlineData("Mahdi", 30, Gender.Male, "{\"Name\":\"Mahdi\",\"Age\":30,\"Gender\":1}")]
        [InlineData("Maryam", 15, Gender.Female, "{\"Name\":\"Maryam\",\"Age\":15,\"Gender\":2}")]
        [InlineData("ali", 15, Gender.None, "{\"Name\":\"ali\",\"Age\":15,\"Gender\":0}")]
        public override async Task Serilize(string name, int age, Gender gender, string expected)
        {
            await base.Serilize(name, age, gender, expected);
        }
        [InlineData("{\"Name\":\"Mahdi\",\"Age\":30,\"Gender\":1}", "Mahdi", 30, Gender.Male)]
        [InlineData("{\"Name\":\"Maryam\",\"Age\":15,\"Gender\":2}", "Maryam", 15, Gender.Female)]
        [InlineData("{\"Name\":\"ali\",\"Age\":15,\"Gender\":0}", "ali", 15, Gender.None)]
        [Theory]
        public override async Task Deserilize(string json, string name, int age, Gender gender)
        {
            await base.Deserilize(json, name, age, gender);
        }
    }
}
