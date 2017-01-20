using System;
using System.Collections.Generic;

namespace pl.lodz.p.ftims.edu.pai.central.entity
{
    public class Timesheet
    {
        public Timesheet()
        {

        }
        public int Id { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public TimesheetStatus Status { get; set; }
        public virtual List<Entry> Entries { get; set; }
        public virtual Employee Applicant { get; set; }
        public virtual List<Audit> AuditData { get; set; }
    }
}
