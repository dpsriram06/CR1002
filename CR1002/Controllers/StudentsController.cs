using Microsoft.AspNetCore.Mvc;
using CR1002.Services;
using CR1002.Models;
 

namespace CR1002.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {

        private readonly IStudentServices _studentServices;


        public StudentsController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }


        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = _studentServices.GetAllStudents();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _studentServices.GetStudentById(id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }
            return Ok(student);
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            _studentServices.Add(student);
            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }
 
   
    }
}
