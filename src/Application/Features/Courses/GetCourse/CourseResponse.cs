namespace Application.Features.Courses.GetCourse
{
    public record CourseResponse(Guid Id, string Title, string Description, DateTime? PublicationDate);
}