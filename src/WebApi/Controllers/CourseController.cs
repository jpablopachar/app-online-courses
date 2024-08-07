using Application.Features.Courses.CreateCourse;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Application.Features.Courses.CreateCourse.CreateCourseCommand;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ISender _sender;

        public CourseController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("create")]
        public async Task<ActionResult<Guid>> CourseCreate([FromForm] CreateCourseRequest createCourseRequest, CancellationToken cancellationToken)
        {
            var command = new CreateCourseCommandRequest(createCourseRequest);

            var res = await _sender.Send(command, cancellationToken);

            return Ok(res);
        }
    }
}