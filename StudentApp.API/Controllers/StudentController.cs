using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Core;
using StudentApp.Data;

namespace StudentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentAppDbContext dbContext;

        public StudentController(StudentAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]

        public IActionResult GetAllStudents()
        {
            return Ok(this.dbContext.StudentDetails.ToList());
        }

        [HttpPost]

        public IActionResult SaveStudent(StudentDetail student)
        {
            this.dbContext.StudentDetails.Add(student);
            this.dbContext.SaveChanges();

            return Ok("Student Added Succesfully....!");
        }
    }
}
