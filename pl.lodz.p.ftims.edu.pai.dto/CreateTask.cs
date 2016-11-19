using System.Runtime.Serialization;

namespace pl.lodz.p.ftims.edu.pai.branch.dto
{
    [DataContract]
    public class CreateTask
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }

        public CreateTask(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
