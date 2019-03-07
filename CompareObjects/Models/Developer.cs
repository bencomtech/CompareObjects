using System.Collections.Generic;

namespace CompareObjects.Models
{
    public class Developer
    {
        public int DeveloperID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
