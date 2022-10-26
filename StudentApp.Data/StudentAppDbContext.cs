using Microsoft.EntityFrameworkCore;

namespace StudentApp.Data
{
    public class StudentAppDBContext :DbContext
    {
        public StudentAppDBContext(DbContextOptions<StudentAppDBContext>options): base(options)
        {

        }   
    }
}