using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/students")]
public class StudentController : ControllerBase
{
    private readonly ILogger<StudentController> _logger;
    private readonly IStudentServices _blogPostServices;

    public StudentController(
        ILogger<StudentController> logger,
        IStudentServices blogPostServices
    )
    {
        _logger = logger;
        _blogPostServices = blogPostServices;
    }

    [EnableCors]
    [HttpPost]
    public async Task<ActionResult> CreateStudent([FromBody] Student student)
    {
        try
        {
            await _blogPostServices.Create(student);
            return Ok(student);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [EnableCors]
    [HttpGet]
    public async Task<ActionResult> GetStudents()
    {
        try
        {
            return Ok(await _blogPostServices.GetStudents());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [EnableCors]
    [HttpGet("{id}")]
    public async Task<ActionResult> GetStudent(int id)
    {
        try
        {
            return Ok(await _blogPostServices.GetStudent(id));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [EnableCors]
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteStudent(int id)
    {
        try
        {
            return Ok(await _blogPostServices.DeleteStudent(id));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [EnableCors]
    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateStudent(int id, [FromBody] Student student)
    {
        try
        {
            return Ok(await _blogPostServices.UpdateStudent(id, student));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
