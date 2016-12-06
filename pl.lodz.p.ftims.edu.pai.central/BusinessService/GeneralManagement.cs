using System;
using System.Collections.Generic;
using System.Linq;
using pl.lodz.p.ftims.edu.pai.central.dto;
using pl.lodz.p.ftims.edu.pai.central.dal;
using AutoMapper;
using pl.lodz.p.ftims.edu.pai.central.Infrastructure;

namespace pl.lodz.p.ftims.edu.pai.central.BusinessService
{
    public class GeneralManagement : IGeneralManagement
    {
        IUnitOfWork unitOfWork = new EfUnitOfWork();
        IMapper mapper = AutoMapperConfig.MapperConfiguration.CreateMapper();
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
                throw new Exception("Cannot Delete Entity");
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

        public List<Employee> GetEmployeeSubordinates(int id, int start = 0, int limit = 0 )
        {
            var list = limit != 0 ? unitOfWork.EmployeeRepository.GetById(id).Subordinates.Skip(start).Take(limit) : unitOfWork.EmployeeRepository.GetById(id).Subordinates;
            return mapper.Map<IEnumerable<entity.Employee>, List<Employee>>(list);
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
            var project = unitOfWork.ProjectRepository.GetById(id);
            return mapper.Map<Project>(project);
        }

        public Employee GetProjectManager(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjects(int start = 0, int limit = 0)
        {
            var list = limit != 0 ? unitOfWork.ProjectRepository.GetAll().Skip(start).Take(limit) : unitOfWork.ProjectRepository.GetAll();
            return mapper.Map<IEnumerable<entity.Project>, List<Project>>(list);
        }

        public List<Timesheet> GetProjectTimesheets(int projectId, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
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