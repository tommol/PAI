using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace pl.lodz.p.ftims.edu.pai.central.dto
{
    [DataContract]
    public class CreateTimesheet
    {
        [DataMember]
        public DateTime StartDay { get; set; }
        [DataMember]
        public DateTime EndDay { get; set; }
        [DataMember]
        public List<CreateEntry> Entries { get; set; }
        [DataMember]
        public int UserId { get; set; }
    }
}
