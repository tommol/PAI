using pl.lodz.p.ftims.edu.pai.branch.dto;
using System;
using System.Collections.Generic;

namespace pl.lodz.p.ftims.edu.pai.branch
{
    public interface ITimeManagementService
    {
        Project GetProject(int id);
        List<Project> GetProjects(int start = 0, int limit = 0);
        List<Project> FindProjects(string query, int start = 0, int limit = 0);
        List<Project> ProjectsManagedBy(int id);
        Employee GetProjectManager(int id);
        void SetProjectManager(int iprojectId, int employeeId);

        dto.Task GetTask(int id);
        List<dto.Task> GetTasks(int start = 0, int limit = 0);
        List<dto.Task> FindTasks(string query, int start = 0, int limit = 0);
        Employee GetEmployee(int id);
        List<Employee> GetEmployees();
        List<Employee> GetEmployeeSubordinates(int id);
        List<Timesheet> GetProjectTimesheets(int projectId, DateTime start, DateTime end);
        List<Timesheet> GetEmployeeTimesheets(int employeeId, DateTime start, DateTime end);

        Timesheet CreateTimesheet(CreateTimesheet task);
        Timesheet GetTimesheet(int id);
        List<Timesheet> GeTimesheets();
        void DeleteTimesheet(int id);
        Timesheet UpdateTimesheet(int id, Timesheet timesheet);
    }
}
