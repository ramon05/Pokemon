using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Core.Entities
{
    public class GenerationVii
    {
        public Icons icons { get; set; }

        [JsonProperty("ultra-sun-ultra-moon")]
        public UltraSunUltraMoon UltraSunUltraMoon { get; set; }
    }

}
