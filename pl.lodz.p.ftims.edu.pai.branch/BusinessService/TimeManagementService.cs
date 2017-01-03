using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pl.lodz.p.ftims.edu.pai.branch.dto;
using pl.lodz.p.lftims.edu.pai.branch.dal;
using pl.lodz.p.ftims.edu.pai.branch.dal;
using AutoMapper;
using pl.lodz.p.ftims.edu.pai.branch.Infrastructure;
using pl.lodz.p.ftims.edu.pai.central.Exceptions;

namespace pl.lodz.p.ftims.edu.pai.branch
{
    public class TimeManagementService : ITimeManagementService
    {
        IUnitOfWork unitOfWork = new EfUnitOfWork();
        IMapper mapper = AutoMapperConfig.MapperConfiguration.CreateMapper();

         public Project GetProject(int id)
        {
            var project = unitOfWork.ProjectRepository.GetById(id);
            return mapper.Map<Project>(project);
        }

        public Employee GetProjectManager(int id)
        {
            var employee = unitOfWork.ProjectRepository.GetById(id).ProjectManager;
            return mapper.Map<Employee>(employee);
        }

        public List<Project> GetProjects(int start = 0, int limit = 0)
        {
            var list = limit != 0 ? unitOfWork.ProjectRepository.GetAll().Skip(start).Take(limit) : unitOfWork.ProjectRepository.GetAll();
            return mapper.Map<IEnumerable<entity.Project>, List<Project>>(list);
        }

        public List<Timesheet> GetProjectTimesheets(int projectId, DateTime start, DateTime end)
        {
            var list = unitOfWork.TimesheetRepository.Find(x => x.Entries.Any(y => y.Project.Id == projectId) && (x.StartDay >= start && x.EndDay <= end));
            return mapper.Map<IEnumerable<entity.Timesheet>, List<Timesheet>>(list);
        }

        public Task GetTask(int id)
        {
            var task = unitOfWork.TaskRepository.GetById(id);
            return mapper.Map<Task>(task);
        }

        public List<Task> GetTasks(int start = 0, int limit = 0)
        {
            var list = limit != 0 ? unitOfWork.TaskRepository.GetAll().Skip(start).Take(limit) : unitOfWork.TaskRepository.GetAll();
            return mapper.Map<IEnumerable<entity.Task>, List<Task>>(list);
        }


        public List<Project> ProjectsManagedBy(int id)
        {
            var list = unitOfWork.ProjectRepository.Find(x => x.ProjectManager.Id == id);
            return mapper.Map<IEnumerable<entity.Project>, List<Project>>(list);
        }

        public void SetProjectManager(int iprojectId, int employeeId)
        {
            var project = unitOfWork.ProjectRepository.GetById(iprojectId);
            var manager = unitOfWork.EmployeeRepository.GetById(employeeId);
            project.ProjectManager = manager;
            unitOfWork.Commit();
        }
        public List<Project> FindProjects(string query)
        {
            throw new NotImplementedException();
        }

        public List<Project> FindProjects(string query, int start = 0, int limit = 0)
        {
            var list = limit != 0 ? unitOfWork.ProjectRepository.Find(t => t.Name.Contains(query) || t.Code.Contains(query)).Skip(start).Take(limit) : unitOfWork.ProjectRepository.Find(t => t.Name.Contains(query) || t.Code.Contains(query));
            return mapper.Map<IEnumerable<entity.Project>, List<Project>>(list);
        }

        public List<Task> FindTasks(string query, int start = 0, int limit = 0)
        {
            var list = limit != 0 ? unitOfWork.TaskRepository.Find(t => t.Name.Contains(query) || t.Code.Contains(query)).Skip(start).Take(limit) : unitOfWork.TaskRepository.Find(t => t.Name.Contains(query) || t.Code.Contains(query));
            return mapper.Map<IEnumerable<entity.Task>, List<Task>>(list);
        }

        public Employee GetEmployee(int id)
        {
            var employee = unitOfWork.EmployeeRepository.GetById(id);
            return mapper.Map<Employee>(employee);
        }

        public List<Employee> GetEmployees(int start = 0, int limit = 0)
        {
            var list = limit != 0 ? unitOfWork.EmployeeRepository.GetAll().Skip(start).Take(limit) : unitOfWork.EmployeeRepository.GetAll();
            return mapper.Map<IEnumerable<entity.Employee>, List<Employee>>(list);
        }



        public List<Employee> GetEmployeeSubordinates(int id)
        {
            throw new NotImplementedException();
        }
        public List<Employee> AddSubordinate(int employeeId, int subordinateId)
        {
            var subordinate = unitOfWork.EmployeeRepository.GetById(subordinateId);
            var employee = unitOfWork.EmployeeRepository.GetById(employeeId);
            employee.Subordinates.Add(subordinate);
            unitOfWork.Commit();
            return mapper.Map<IEnumerable<entity.Employee>, List<Employee>>(employee.Subordinates);
        }

        public Employee CreateEmployee(CreateEmployee employee)
        {
            entity.Employee entity = mapper.Map<entity.Employee>(employee);
            unitOfWork.EmployeeRepository.Add(entity);
            unitOfWork.Commit();
            return mapper.Map<dto.Employee>(entity);
        }

