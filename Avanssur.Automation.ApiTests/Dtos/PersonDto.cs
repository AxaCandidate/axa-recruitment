using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Avanssur.Automation.ApiTests.Dtos
{
    public class PersonDto
    {
        [DeserializeAs(Name = "birth_year")]
        public string BirthYear { get; set; }

        [DeserializeAs(Name = "eye_color")]
        public string EyeColor { get; set; }

        [DeserializeAs(Name = "films")]
        public List<string> Films { get; set; }

        [DeserializeAs(Name = "gender")]
        public string Gender { get; set; }

        [DeserializeAs(Name = "hair_color")]
        public string HairColor { get; set; }

        [DeserializeAs(Name = "height")]
        public string Height { get; set; }

        [DeserializeAs(Name = "homeworld")]
        public string Homeworld { get; set; }

        [DeserializeAs(Name = "mass")]
        public string Mass { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "skin_color")]
        public string SkinColor { get; set; }

        [DeserializeAs(Name = "created")]
        public string Created { get; set; }

        [DeserializeAs(Name = "edited")]
        public string Edited { get; set; }

        [DeserializeAs(Name = "species")]
        public List<string> Species { get; set; }

        [DeserializeAs(Name = "starships")]
        public List<string> Starships { get; set; }

        [DeserializeAs(Name = "url")]
        public string Url { get; set; }

        [DeserializeAs(Name = "vehicles")]
        public List<string> Vehicles { get; set; }
    }
}
