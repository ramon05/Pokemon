using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Core.Entities
{
    public class GenerationV
    {
        [JsonProperty("black-white")]
        public BlackWhite BlackWhite { get; set; }
    }

}
