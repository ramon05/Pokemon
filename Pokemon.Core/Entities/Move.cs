using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Core.Entities
{
    public class Move
    {
        public Move move { get; set; }
        public List<VersionGroupDetail> version_group_details { get; set; }
    }

}