        public Project CreateProject(CreateProject project)
        {
            entity.Project entity = mapper.Map<entity.Project>(project);
            unitOfWork.ProjectRepository.Add(entity);
            unitOfWork.Commit();
            return mapper.Map<dto.Project>(entity);
        }

        public Task CreateTask(CreateTask task)
        {
            entity.Task entity = mapper.Map<entity.Task>(task);
            unitOfWork.TaskRepository.Add(entity);
            unitOfWork.Commit();
            return mapper.Map<dto.Task>(entity);
        }

        public void DeleteEmployee(int id)
        {
            var employee = unitOfWork.EmployeeRepository.GetById(id);
            if (employee.Subordinates.Count > 0)
            {
                throw new CannotDeleteEmployeeException("Cannot delete employee with assigned subordinates. Please Rrmove relation than retry");
            }
            unitOfWork.EmployeeRepository.Delete(employee);
            unitOfWork.Commit();
        }

        public void DeleteProject(int id)
        {
            var project = unitOfWork.ProjectRepository.GetById(id);
            if (project.ProjectManager != null)
            {
                throw new Exception("Cannot Delete Entity");
            }
            unitOfWork.ProjectRepository.Delete(project);
            unitOfWork.Commit();
        }

        public List<Employee> DeleteSubordinate(int employeeId, int subordinateId)
        {
            var subordinate = unitOfWork.EmployeeRepository.GetById(subordinateId);
            var employee = unitOfWork.EmployeeRepository.GetById(employeeId);
            employee.Subordinates.Remove(subordinate);
            unitOfWork.Commit();
            return mapper.Map<IEnumerable<entity.Employee>, List<Employee>>(employee.Subordinates);
        }

        public void DeleteTask(int id)
        {
            var task = unitOfWork.TaskRepository.GetById(id);
            if (task.Entries.Count > 0)
            {
                throw new Exception("Cannot Delete Entity");
            }
            unitOfWork.TaskRepository.Delete(task);
            unitOfWork.Commit();
        }

       

        public List<Employee> GetEmployeeSubordinates(int id, int start = 0, int limit = 0)
        {
            var list = limit != 0 ? unitOfWork.EmployeeRepository.GetById(id).Subordinates.Skip(start).Take(limit) : unitOfWork.EmployeeRepository.GetById(id).Subordinates;
            return mapper.Map<IEnumerable<entity.Employee>, List<Employee>>(list);
        }

        public List<Timesheet> GetEmployeeTimesheets(int employeeId, DateTime start, DateTime end)
        {
            var list = unitOfWork.TimesheetRepository.Find(x => x.Applicant.Id == employeeId && (x.StartDay >= start && x.EndDay <= end));
            return mapper.Map<IEnumerable<entity.Timesheet>, List<Timesheet>>(list);
        }

        public List<Timesheet> GetTimesheets(int start = 0, int limit = 0)
        {
            var list = limit != 0 ? unitOfWork.TimesheetRepository.GetAll().Skip(start).Take(limit) : unitOfWork.TimesheetRepository.GetAll();
            return mapper.Map<IEnumerable<entity.Timesheet>, List<Timesheet>>(list);
        }

             

        public Timesheet GetTimesheet(int id)
        {
            var timesheet = unitOfWork.TimesheetRepository.GetById(id);
            return mapper.Map<Timesheet>(timesheet);
        }

       

        public Employee UpdateEmployee(int id, Employee employee)
        {
            var employeeEntity = unitOfWork.EmployeeRepository.GetById(id);
            employeeEntity.LastName = employee.LastName;
            employeeEntity.Name = employee.Name;
            employeeEntity.Email = employee.Email;
            unitOfWork.Commit();
            return mapper.Map<Employee>(employeeEntity);
        }

        public Project UpdateProject(int id, Project project)
        {
            var projectEntity = unitOfWork.ProjectRepository.GetById(id);
            projectEntity.Code = project.Code;
            projectEntity.Name = project.Name;
            projectEntity.Type = (entity.ProjectType)project.Type;
            return mapper.Map<Project>(projectEntity);
        }

        public Task UpdateTask(int id, Task task)
        {
            var taskEntity = unitOfWork.TaskRepository.GetById(id);
            taskEntity.Code = task.Code;
            taskEntity.Name = task.Name;
            return mapper.Map<Task>(taskEntity);
        }

        

        public List<Timesheet> GetTimesheetNeedsAction(int start = 0, int limit = 0)
        {
            var list = limit != 0 ? unitOfWork.TimesheetRepository.GetAll().Where(t => t.AuditData.Any(a => a.NewStatus == entity.TimesheetStatus.Submitted)).Skip(start).Take(limit) : unitOfWork.TimesheetRepository.GetAll().Where(t => t.AuditData.Any(a => a.NewStatus == entity.TimesheetStatus.Submitted));
            return mapper.Map<IEnumerable<entity.Timesheet>, List<Timesheet>>(list);
        }

        public List<Project> GetProjects()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public Timesheet CreateTimesheet(CreateTimesheet task)
        {
            throw new NotImplementedException();
        }

        public List<Timesheet> GeTimesheets()
        {
            throw new NotImplementedException();
        }

        public void DeleteTimesheet(int id)
        {
            throw new NotImplementedException();
        }

        public Timesheet UpdateTimesheet(int id, Timesheet timesheet)
        {
            throw new NotImplementedException();
        }
    }
}