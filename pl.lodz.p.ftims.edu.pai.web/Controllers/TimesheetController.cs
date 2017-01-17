using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pl.lodz.p.ftims.edu.pai.web.Controllers
{
    public class TimesheetController : Controller
    {


        // GET: Timesheet
        public ActionResult Index()
        {
            TimesheetService.ManagementClient client = new TimesheetService.ManagementClient();
            
            return View();
        }
    }
}