using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Core.Entities
{
    public class GenerationI
    {
        [JsonProperty("red-blue")]
        public RedBlue RedBlue { get; set; }
        public Yellow yellow { get; set; }
    }

}
