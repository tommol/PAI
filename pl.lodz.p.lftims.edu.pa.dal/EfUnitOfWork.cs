using pl.lodz.p.ftims.edu.pai.branch.dal;
using pl.lodz.p.ftims.edu.pai.branch.entity;
using System.Data.Entity;


namespace pl.lodz.p.lftims.edu.pai.branch.dal
{
    public class EfUnitOfWork : DbContext, IUnitOfWork
    {
        private readonly EfGenericRepository<Timesheet> _TimesheetRepo;
        private readonly EfGenericRepository<Entry> _TimeEntryRepo;
        private readonly EfGenericRepository<Project> _ProjectRepo;
        private readonly EfGenericRepository<Task> _TaskRepo;
        private readonly EfGenericRepository<Audit> _AuditRepo;
        private readonly EfGenericRepository<Employee> _EmployeeRepo;

        public DbSet<Timesheet> Timesheets { get; set; }
        public DbSet<Entry> TimeEntries { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Audit> Audits { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public IGenericRepository<Timesheet> TimesheetRepository
        {
            get
            {
                return _TimesheetRepo;
            }
        }

        public IGenericRepository<Entry> TimeEntryRepository
        {
            get
            {
                return _TimeEntryRepo;
            }
        }

        public IGenericRepository<Project> ProjectRepository
        {
            get
            {
                return _ProjectRepo;
            }
        }

        public IGenericRepository<Task> TaskRepository
        {
            get
            {
                return _TaskRepo;
            }
        }

        public IGenericRepository<Employee> EmployeeRepository
        {
            get
            {
                return _EmployeeRepo;
            }
        }

        public IGenericRepository<Audit> AuditRepository
        {
            get
            {
                return _AuditRepo;
            }
        }

        public EfUnitOfWork()
        {
            _TimesheetRepo = new EfGenericRepository<Timesheet>(Timesheets);
            _TimeEntryRepo = new EfGenericRepository<Entry>(TimeEntries);
            _ProjectRepo = new EfGenericRepository<Project>(Projects);
            _TaskRepo = new EfGenericRepository<Task>(Tasks);
            _AuditRepo = new EfGenericRepository<Audit>(Audits);
            _EmployeeRepo = new EfGenericRepository<Employee>(Employees);
        }

        public void Commit()
        {
            this.SaveChanges();
        }
    }
}

