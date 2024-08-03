namespace Domain
{
    public class Photo : BaseEntity
    {
        public string? Url { get; set; }
        public Guid? CourseId { get; set; }
        public Course? Course { get; set; }
        public string? PublicId { get; set; }
    }
}