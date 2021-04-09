using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Core.Entities
{
    public class GenerationVi
    {
        [JsonProperty("omegaruby-alphasapphire")]
        public OmegarubyAlphasapphire OmegarubyAlphasapphire { get; set; }

        [JsonProperty("x-y")]
        public XY XY { get; set; }
    }

}
