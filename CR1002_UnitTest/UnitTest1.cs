
using CR1002.Services;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetAll_ShouldReturnSeededStudents()
        {
            var service = new StudentServices();

            var students = service.GetAllStudents();

            Assert.NotNull(students);
            Assert.NotEmpty(students);
            Assert.True(students.Count >= 2);

        }
    }
}