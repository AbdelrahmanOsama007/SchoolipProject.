using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolipProject.Core.Feauters.Student.Qeuries.Handelrs;

namespace SchoolipProject.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
       private IMediator _IMediator;
        public StudentsController(IMediator Imediator)
        {
            _IMediator = Imediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var students = await _IMediator.Send(new SchoolipProject.Core.Feauters.Student.Qeuries.Models.GetStudentListQuery());
                return Ok(students);
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the student list.");
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var student = await _IMediator.Send(new SchoolipProject.Core.Feauters.Student.Qeuries.Models.GetStudentQuery { id = id });
                if (student == null)
                {
                    return NotFound("Student not found.");
                }
                return Ok(student);
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the student.");
            }
        }

    }
}
