using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl.lodz.p.ftims.edu.pai.dal
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<entity.Timesheet> TimesheetRepository { get; }
        IGenericRepository<entity.Entry> TimeEntryRepository { get; }
        IGenericRepository<entity.Project> ProjectRepository { get; }
        IGenericRepository<entity.Task> TaskRepository { get; }
        IGenericRepository<entity.Employee> EmployeeRepository { get; }
        IGenericRepository<entity.Audit> AuditRepository { get; }

        void Commit();
    }
}
