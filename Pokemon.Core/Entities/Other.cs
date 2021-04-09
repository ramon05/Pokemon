using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Core.Entities
{
    public class Other
    {
        public DreamWorld dream_world { get; set; }

        [JsonProperty("official-artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }
    }

}
