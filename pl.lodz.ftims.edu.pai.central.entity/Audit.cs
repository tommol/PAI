using System;

namespace pl.lodz.p.ftims.edu.pai.central.entity
{
    public class Audit
    {
        public int Id { get; set; }
        public DateTime Change { get; set; }
        public TimesheetStatus PreviousStatus { get; set; }
        public TimesheetStatus NewStatus { get; set; }

        public virtual Employee Operator { get; set; }
        public virtual Timesheet Timesheet { get; set; }
    }
}
