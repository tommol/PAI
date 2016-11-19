using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl.lodz.p.ftims.edu.pai.central.entity
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
