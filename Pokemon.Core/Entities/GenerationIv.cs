using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Core.Entities
{
    public class GenerationIv
    {
        [JsonProperty("diamond-pearl")]
        public DiamondPearl DiamondPearl { get; set; }

        [JsonProperty("heartgold-soulsilver")]
        public HeartgoldSoulsilver HeartgoldSoulsilver { get; set; }
        public Platinum platinum { get; set; }
    }

}
