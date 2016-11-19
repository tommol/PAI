using System.Runtime.Serialization;

namespace pl.lodz.p.ftims.edu.pai.branch.dto
{
    [DataContract]
    public class Project
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Type { get; set; }

        public Project(int id, string code, string name, int type)
        {
            Id = id;
            Code = code;
            Name = name;
            Type = type;
        }

    }
}
