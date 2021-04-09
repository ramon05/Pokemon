using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Core.Entities
{
    public class GenerationIii
    {
        public Emerald emerald { get; set; }

        [JsonProperty("firered-leafgreen")]
        public FireredLeafgreen FireredLeafgreen { get; set; }

        [JsonProperty("ruby-sapphire")]
        public RubySapphire RubySapphire { get; set; }
    }

}
