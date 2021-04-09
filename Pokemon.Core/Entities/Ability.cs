using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Core.Entities
{
    public class Ability
    {
        public Ability ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

}
