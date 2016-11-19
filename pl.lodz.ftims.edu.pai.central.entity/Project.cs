using System.Collections.Generic;

namespace pl.lodz.p.ftims.edu.pai.central.entity
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
