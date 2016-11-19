using System;

namespace pl.lodz.p.ftims.edu.pai.central.entity
{
    public class Entry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }

        public virtual Project Project { get; set; }
        public virtual Task Task { get; set; }

        public virtual Timesheet Timesheet { get; set; }
    }
}
