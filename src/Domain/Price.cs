namespace Domain
{
    public class Price : BaseEntity
    {
        public string? Name { get; set; }
        public decimal ActualPrice { get; set; }
        public decimal PromotionalPrice { get; set; }
        public ICollection<Course>? Courses { get; set; }
        public ICollection<CoursePrice>? CoursePrices { get; set; }
    }
}