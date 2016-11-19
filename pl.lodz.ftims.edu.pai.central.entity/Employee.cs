using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl.lodz.p.ftims.edu.pai.central.entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual List<Timesheet> Timesheets { get; set; }
        public virtual List<Project> ManagingProjects { get; set; }
        public virtual List<Employee> Subordinates { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual List<Audit> Actions { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
