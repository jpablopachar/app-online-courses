using Domain;
using MediatR;
using Persistence;

namespace Application.Features.Courses.CreateCourse
{
    public class CreateCourseCommand
    {
        public record CreateCourseCommandRequest(CreateCourseRequest CreateCourseRequest) : IRequest<Guid>;

        internal class CreateCourseCommandHandler(OnlineCoursesDbContext context) : IRequestHandler<CreateCourseCommandRequest, Guid>
        {
            private readonly OnlineCoursesDbContext _context = context;

            public async Task<Guid> Handle(CreateCourseCommandRequest request, CancellationToken cancellationToken)
            {
                var course = new Course {
                    Id = Guid.NewGuid(),
                    Title = request.CreateCourseRequest.Title,
                    Description = request.CreateCourseRequest.Description,
                    PublicationDate = request.CreateCourseRequest.PublicationDate
                };

                _context.Add(course);

                await _context.SaveChangesAsync();

                return course.Id;
            }
        }
    }
}