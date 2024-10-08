using Week13Practice1_Dependency.Abstract;

namespace Week13Practice1_Dependency.Entities
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher;

        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public void ClassFunc()
        {
            Console.WriteLine("Class fonksiyonu");

            _teacher.GetInfo();
        }
    }
}
