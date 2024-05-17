using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Student;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        
        private readonly StudentContext _dbContext;
        public StudentController(StudentContext dbContext)
        {
            _dbContext = dbContext;
        }
        //GET:api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            if (_dbContext.Students == null)
            {
                return NotFound();
            }
            return await _dbContext.Student.ToListAsync();
        }
        //GET:api/Students/2
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentController>>GetStudent(int id)
        {
            if (_dbContext.Students == null)
            {
                return NotFound();
            }
          var student=await _dbContext.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }
    }
}
