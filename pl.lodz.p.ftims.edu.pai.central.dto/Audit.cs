using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl.lodz.p.ftims.edu.pai.central.dto
{
    public class Audit
    {
        public int Id { get; set; }
        public DateTime Change { get; set; }
        public int PreviousStatus { get; set; }
        public int NewStatus { get; set; }
        public  Employee Operator { get; set; }
       
    }
}
