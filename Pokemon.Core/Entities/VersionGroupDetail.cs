﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Core.Entities
{
    public class VersionGroupDetail
    {
        public int level_learned_at { get; set; }
        public MoveLearnMethod move_learn_method { get; set; }
        public VersionGroup version_group { get; set; }
    }

}
