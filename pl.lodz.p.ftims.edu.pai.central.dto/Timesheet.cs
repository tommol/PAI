using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace pl.lodz.p.ftims.edu.pai.central.dto
{
    [DataContract]
    public class Timesheet
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime StartDay { get; set; }
        [DataMember]
        public DateTime EndDay { get; set; }
        [DataMember]
        public int Status { get; set; }
        [DataMember]
        public List<Entry> Entries { get; set; }
        [DataMember]
        /// Do usunięcia jak będzie autoryzacja
        public int UserId { get; set; }

        public Timesheet()
        {

        }
        public Timesheet(int id, DateTime start, DateTime end, int status, List<Entry> entries)
        {
            Id = id;
            StartDay = start;
            EndDay = end;
            Status = status;
            Entries = entries;

        }
    }
}
