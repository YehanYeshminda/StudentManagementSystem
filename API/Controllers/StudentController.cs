using API.CustomsParams;
using API.Dtos;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class StudentController : BaseApiController
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilteredStudentsDto>>> GetUsers()
        {
            return Ok(await _studentRepository.GetStudentsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<FilteredStudentsDto>>> GetUsersById(int id)
        {
            return Ok(await _studentRepository.GetStudentByIdAsync(id));
        }

        [HttpPost("Dob")]
        public async Task<ActionResult<IEnumerable<FilteredStudentsDto>>> GetUsersByDob(StudentFilterAgeParams studentFilterAgeParams)
        {
            return Ok(await _studentRepository.GetStudentByDobAsync(studentFilterAgeParams));
        }
    }
}