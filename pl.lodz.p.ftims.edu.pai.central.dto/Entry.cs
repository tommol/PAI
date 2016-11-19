using System;
using System.Runtime.Serialization;

namespace pl.lodz.p.ftims.edu.pai.central.dto
{
    [DataContract]
    public class Entry
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public int ProjectId { get; set; }
        [DataMember]
        public int TaskId { get; set; }
        [DataMember]
        public int Hours { get; set; }
        public Entry(int id, DateTime date, int projectId, int taskId, int hours)
        {
            Id = id;
            Date = date;
            ProjectId = projectId;
            TaskId = taskId;
            Hours = hours;
        }

    }
}
