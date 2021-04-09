using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Core.Entities
{
    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat stat { get; set; }
    }

}
