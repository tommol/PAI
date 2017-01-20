using Microsoft.AspNet.Identity.Owin;
using pl.lodz.p.ftims.edu.pai.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pl.lodz.p.ftims.edu.pai.web.Controllers
{
    public class TimesheetController : Controller
    {
        private ApplicationUserManager _userManager;
        private ApplicationRoleManager _roleManager;

        public TimesheetController()
        {

        }
        public TimesheetController(ApplicationRoleManager roleManager, ApplicationUserManager userManager)
        {
            _userManager = UserManager;
            _roleManager = RoleManager;
        }
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        // GET: Timesheet
        [Authorize(Roles = "EMPLOYEE")]
        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            var currentUser = await UserManager.FindByNameAsync(User.Identity.Name);

            TimesheetService.ManagementClient client = new TimesheetService.ManagementClient();
            TimesheetService.Timesheet[] timesheets = client.GetEmployeeTimesheetsForPeriod(currentUser.ApiId.ToString(), string.Empty, string.Empty);
            var model = timesheets.Select(t => new TimesheetListItemViewModel() { Id = t.Id, EndPeriod = t.EndDay, StartPeriod = t.StartDay, status = t.Status });


            return View(model);
        }
        [Authorize(Roles = "MANAGER")]
        public async System.Threading.Tasks.Task<ActionResult> Review()
        {
            var currentUser = await UserManager.FindByNameAsync(User.Identity.Name);

            TimesheetService.ManagementClient client = new TimesheetService.ManagementClient();
            TimesheetService.Timesheet[] timesheets = client.GetTimesheetsNeedAction(currentUser.ApiId.ToString(), 0, 0);
            var model = timesheets.Select(t => new TimesheetListItemViewModel() { Id = t.Id, EndPeriod = t.EndDay, StartPeriod = t.StartDay, status = t.Status });


            return View(model);
        }

        [Authorize(Roles = "EMPLOYEE")]
        [HttpGet]
        public async System.Threading.Tasks.Task<ActionResult> Step1()
        {
            CreateTimesheetStep1ViewModel model = new CreateTimesheetStep1ViewModel();
            var today = DateTime.Now;
            switch (today.DayOfWeek)
            {
                case DayOfWeek.Tuesday:
                    model.StartPeriod = today.AddDays(6);
                    break;
                case DayOfWeek.Wednesday:
                    model.StartPeriod = today.AddDays(5);
                    break;
                case DayOfWeek.Thursday:
                    model.StartPeriod = today.AddDays(4);
                    break;
                case DayOfWeek.Friday:
                    model.StartPeriod = today.AddDays(3);
                    break;
                case DayOfWeek.Saturday:
                    model.StartPeriod = today.AddDays(2);
                    break;
                case DayOfWeek.Sunday:
                    model.StartPeriod = today.AddDays(1);
                    break;
                case DayOfWeek.Monday:
                    model.StartPeriod = today;
                    break;

            }
            model.EndPeriod = model.StartPeriod.AddDays(6);
            var currentUser = await UserManager.FindByNameAsync(User.Identity.Name);
            model.Owner = currentUser.ApiId;
            return View(model);
        }
        [Authorize(Roles = "EMPLOYEE")]
        [HttpPost]
        public ActionResult Step2(CreateTimesheetStep1ViewModel model)
        {
            CreateTimesheetStep2ViewModel createModel = new CreateTimesheetStep2ViewModel();
            createModel.StartPeriod = model.StartPeriod;
            createModel.EndPeriod = model.EndPeriod;
            createModel.Owner = model.Owner;
            TimesheetEntry entry = CreateEmptyEntry(model.StartPeriod);
            createModel = fillWithDataFromService(createModel);
            createModel.Entries.Add(entry);
            return View(createModel);
        }

        private CreateTimesheetStep2ViewModel fillWithDataFromService(CreateTimesheetStep2ViewModel createModel)
        {
            TimesheetService.IManagement service = new TimesheetService.ManagementClient();
            createModel.Projects = service.GetProjects(0, 0).Select(t => new SelectListItem() { Text = t.Name + "-" + t.Code, Value = t.Id.ToString() });
            createModel.Tasks = service.GetTasks(0, 0).Select(t => new SelectListItem() { Text = t.Name + "-" + t.Code, Value = t.Id.ToString() });
            return createModel;
        }

        private TimesheetEntry CreateEmptyEntry(DateTime model)
        {
            var entry = new TimesheetEntry();
            entry.Date1 = model;
            entry.Date2 = model.AddDays(1);
            entry.Date3 = model.AddDays(2);
            entry.Date4 = model.AddDays(3);
            entry.Date5 = model.AddDays(4);
            entry.Date6 = model.AddDays(5);
            entry.Date7 = model.AddDays(6);
            return entry;
        }

        [Authorize(Roles = "EMPLOYEE")]
        [HttpPost]
        public ActionResult Submit(CreateTimesheetStep2ViewModel model)
        {
            if (model.AddRows.HasValue)
            {
                for (int i = 0; i < model.AddRows.Value; i++)
                {
                    model.Entries.Add(CreateEmptyEntry(model.StartPeriod));
                }
                model = fillWithDataFromService(model);
                model.AddRows = null;
                return View("Step2", model);
            }
            else
            {
                TimesheetService.IManagement service = new TimesheetService.ManagementClient();
                TimesheetService.CreateTimesheet timesheet = new TimesheetService.CreateTimesheet();
                timesheet.StartDay = model.StartPeriod;
                timesheet.EndDay = model.EndPeriod;
                timesheet.UserId = model.Owner;
                List<TimesheetService.CreateEntry> list = new List<TimesheetService.CreateEntry>();
                foreach(var entry in model.Entries)
                {
                    TimesheetService.CreateEntry tmp = new TimesheetService.CreateEntry();
                    tmp.Date = entry.Date1;
                    tmp.Hours = entry.Day1;
                    tmp.ProjectId = int.Parse(entry.Project);
                    tmp.TaskId = int.Parse(entry.Task);
                    list.Add(tmp);
                    tmp = new TimesheetService.CreateEntry();
                    tmp.Date = entry.Date2;
                    tmp.Hours = entry.Day2;
                    tmp.ProjectId = int.Parse(entry.Project);
                    tmp.TaskId = int.Parse(entry.Task);
                    list.Add(tmp);
                    tmp = new TimesheetService.CreateEntry();
                    tmp.Date = entry.Date3;
                    tmp.Hours = entry.Day3;
                    tmp.ProjectId = int.Parse(entry.Project);
                    tmp.TaskId = int.Parse(entry.Task);
                    list.Add(tmp);
                    tmp = new TimesheetService.CreateEntry();
                    tmp.Date = entry.Date4;
                    tmp.Hours = entry.Day4;
                    tmp.ProjectId = int.Parse(entry.Project);
                    tmp.TaskId = int.Parse(entry.Task);
                    list.Add(tmp);
                    tmp = new TimesheetService.CreateEntry();
                    tmp.Date = entry.Date5;
                    tmp.Hours = entry.Day5;
                    tmp.ProjectId = int.Parse(entry.Project);
                    tmp.TaskId = int.Parse(entry.Task);
                    list.Add(tmp);
                    tmp = new TimesheetService.CreateEntry();
                    tmp.Date = entry.Date6;
                    tmp.Hours = entry.Day6;
                    tmp.ProjectId = int.Parse(entry.Project);
                    tmp.TaskId = int.Parse(entry.Task);
                    list.Add(tmp);
                    tmp = new TimesheetService.CreateEntry();
                    tmp.Date = entry.Date7;
                    tmp.Hours = entry.Day7;
                    tmp.ProjectId = int.Parse(entry.Project);
                    tmp.TaskId = int.Parse(entry.Task);
                    list.Add(tmp);
                }
                timesheet.Entries = list.ToArray();
                service.CreateTimesheet(timesheet);
                return RedirectToAction("Index");
            }
            
        }

    }
}