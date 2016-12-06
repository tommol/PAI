using pl.lodz.p.ftims.edu.pai.central.dto;
using System;
using System.Collections.Generic;

namespace pl.lodz.p.ftims.edu.pai.central.BusinessService
{
    public interface IGeneralManagement
    {
        Project CreateProject(CreateProject project);
        Project GetProject(int id);
        List<Project> GetProjects(int start = 0, int limit = 0);
        void DeleteProject(int id);
        Project UpdateProject(int id, Project project);
        List<Project> FindProjects(string query, int start = 0, int limit = 0);
        List<Project> ProjectsManagedBy(int id);
        Employee GetProjectManager(int id);
        void SetProjectManager(int iprojectId, int employeeId);

        dto.Task CreateTask(CreateTask task);
        dto.Task GetTask(int id);
        List<dto.Task> GetTasks(int start = 0, int limit = 0);
        void DeleteTask(int id);
        dto.Task UpdateTask(int id, dto.Task task);
        List<dto.Task> FindTasks(string query, int start = 0, int limit = 0);
        Employee CreateEmployee(CreateEmployee employee);
        Employee GetEmployee(int id);
        List<Employee> GetEmployees(int start = 0, int limit = 0);
        void DeleteEmployee(int id);
        Employee UpdateEmployee(int id, Employee task);
        List<Employee> GetEmployeeSubordinates(int id, int start = 0, int limit = 0);
        List<Employee> AddSubordinate(int employeeId, int subordinateId);
        List<Employee> DeleteSubordinate(int employeeId, int subordinateId);
        List<Timesheet> GetProjectTimesheets(int projectId, DateTime start, DateTime end);
        List<Timesheet> GetEmployeeTimesheets(int employeeId, DateTime start, DateTime end);
        Timesheet GetTimesheet(int id);
        List<Timesheet> GeTimesheets();
    }
}
