using pl.lodz.p.ftims.edu.pai.central.dto;
using System.Collections.Generic;
using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace pl.lodz.p.ftims.edu.pai.central
{
    [ServiceContract]
    public interface IManagement
    {

        #region ProjectMethods
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/project/{id}")]
        [Description("Gets specified project")]
        Project GetProject(string id);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/project?start={start}&limit={limit}")]
        [Description("Gets list of all projects")]
        List<Project> GetProjects(int start = 0, int limit = 0);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/employee/{id}/project?start={start}&limit={limit}")]
        [Description("Gets projects managed by specified employee")]
        List<Project> GetManagedProjects(string id, int start = 0, int limit = 0);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/project/{id}/timesheets?start={start}&end={end}")]
        [Description("Gets all timesheets for specified project within date range")]
        List<Timesheet> GetProjectTimesheetsForPeriod(string id, string start, string end);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/search/project?query={query}&start={start}&limit={limit}")]
        [Description("Gets all projects with code or name with specified text")]
        List<Project> QueryForProjects(string query, int start = 0, int limit = 0);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", UriTemplate = "/project")]
        [Description("Adds new project ")]
        Project CreateProject(CreateProject createProject);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "DELETE", UriTemplate = "/project/{id}")]
        [Description("Deletes a project")]
        void DeleteProject(string id);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "PUT", UriTemplate = "/project/{id}")]
        [Description("Updates a project")]
        Project UpdateProject(string id, Project project);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "PUT", UriTemplate = "/project/{projectId}/manager/{employeeId}")]
        [Description("Sets manager of specified project")]
        void SetProjectManager(string projectId, string employeeId);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/project/{projectId}/manager")]
        [Description("Gets manager of specified project")]
        Employee GetProjectManager(string projectId);

        #endregion ProjectMethods
        #region TaskMethods
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/task/{id}")]
        [Description("Gets specified task")]
        Task GetTask(string id);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/task?start={start}&limit={limit}")]
        [Description("Gets list of all tasks")]
        List<Task> GetTasks(int start = 0, int limit = 0);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/search/task?query={query}&start={start}&limit={limit}")]
        [Description("Gets list of all tasks containing text in code or name")]
        List<Task> QueryForTaks(string query, int start = 0, int limit = 0);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", UriTemplate = "/task")]
        [Description("Adds a task")]
        Task CreateTask(CreateTask createTask);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "DELETE", UriTemplate = "/task/{id}")]
        [Description("Deletes a task")]
        void DeleteTask(string id);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "PUT", UriTemplate = "/task/{id}")]
        [Description("Updates a task")]
        Task UpdateTask(string id, Task project);

        #endregion TaskMethods
        #region EmployeeMethods
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/employee/{id}")]
        [Description("Gets specified employee")]
        Employee GetEmployee(string id);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/employee?start={start}&limit={limit}")]
        [Description("Gets list of all employees")]
        List<Employee> GetEmployees(int start = 0, int limit = 0);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/employee/{id}/subordinate?start={start}&limit={limit}")]
        [Description("Gets list of all subordinates of employee")]
        List<Employee> GetEmployeeSubordinates(string id, int start = 0, int limit = 0);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/employee/{id}/timesheet?start={start}&end={end}")]
        [Description("Gets timesheet of specified employee within date range")]
        List<Timesheet> GetEmployeeTimesheetsForPeriod(string id, string start, string end);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", UriTemplate = "/employee")]
        [Description("Adds an employee")]
        Employee CreateEmployee(CreateEmployee createEmployee);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "DELETE", UriTemplate = "/employee/{id}")]
        [Description("Deletes an employee")]
        void DeleteEmployee(string id);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "PUT", UriTemplate = "/employee/{id}")]
        [Description("Updates an employee")]
        Employee UpdateEmployee(string id, Employee project);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", UriTemplate = "/employee/{employeeId}/subordinate/{subordinateId}")]
        [Description("Adds a subordinate for specified employee")]
        List<Employee> AddSubordinate(string employeeId, string subordinateId);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "DELETE", UriTemplate = "/employee/{employeeId}/subordinate/{subordinateId}")]
        [Description("Removes a subordinate for specified employee")]
        List<Employee> DeleteSubordinate(string employeeId, string subordinateId);
        #endregion
        #region TimesheetMethods
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/timesheet/{id}")]
        [Description("Gets specified timesheet")]
        Timesheet GetTimesheet(string id);
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/timesheet?start={start}&limit={limit}")]
        [Description("Gets list of all timesheets")]
        List<Timesheet> GetTimesheets(int start = 0, int limit = 0);
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/timesheet/employee/{id}?start={start}&limit={limit}")]
        [Description("Gets list of timesheets which needs action made by employee")]
        List<Timesheet> GetTimesheetsNeedAction(string id, int start = 0, int limit = 0);
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/timesheet/{id}/history?start={start}&limit={limit}")]
        [Description("Gets history of timesheet")]
        List<Audit> GetTimesheetHistory(string id, int start = 0, int limit = 0);


        #endregion TimesheetMethods
        #region BranchMethods
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/branch/{id}")]
        [Description("Gets specified branch")]
        Branch GetBranch(string id);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/branch?start={start}&limit={limit}")]
        [Description("Gets list of all branches")]
        List<Branch> GetBranchess(int start = 0, int limit = 0);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", UriTemplate = "/branch")]
        [Description("Adds new branch ")]
        Branch CreateBranch(CreateBranch createBranch);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "DELETE", UriTemplate = "/branch/{id}")]
        [Description("Deletes a branch")]
        void DeleteBranch(string id);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "PUT", UriTemplate = "/branch/{id}")]
        [Description("Updates a branch")]
        Branch UpdateProject(string id, Branch project);

        #endregion BranchMethods

    }

}