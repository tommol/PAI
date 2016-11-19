using System.Runtime.Serialization;

namespace pl.lodz.p.ftims.edu.pai.branch.dto
{
    [DataContract]
    public class Task
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }

        public Task(int id, string code, string name)
        {
            Id = id;
            Code = code;
            Name = name;
        }
    }
}
