using CR1002.Models;

namespace CR1002.Services
{
    public class StudentServices : IStudentServices
    {

        private static readonly List<Student> students = new()
        {
            new Student { Id = 1, Name = "John Doe", Email = "John@gmail.com", Course = "Computer Science" },
            new Student { Id = 2, Name = "Jane Smith", Email= "Jane@gmail.com", Course = "Mathematics" }, 
            new Student { Id = 3, Name = "Alice Johnson", Email = "Alice@gmail.com", Course = "Physics" }
        };


        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public Student Add(Student student)
        {
            students.Add(student);
            return student;
        }
    }
}
 