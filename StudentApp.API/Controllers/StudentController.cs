using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApp.API.Repository;
using StudentApp.Core;
using StudentApp.Data;

namespace StudentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentRepo _studentRepo;

        public StudentController(StudentRepo repo)
        {
            this._studentRepo = repo;
        }

        [HttpGet]

        public IActionResult GetAllStudents()
        {
            return Ok(_studentRepo.GetAllStudents());
        }

        [HttpPost]

        public IActionResult SaveStudent(StudentDetail student)
        {
         

            return Ok(_studentRepo.AddStudent(student));
        }
    }
}
