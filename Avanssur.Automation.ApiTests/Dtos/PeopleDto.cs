using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Avanssur.Automation.ApiTests.Dtos
{
    public class PeopleDto
    {
        [DeserializeAs(Name = "count")]
        public int Count { get; set; }

        [DeserializeAs(Name = "next")]
        public string Next { get; set; }

        [DeserializeAs(Name = "previous")]
        public string Previous { get; set; }

        [DeserializeAs(Name = "results")]
        public List<PersonDto> Results { get; set; }
    }
}
