using pl.lodz.p.ftims.edu.pai.branch.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace pl.lodz.p.ftims.edu.pai.central
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IManagement
    {

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
        Task UpdateTask(string id, Task task);
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
    }


}
