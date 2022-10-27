using StudentApp.Core;
using StudentApp.Data;

namespace StudentApp.API.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentAppDbContext _context;

        public StudentRepo(StudentAppDbContext context)
        {
            _context = context;
        }

        public string AddStudent(StudentDetail student)
        {
            this._context.StudentDetails.Add(student);
            this._context.SaveChanges();
            return "Student Added Successfully...";
        }

        public List<StudentDetail> GetAllStudents()
        {
            return this._context.StudentDetails.ToList();

        }
    }
}
