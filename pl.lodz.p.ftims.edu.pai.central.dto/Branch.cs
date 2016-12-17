using System.Runtime.Serialization;

namespace pl.lodz.p.ftims.edu.pai.central.dto
{
    [DataContract]
    public class Branch
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Uri { get; set; }
    }
}
