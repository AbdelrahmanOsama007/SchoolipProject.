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
                var student = await _IMediator.Send(new SchoolipProject.Core.Feauters.Student.Qeuries.Models.GetStudentQuery(id));
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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SchoolipProject.Core.Feauters.Student.Qeuries.Models.AddStudentQuery request)
        {
            try
            {
                var result = await _IMediator.Send(request);
                if (result.Succeeded)
                {
                    return Ok(result);
                }
                return BadRequest(result.Message);
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while adding the student.");
            }
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] SchoolipProject.Core.Feauters.Student.Qeuries.Models.EditStudentQuery request)
        {
            try
            {
                var result = await _IMediator.Send(request);
                if (result.Succeeded)
                {
                    return Ok(result);
                }
                return BadRequest(result.Message);
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating the student.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _IMediator.Send(new SchoolipProject.Core.Feauters.Student.Qeuries.Models.DeleteStudentQuery(id));
                if (result.Succeeded)
                {
                    return Ok(result);
                }
                return BadRequest(result.Message);
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while deleting the student.");
            }
        }
    }
}
