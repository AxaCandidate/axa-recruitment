using Avanssur.Automation.ApiTests.Dtos;
using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanssur.Automation.ApiTests.Tests.Swapi
{
    public class SwapiTests : BaseTest
    {
        [Test]
        public void GetLukeSkywalkerFromPeopleAndGetHisPlanet_HappyPath_PlanetNameIsTatooine()
        {
            // Arrange
            var client = new RestClient();

            // Act
            var peopleRequest = new RestRequest(BaseUrlApi + "/people", Method.GET);
            var peopleResponse = client.Execute(peopleRequest);
            
            var people = new JsonSerializer().Deserialize<PeopleDto>(peopleResponse);
            var lukeSkywalker = people.Results
                                        .Where(p => p.Name == "Luke Skywalker")
                                        .FirstOrDefault();

            var planetRequest = new RestRequest(lukeSkywalker.Homeworld, Method.GET);
            var planetResponse = client.Execute(planetRequest);

            var planet = new JsonSerializer().Deserialize<PlanetDto>(planetResponse);

            // Assert
            planet.Name.Should().BeEquivalentTo("Tatooine");
            Log.Information("Tatooine is a planet of Luke Skywalker");
        }
    }
}
