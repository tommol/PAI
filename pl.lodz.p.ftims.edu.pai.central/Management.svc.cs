using System;
using System.Collections.Generic;
using pl.lodz.p.ftims.edu.pai.central.dto;
using pl.lodz.p.ftims.edu.pai.central.BusinessService;

namespace pl.lodz.p.ftims.edu.pai.central
{
    public class Management : IManagement
    {
        private IGeneralManagement businessService;

        public Management(IGeneralManagement businessService)
        {
            this.businessService = businessService;
        }

        public List<Employee> AddSubordinate(string employeeId, string subordinateId)
        {
            int empId = int.Parse(employeeId);
            int subId = int.Parse(subordinateId);
            return businessService.AddSubordinate(empId, subId);
        }

        public Branch CreateBranch(CreateBranch createBranch)
        {
            return businessService.CreateBranch(createBranch);
        }

        public Employee CreateEmployee(CreateEmployee createEmployee)
        {
            return businessService.CreateEmployee(createEmployee);
        }

        public Project CreateProject(CreateProject createProject)
        {
            return businessService.CreateProject(createProject);
        }

        public Task CreateTask(CreateTask createTask)
        {
            return businessService.CreateTask(createTask);
        }

        public void DeleteBranch(string id)
        {
            int branchId = int.Parse(id);
            businessService.DeleteBranch(branchId);
        }

        public void DeleteEmployee(string id)
        {
            int employeeId = int.Parse(id);
            businessService.DeleteEmployee(employeeId);
        }

        public void DeleteProject(string id)
        {
            int projectId = int.Parse(id);
            businessService.DeleteProject(projectId);
        }

        public List<Employee> DeleteSubordinate(string employeeId, string subordinateId)
        {
            int empId = int.Parse(employeeId);
            int subId = int.Parse(subordinateId);
            return businessService.DeleteSubordinate(empId, subId);
        }

        public void DeleteTask(string id)
        {
            int taskId = int.Parse(id);
            businessService.DeleteTask(taskId);
        }

        public Branch GetBranch(string id)
        {
            int branchId = int.Parse(id);
            return businessService.GetBranch(branchId);
        }

        public List<Branch> GetBranchess(int start = 0, int limit = 0)
        {
            return businessService.GetBranches(start, limit);
        }

        public Employee GetEmployee(string id)
        {
            int employeeId = int.Parse(id);
            return businessService.GetEmployee(employeeId);
        }

        public List<Employee> GetEmployees(int start = 0, int limit = 0)
        {
            return businessService.GetEmployees(start, limit);
        }

        public List<Employee> GetEmployeeSubordinates(string id, int start = 0, int limit = 0)
        {
            int employeeId = int.Parse(id);
            return businessService.GetEmployeeSubordinates(employeeId, start, limit);
        }

        public List<Timesheet> GetEmployeeTimesheetsForPeriod(string id, string start, string end)
        {
            int employeeId = int.Parse(id);
            DateTime? startDate = null;
            DateTime? endDate = null;
            if (start != string.Empty)
            {
                startDate = DateTime.Parse(start);
            }
            if (end != string.Empty)
            {
                endDate = DateTime.Parse(end);
            }
            return businessService.GetEmployeeTimesheets(employeeId, startDate, endDate);
        }

        public List<Project> GetManagedProjects(string id, int start = 0, int limit = 0)
        {
            int employeeId = int.Parse(id);
            return businessService.ProjectsManagedBy(employeeId);
        }

        public Project GetProject(string id)
        {
            int projectId = int.Parse(id);
            return businessService.GetProject(projectId);
        }

        public Employee GetProjectManager(string projectId)
        {
            int id = int.Parse(projectId);
            return businessService.GetProjectManager(id);
        }

        public List<Project> GetProjects(int start = 0, int limit = 0)
        {
            return businessService.GetProjects(start, limit);
        }

        public List<Timesheet> GetProjectTimesheetsForPeriod(string id, string start, string end)
        {
            int projectId = int.Parse(id);
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);
            return businessService.GetProjectTimesheets(projectId, startDate, endDate);
        }

        public Task GetTask(string id)
        {
            int taskId = int.Parse(id);
            return businessService.GetTask(taskId);
        }

        public List<Task> GetTasks(int start = 0, int limit = 0)
        {
            return businessService.GetTasks(start, limit);
        }

        public Timesheet GetTimesheet(string id)
        {
            int timesheetId = int.Parse(id);
            return businessService.GetTimesheet(timesheetId);
        }

        public List<Audit> GetTimesheetHistory(string id, int start = 0, int limit = 0)
        {
            return businessService.GetHistory(int.Parse(id));
        }

        public List<Timesheet> GetTimesheets(int start = 0, int limit = 0)
        {
            return businessService.GetTimesheets(start, limit);
        }

        public List<Timesheet> GetTimesheetsNeedAction(string id, int start = 0, int limit = 0)
        {
           return businessService.GetTimesheetNeedsAction(int.Parse(id), start, limit);
        }

        public List<Project> QueryForProjects(string query, int start = 0, int limit = 0)
        {
            return businessService.FindProjects(query, start, limit);
        }

        public List<Task> QueryForTaks(string query, int start = 0, int limit = 0)
        {
            return businessService.FindTasks(query, start, limit);
        }

        public void SetProjectManager(string projectId, string employeeId)
        {
            int empId = int.Parse(employeeId);
            int projId = int.Parse(projectId);
            businessService.SetProjectManager(projId, empId);
        }

        public Employee UpdateEmployee(string id, Employee project)
        {
            int employeeId = int.Parse(id);
            return businessService.UpdateEmployee(employeeId, project);
        }

        public Branch UpdateBranch(string id, Branch project)
        {
            int branchId = int.Parse(id);
            return businessService.UpdateBranch(branchId, project);
        }

        public Project UpdateProject(string id, Project project)
        {
            int projectId = int.Parse(id);
            return businessService.UpdateProject(projectId, project);
        }

        public Task UpdateTask(string id, Task project)
        {
            int taskId = int.Parse(id);
            return businessService.UpdateTask(taskId, project);
        }

        public Employee GetEmployeeManager(string id)
        {
            return businessService.GetEmployeeManager(int.Parse(id));
        }

        public List<Timesheet> GetTimesheetsNeedAction(string id)
        {
            return businessService.GetTimesheetNeedsAction(int.Parse(id), 0, 0);
        }

        public Timesheet CreateTimesheet(CreateTimesheet createTimesheet)
        {
            return businessService.CreateTimesheet(createTimesheet);
        }

        public Timesheet AcceptTimesheet(string id, string employeeId)
        {
            return businessService.AcceptTimesheet(int.Parse(id), int.Parse(employeeId));
        }

        public Timesheet RejectTimesheet(string id, string employeeId)
        {
            return businessService.RejectTimesheet(int.Parse(id), int.Parse(employeeId));
        }
    }
}
