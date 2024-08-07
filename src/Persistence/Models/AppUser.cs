using Microsoft.AspNetCore.Identity;

namespace Persistence.Models
{
    public class AppUser : IdentityUser
    {
        public string? FullName { get; set; }
        public string? AcademicDegree { get; set; }
    }
}