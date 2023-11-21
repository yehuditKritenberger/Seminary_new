using Microsoft.AspNetCore.Mvc;
using Seminary.BL;
using Seminary.Model;

namespace SeminaryProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentControllers:ControllerBase
    {
        readonly IStudentService _studentService;
        public StudentControllers(IStudentService studentService)
        {
            this._studentService = studentService;
        }
        [HttpGet]
        public List<Student> Get()
        {
            return _studentService.getAll();
        }
        
    }
}
