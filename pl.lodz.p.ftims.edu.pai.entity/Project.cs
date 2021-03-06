﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl.lodz.p.ftims.edu.pai.branch.entity
{
    public class Project
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public ProjectType Type { get; set; }

        public virtual List<Entry> Entries { get; set; }
        public virtual Employee ProjectManager { get; set; }
    }
}
