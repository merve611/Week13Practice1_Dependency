using Week13Practice1_Dependency.Abstract;

namespace Week13Practice1_Dependency.Entities
{
    public class Teacher :ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo()
        {
            return FirstName + LastName;
        }
    }
    
}
