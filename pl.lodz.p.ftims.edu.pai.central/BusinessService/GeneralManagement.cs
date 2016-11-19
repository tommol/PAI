using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pl.lodz.p.ftims.edu.pai.central.dto;

namespace pl.lodz.p.ftims.edu.pai.central.BusinessService
{
    public class GeneralManagement : IGeneralManagement
    {
        public List<Employee> AddSubordinate(int employeeId, int subordinateId)
        {
            throw new NotImplementedException();
        }

        public Employee CreateEmployee(CreateEmployee employee)
        {
            throw new NotImplementedException();
        }

        public Project CreateProject(CreateProject project)
        {
            throw new NotImplementedException();
        }

        public Task CreateTask(CreateTask task)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> DeleteSubordinate(int employeeId, int subordinateId)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> FindProjects(string query)
        {
            throw new NotImplementedException();
        }

        public List<Task> FindTasks(string query)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployeeSubordinates(int id)
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetEmployeeTimesheets(int employeeId, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GeTimesheets()
        {
            throw new NotImplementedException();
        }

        public Project GetProject(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetProjectManager(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjects()
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GetProjectTimesheets(int projectId, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task GetTask(int id)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetTasks()
        {
            throw new NotImplementedException();
        }

        public Timesheet GetTimesheet(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> ProjectsManagedBy(int id)
        {
            throw new NotImplementedException();
        }

        public void SetProjectManager(int iprojectId, int employeeId)
        {
            throw new NotImplementedException();
        }

        public Employee UpdateEmployee(int id, Employee task)
        {
            throw new NotImplementedException();
        }

        public Project UpdateProject(int id, Project project)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTask(int id, Task task)
        {
            throw new NotImplementedException();
        }
    }
}