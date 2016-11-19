using pl.lodz.p.ftims.edu.pai.branch.dto;
using System;
using System.Collections.Generic;

namespace pl.lodz.p.ftims.edu.pai.branch.BusinessService
{
    public interface ITimeManagementService
    {
        Project GetProject(int id);
        List<Project> GetProjects();
        List<Project> FindProjects(string query);
        List<Project> ProjectsManagedBy(int id);
        Employee GetProjectManager(int id);
        void SetProjectManager(int iprojectId, int employeeId);

        dto.Task GetTask(int id);
        List<dto.Task> GetTasks();
        List<dto.Task> FindTasks(string query);
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
