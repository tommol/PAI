using System;

namespace pl.lodz.p.ftims.edu.pai.branch.dto
{
    public class CreateAudit
    {
        public DateTime Change { get; set; }
        public int PreviousStatus { get; set; }
        public int NewStatus { get; set; }

        public int Operator { get; set; }
        public  int Timesheet { get; set; }
    }
}
