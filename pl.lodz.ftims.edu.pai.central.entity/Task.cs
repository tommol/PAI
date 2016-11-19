using System.Collections.Generic;

namespace pl.lodz.p.ftims.edu.pai.central.entity
{
    public class Task
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual List<Entry> Entries { get; set; }
    }
}
