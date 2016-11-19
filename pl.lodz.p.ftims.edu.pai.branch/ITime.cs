using pl.lodz.p.ftims.edu.pai.branch.dto;
using System.Collections.Generic;
using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace pl.lodz.p.ftims.edu.pai.branch
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITime
    {

        #region ProjectMethods
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/project/{id}")]
        [Description("Gets specified project")]
        Project GetProject(string id);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/project")]
        [Description("Gets list of all projects")]
        List<Project> GetProjects();

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/employee/{id}/project")]
        [Description("Gets projects managed by specified employee")]
        List<Project> GetManagedProjects(string id);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/project/{id}/timesheets?start={start}&end={end}")]
        [Description("Gets all timesheets for specified project within date range")]
        List<Timesheet> GetProjectTimesheetsForPeriod(string id, string start, string end);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/search/project?query={query}")]
        [Description("Gets all projects with code or name with specified text")]
        List<Project> QueryForProjects(string query);

        

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
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/task")]
        [Description("Gets list of all tasks")]
        List<Task> GetTasks();

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/search/task?query={query}")]
        [Description("Gets list of all tasks containing text in code or name")]
        List<Task> QueryForTaks(string query);

        

        #endregion TaskMethods
        #region EmployeeMethods
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/employee/{id}")]
        [Description("Gets specified employee")]
        Employee GetEmployee(string id);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/employee")]
        [Description("Gets list of all employees")]
        List<Employee> GetEmployees();

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/employee/{id}/subordinate")]
        [Description("Gets list of all subordinates of employee")]
        List<Employee> GetEmployeeSubordinates(string id);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/employee/{id}/timesheet?start={start}&end={end}")]
        [Description("Gets timesheet of specified employee within date range")]
        List<Timesheet> GetEmployeeTimesheetsForPeriod(string id, string start, string end);

       
        #endregion
        #region TimesheetMethods
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/timesheet/{id}")]
        [Description("Gets specified timesheet")]
        Timesheet GetTimesheet(string id);
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/timesheet")]
        [Description("Gets list of all timesheets")]
        List<Timesheet> GetTimesheets();
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/timesheet/employee/{id}")]
        [Description("Gets list of timesheets which needs action made by employee")]
        //TODO
        List<Timesheet> GetTimesheetsNeedAction(string id);
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/timesheet/{id}/history")]
        [Description("Gets history of timesheet")]
        //TODO
        List<Audit> GetTimesheetHistory(string id);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", UriTemplate = "/timesheet")]
        [Description("Adds a timesheet")]
        Timesheet CreateTimesheet(CreateTimesheet createTimesheet);
        [OperationContract]
        [Description("Accept timesheet")]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", UriTemplate = "/timesheet/{id}/action?type=acceptance")]
        //TODO
        Timesheet AcceptTimesheet(string id, CreateAudit createAudit);
        [OperationContract]
        [Description("Reject timesheet")]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", UriTemplate = "/timesheet/{id}/action?type=rejection")]
        //TODO
        Timesheet RejectTimesheet(string id, CreateAudit createAudit);
        #endregion TimesheetMethods
    }


    
}
