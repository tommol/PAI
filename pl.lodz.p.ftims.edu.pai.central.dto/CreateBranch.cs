using System.Runtime.Serialization;

namespace pl.lodz.p.ftims.edu.pai.central.dto
{
    [DataContract]
    public class CreateBranch
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Uri { get; set; }
    }
}
