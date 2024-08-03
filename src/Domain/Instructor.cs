namespace Domain
{
    public class Instructor : BaseEntity
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? AcademicDegree { get; set; }

        public ICollection<Course>? Courses { get; set; }
        public ICollection<CourseInstructor>? CourseInstructors { get; set; }
    }
}