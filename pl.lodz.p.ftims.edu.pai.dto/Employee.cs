using System.Runtime.Serialization;

namespace pl.lodz.p.ftims.edu.pai.dto
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }

        public Employee(int id, string name, string lastName, string email)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
        }
    }
}
