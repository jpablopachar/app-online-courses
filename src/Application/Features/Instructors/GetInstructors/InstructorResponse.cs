namespace Application.Features.Instructors.GetInstructors
{
    public record InstructorResponse(Guid? Id, string? Name, string? LastName, string? Degree)
    {
        public InstructorResponse() : this(null, null, null, null) { }
    }
}