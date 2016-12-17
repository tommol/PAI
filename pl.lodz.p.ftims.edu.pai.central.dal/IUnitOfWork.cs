using pl.lodz.p.ftims.edu.pai.central.entity;
using System;

namespace pl.lodz.p.ftims.edu.pai.central.dal
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Timesheet> TimesheetRepository { get; }
        IGenericRepository<Entry> TimeEntryRepository { get; }
        IGenericRepository<Project> ProjectRepository { get; }
        IGenericRepository<Task> TaskRepository { get; }
        IGenericRepository<Employee> EmployeeRepository { get; }
        IGenericRepository<Audit> AuditRepository { get; }
        IGenericRepository<Branch> BranchRepository { get; }

        void Commit();
    }
}
