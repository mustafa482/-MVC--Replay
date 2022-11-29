using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.NET1.Data;
using Project.NET1.Data.Entities;


namespace Project.NET1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly ISingletonOperation _singletonOperation;
        private readonly ITransientOperation _transientOperation;
        private readonly IScopedOperation _scopedOperation;
        private readonly IConfiguration _configuration;
        private readonly StudentDbContext _studentDbContext;

        public StudentController(
            ISingletonOperation singletonOperation,
            ITransientOperation transientOperation,
            IScopedOperation scopedOperation,
            IConfiguration configuration,
            StudentDbContext studentDbContext)
        {
            _singletonOperation = singletonOperation;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _configuration = configuration;
            _studentDbContext = studentDbContext;
        }

        


        [HttpGet("All")]
        public async Task<List<Student>> GetAllStudent()
        {
            var list = await _studentDbContext.Students.ToListAsync();
            return list;
        }

        [HttpGet("Guide")]
        public object GetGuids()
        {
            var data = new
            {
                Singleton = _singletonOperation.Id,
                Transient = _transientOperation.Id,
                Scoped = _scopedOperation.Id
            };
            return data;

        }

        
        [HttpGet("student/{id}")]
        public async Task<IActionResult> GetAll(int id,string name)
        {
            var request = Request;
            var context = HttpContext;
            var user = User;



            var student = await _studentDbContext.Students.FirstOrDefaultAsync(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateStudent([FromBody]Student student)
        {
           await _studentDbContext.Students.AddAsync(student);
            await _studentDbContext.SaveChangesAsync();
            return Created($"api/student/student/{student.Id }", student);    
        }
        [HttpPut("update")]
        public async Task<Student> UpdateStudent(int id, Student newstudent)
        {
            var student = await _studentDbContext.Students.FirstOrDefaultAsync(s=>s.Id== id);
            student.Name = newstudent.Name;
            await _studentDbContext.SaveChangesAsync();
            return newstudent;
        }
        [HttpDelete("delete")]
        public async Task<Student> DeleteStudent(int id) 
        {
            var student = await _studentDbContext.Students.FirstOrDefaultAsync(s=>s.Id== id);
             _studentDbContext.Students.Remove(student);
            await _studentDbContext.SaveChangesAsync();
            
        }
        [HttpGet("configs")]
        public object GetConfiguration()
        {
            var configurations = new
            {
                GeneralApiKey = _configuration["ApiKey"],
                SmsApiKey = _configuration["SmsApi:ApiKey"],
                FromNumber = _configuration["SmsApi:FromNumber"]
            };

            return configurations;
        }

    }
}
