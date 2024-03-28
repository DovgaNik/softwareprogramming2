extern 

namespace ConsoleApp4
{
    internal class ListOfStudents
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void PrintStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }


    }
}
