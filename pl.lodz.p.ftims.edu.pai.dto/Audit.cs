using System;

namespace pl.lodz.p.ftims.edu.pai.branch.dto
{
    public class Audit
    {
        public int Id { get; set; }
        public DateTime Change { get; set; }
        public int PreviousStatus { get; set; }
        public int NewStatus { get; set; }
        public Employee Operator { get; set; }
    }
}
