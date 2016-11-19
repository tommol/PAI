using System.Runtime.Serialization;

namespace pl.lodz.p.ftims.edu.pai.central.dto
{
    [DataContract]
    public class CreateProject
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int ManagerId { get; set; }
        [DataMember]
        public int Type { get; set; }

        public CreateProject(string code, string name, int managerId, int type)
        {
            Code = code;
            Name = name;
            ManagerId = managerId;
            Type = type;
        }
    }
}
