using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Avanssur.Automation.ApiTests.Dtos
{
    public class PlanetDto
    {
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "rotation_period")]
        public string RotationPeriod { get; set; }

        [DeserializeAs(Name = "orbital_period")]
        public string OrbitalPeriod { get; set; }

        [DeserializeAs(Name = "diameter")]
        public string Diameter { get; set; }

        [DeserializeAs(Name = "climate")]
        public string BirthYear { get; set; }

        [DeserializeAs(Name = "gravity")]
        public string Gravity { get; set; }

        [DeserializeAs(Name = "terrain")]
        public string Terrain { get; set; }

        [DeserializeAs(Name = "surface_water")]
        public string SurfaceWater { get; set; }

        [DeserializeAs(Name = "population")]
        public string Population { get; set; }

        [DeserializeAs(Name = "residents")]
        public List<string> Residents { get; set; }

        [DeserializeAs(Name = "films")]
        public List<string> Films { get; set; }

        [DeserializeAs(Name = "created")]
        public string Created { get; set; }

        [DeserializeAs(Name = "edited")]
        public string Edited { get; set; }

        [DeserializeAs(Name = "url")]
        public string Url { get; set; }
    }
}
