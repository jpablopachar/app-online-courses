using FluentValidation;

namespace Application.Features.Courses.CreateCourse
{
    public class CreateCourseValidator : AbstractValidator<CreateCourseRequest>
    {
        public CreateCourseValidator()
        {
            RuleFor(c => c.Title).NotEmpty().WithMessage("Title is required");

            RuleFor(c => c.Description).NotEmpty().WithMessage("Description is required");
        }
    }
}