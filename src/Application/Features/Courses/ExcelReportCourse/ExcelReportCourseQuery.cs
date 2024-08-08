using Application.Interfaces;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Features.Courses.ExcelReportCourse
{
    public class ExcelReportCourseQuery
    {
        public record ExcelReportCourseQueryRequest : IRequest<MemoryStream>;

        internal class ExcelReportCourseQueryHandler(OnlineCoursesDbContext context, IReportService<Course> reportService) : IRequestHandler<ExcelReportCourseQueryRequest, MemoryStream>
        {
            private readonly OnlineCoursesDbContext _context = context;
            private readonly IReportService<Course> _reportService = reportService;

            public async Task<MemoryStream> Handle(ExcelReportCourseQueryRequest request, CancellationToken cancellationToken)
            {
                var courses = await _context.Courses.Take(10).Skip(0).ToListAsync(cancellationToken);

                return await _reportService.GetCsvReport(courses);
            }
        }
    }
}