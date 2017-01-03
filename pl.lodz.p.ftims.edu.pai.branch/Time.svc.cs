using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using pl.lodz.p.ftims.edu.pai.branch.dto;


namespace pl.lodz.p.ftims.edu.pai.branch
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Time : ITime
    {
        private ITimeManagementService businessService;

        public Time(ITimeManagementService businessService)
        {
            this.businessService = businessService;
        }

        public Timesheet AcceptTimesheet(string id, CreateAudit createAudit)
        {
            throw new NotImplementedException();
        }

        public Timesheet CreateTimesheet(CreateTimesheet createTimesheet)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeeSubordinates(string id)
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetEmployeeTimesheetsForPeriod(string id, string start, string end)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetManagedProjects(string id)
        {
            throw new NotImplementedException();
        }

        public Project GetProject(string id)
        {
            throw new NotImplementedException();
        }

        public Employee GetProjectManager(string projectId)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjects()
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetProjectTimesheetsForPeriod(string id, string start, string end)
        {
            throw new NotImplementedException();
        }

        public Task GetTask(string id)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetTasks()
        {
            throw new NotImplementedException();
        }

        public Timesheet GetTimesheet(string id)
        {
            throw new NotImplementedException();
        }

        public List<Audit> GetTimesheetHistory(string id)
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetTimesheets()
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetTimesheetsNeedAction(string id)
        {
            throw new NotImplementedException();
        }

        public List<Project> QueryForProjects(string query)
        {
            throw new NotImplementedException();
        }

        public List<Task> QueryForTaks(string query)
        {
            throw new NotImplementedException();
        }

        public Timesheet RejectTimesheet(string id, CreateAudit createAudit)
        {
            throw new NotImplementedException();
        }
    }
}
