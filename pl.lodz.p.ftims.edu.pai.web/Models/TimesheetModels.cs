using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace pl.lodz.p.ftims.edu.pai.web.Models
{
    public class TimesheetListItemViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Początek")]
        [DataType(DataType.Date)]
        public DateTime StartPeriod { get; set; }
        [Display(Name = "Koniec")]
        [DataType(DataType.Date)]
        public DateTime EndPeriod { get; set; }
        [Display(Name = "Status")]
        public int Status { get; set; }
    }

    public class CreateTimesheetStep1ViewModel
    {
        [Display(Name = "Początek")]
        [DataType(DataType.Date)]
        public DateTime StartPeriod { get; set; }
        [Display(Name = "Koniec")]
        [DataType(DataType.Date)]
        public DateTime EndPeriod { get; set; }
        public int Owner
        {
            get; set;

        }
    }
    public class CreateTimesheetStep2ViewModel
    {
        public CreateTimesheetStep2ViewModel()
        {
            Entries = new List<TimesheetEntry>();
        }
        [Display(Name = "Początek")]
        [DataType(DataType.Date)]
        public DateTime StartPeriod { get; set; }
        [Display(Name = "Koniec")]
        [DataType(DataType.Date)]
        public DateTime EndPeriod { get; set; }
        public int Owner
        {
            get; set;

        }
        public List<TimesheetEntry> Entries
        {
            get; set;

        }
        public IEnumerable<System.Web.Mvc.SelectListItem> Projects { get; set; }
        public IEnumerable<System.Web.Mvc.SelectListItem> Tasks { get; set; }

        public int? AddRows { get; set; }
    }


    public class TimesheetEntry
    {
        public string Project { get; set; }
        public string Task { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date1 { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date2 { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date3 { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date4 { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date5 { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date6 { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date7 { get; set; }
        public int Day1 { get; set; }
        public int Day2 { get; set; }
        public int Day3 { get; set; }
        public int Day4 { get; set; }
        public int Day5 { get; set; }
        public int Day6 { get; set; }
        public int Day7 { get; set; }
    }

    public class TimesheetViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Początek")]
        [DataType(DataType.Date)]
        public DateTime StartPeriod { get; set; }
        [Display(Name = "Koniec")]
        [DataType(DataType.Date)]
        public DateTime EndPeriod { get; set; }
        public List<TimesheetEntry> Entries
        {
            get; set;

        }
        public List<TimesheetHistory> History { get; set; }


    }
    public class TimesheetHistory
    {
        public DateTime Date { get; set; }
        public int PreviousStatus { get; set; }
        public int NewStatus { get; set; }
        public string UserName { get; set; }
    }


}
