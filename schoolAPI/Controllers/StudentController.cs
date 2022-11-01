using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using schoolAPI.DTO;
using schoolAPI.Services;

namespace schoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [Route("/create")]
        [HttpPost]
        public async Task<bool> CreateStudent(StudentDTO studentDTO)
        {
            return await _studentService.CreateStudent(studentDTO);
        }

    }
}
