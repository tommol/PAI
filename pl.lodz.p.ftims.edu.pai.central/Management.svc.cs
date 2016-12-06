using System;
using System.Collections.Generic;
using pl.lodz.p.ftims.edu.pai.central.dto;
using pl.lodz.p.ftims.edu.pai.central.BusinessService;

namespace pl.lodz.p.ftims.edu.pai.central
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Management : IManagement
    {
        private IGeneralManagement businessService;

        public Management(IGeneralManagement businessService)
        {
            this.businessService = businessService;
        }

        public List<Employee> AddSubordinate(string employeeId, string subordinateId)
        {
            throw new NotImplementedException();
        }

        public Employee CreateEmployee(CreateEmployee createEmployee)
        {
            throw new NotImplementedException();
        }

        public Project CreateProject(CreateProject createProject)
        {
            throw new NotImplementedException();
        }

        public Task CreateTask(CreateTask createTask)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> DeleteSubordinate(string employeeId, string subordinateId)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(string id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees(int start = 0, int limit = 0)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeeSubordinates(string id, int start = 0, int limit = 0)
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetEmployeeTimesheetsForPeriod(string id, string start, string end)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetManagedProjects(string id, int start = 0, int limit = 0)
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

        public List<Project> GetProjects(int start = 0, int limit = 0)
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

        public List<Task> GetTasks( int start = 0, int limit = 0)
        {
            throw new NotImplementedException();
        }

        public Timesheet GetTimesheet(string id)
        {
            throw new NotImplementedException();
        }

        public List<Audit> GetTimesheetHistory(string id, int start = 0, int limit = 0)
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetTimesheets(int start = 0, int limit = 0)
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetTimesheetsNeedAction(string id, int start = 0, int limit = 0)
        {
            throw new NotImplementedException();
        }

        public List<Project> QueryForProjects(string query, int start = 0, int limit = 0)
        {
            throw new NotImplementedException();
        }

        public List<Task> QueryForTaks(string query, int start = 0, int limit = 0)
        {
            throw new NotImplementedException();
        }

        public void SetProjectManager(string projectId, string employeeId)
        {
            throw new NotImplementedException();
        }

        public Employee UpdateEmployee(string id, Employee project)
        {
            throw new NotImplementedException();
        }

        public Project UpdateProject(string id, Project project)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTask(string id, Task project)
        {
            throw new NotImplementedException();
        }
    }
}
