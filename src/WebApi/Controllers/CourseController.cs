using Application.Features.Courses.CreateCourse;
using Application.Features.Courses.ExcelReportCourse;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Application.Features.Courses.CreateCourse.CreateCourseCommand;
using static Application.Features.Courses.ExcelReportCourse.ExcelReportCourseQuery;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController(ISender sender) : ControllerBase
    {
        private readonly ISender _sender = sender;

        [HttpPost("create")]
        public async Task<ActionResult<Guid>> CourseCreate([FromForm] CreateCourseRequest createCourseRequest, CancellationToken cancellationToken)
        {
            var command = new CreateCourseCommandRequest(createCourseRequest);

            var res = await _sender.Send(command, cancellationToken);

            return Ok(res);
        }

        [HttpGet("report")]
        public async Task<IActionResult> CSVReport(CancellationToken cancellationToken)
        {
            var query = new ExcelReportCourseQueryRequest();
            var res = await _sender.Send(query, cancellationToken);

            byte[] excelBytes = res.ToArray();

            return File(excelBytes, "text/csv", "courses.csv");
        }
    }
}