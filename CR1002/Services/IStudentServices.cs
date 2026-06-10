using CR1002.Models;

namespace CR1002.Services
{
    public interface IStudentServices
    {
        List<Student> GetAllStudents();

        Student GetStudentById(int id);

        Student Add(Student student);
    }
}
