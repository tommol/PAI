using System;
using System.Runtime.Serialization;

namespace pl.lodz.p.ftims.edu.pai.branch.dto
{
    [DataContract]
    public class CreateEntry
    {
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public int ProjectId { get; set; }
        [DataMember]
        public int TaskId { get; set; }
        [DataMember]
        public int Hours { get; set; }
    }
}
