using Bogus;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence
{
    public class OnlineCoursesDbContext(DbContextOptions<OnlineCoursesDbContext> options) : IdentityDbContext<AppUser>(options)
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Price>? Prices { get; set; }
        public DbSet<Qualification>? Qualifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().ToTable("courses");
            modelBuilder.Entity<Instructor>().ToTable("instructors");
            modelBuilder.Entity<CourseInstructor>().ToTable("course_instructors");
            modelBuilder.Entity<Price>().ToTable("prices");
            modelBuilder.Entity<CoursePrice>().ToTable("course_prices");
            modelBuilder.Entity<Qualification>().ToTable("qualifications");
            modelBuilder.Entity<Photo>().ToTable("photos");

            modelBuilder.Entity<Price>().Property(p => p.ActualPrice).HasPrecision(10, 2);

            modelBuilder.Entity<Price>().Property(p => p.PromotionalPrice).HasPrecision(10, 2);

            modelBuilder.Entity<Price>().Property(p => p.Name).HasColumnType("VARCHAR").HasMaxLength(250);

            // Un curso puede tener muchas fotos, y cada foto está asociada a un curso. Al eliminar un curso, todas las fotos asociadas también se eliminarán.
            modelBuilder.Entity<Course>().HasMany(c => c.Photos).WithOne(c => c.Course).HasForeignKey(c => c.CourseId).OnDelete(DeleteBehavior.Cascade);

            // Un curso puede tener muchas calificaciones, y cada calificación está asociada a un curso. No se puede eliminar un curso si existen calificaciones asociadas a él.
            modelBuilder.Entity<Course>().HasMany(c => c.Qualifications).WithOne(c => c.Course).HasForeignKey(c => c.CourseId).OnDelete(DeleteBehavior.Restrict);

            // Se configura una relación de muchos a muchos entre Course y Price utilizando la entidad CoursePrice, definiendo las claves foráneas y la clave primaria compuesta.
            modelBuilder.Entity<Course>().HasMany(c => c.Prices).WithMany(c => c.Courses).UsingEntity<CoursePrice>(a => a.HasOne(p => p.Price).WithMany(p => p.CoursePrices).HasForeignKey(p => p.PriceId), b => b.HasOne(p => p.Course).WithMany(p => p.CoursePrices).HasForeignKey(p => p.CourseId), c => { c.HasKey(t => new { t.PriceId, t.CourseId }); });

            // Se configura una relación de muchos a muchos entre Course e Instructor utilizando la entidad CourseInstructor, definiendo las claves foráneas y la clave primaria compuesta.
            modelBuilder.Entity<Course>().HasMany(c => c.Instructors).WithMany(c => c.Courses).UsingEntity<CourseInstructor>(a => a.HasOne(p => p.Instructor).WithMany(p => p.CourseInstructors).HasForeignKey(p => p.InstructorId), b => b.HasOne(p => p.Course).WithMany(p => p.CourseInstructors).HasForeignKey(p => p.CourseId), c => { c.HasKey(t => new { t.InstructorId, t.CourseId }); });

            modelBuilder.Entity<Course>().HasData(LoadMasterData().Item1);
            modelBuilder.Entity<Price>().HasData(LoadMasterData().Item2);
            modelBuilder.Entity<Instructor>().HasData(LoadMasterData().Item3);

            LoadSecurityData(modelBuilder);
        }

        private Tuple<Course[], Price[], Instructor[]> LoadMasterData()
        {
            var courses = new List<Course>();
            var faker = new Faker();

            for (var i = 1; i < 10; i++)
            {
                var courseId = Guid.NewGuid();

                courses.Add(new Course
                {
                    Id = courseId,
                    Description = faker.Commerce.ProductDescription(),
                    Title = faker.Commerce.ProductName(),
                    PublicationDate = DateTime.UtcNow
                });
            }

            var priceId = Guid.NewGuid();

            var price = new Price
            {
                Id = priceId,
                ActualPrice = 10.0m,
                PromotionalPrice = 8.0m,
                Name = "Regular Price"
            };

            var prices = new List<Price> { price };

            var fakerInstructor = new Faker<Instructor>()
                .RuleFor(i => i.Id, _ => Guid.NewGuid())
                .RuleFor(i => i.FirstName, faker => faker.Name.FirstName())
                .RuleFor(i => i.LastName, faker => faker.Name.LastName())
                .RuleFor(i => i.AcademicDegree, faker => faker.Name.JobTitle());

            var instructors = fakerInstructor.Generate(10);

            return Tuple.Create(courses.ToArray(), prices.ToArray(), instructors.ToArray());
        }

        private void LoadSecurityData(ModelBuilder modelBuilder)
        {
            var adminId = Guid.NewGuid().ToString();
            var clientId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = adminId,
                Name = CustomRoles.ADMIN,
                NormalizedName = CustomRoles.ADMIN
            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = clientId,
                Name = CustomRoles.CLIENT,
                NormalizedName = CustomRoles.CLIENT
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(new IdentityRoleClaim<string>
            {
                Id = 1,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.COURSE_READ,
                RoleId = adminId,
            }, new IdentityRoleClaim<string>
            {
                Id = 2,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.COURSE_UPDATE,
                RoleId = adminId,
            }, new IdentityRoleClaim<string>
            {
                Id = 3,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.COURSE_WRITE,
                RoleId = adminId,
            }, new IdentityRoleClaim<string>
            {
                Id = 4,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.COURSE_DELETE,
                RoleId = adminId,
            }, new IdentityRoleClaim<string>
            {
                Id = 5,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.INSTRUCTOR_CREATE,
                RoleId = adminId,
            }, new IdentityRoleClaim<string>
            {
                Id = 6,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.INSTRUCTOR_READ,
                RoleId = adminId,
            }, new IdentityRoleClaim<string>
            {
                Id = 7,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.INSTRUCTOR_UPDATE,
                RoleId = adminId,
            }, new IdentityRoleClaim<string>
            {
                Id = 8,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.COMMENT_READ,
                RoleId = adminId,
            }, new IdentityRoleClaim<string>
            {
                Id = 9,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.COMMENT_DELETE,
                RoleId = adminId,
            }, new IdentityRoleClaim<string>
            {
                Id = 10,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.COMMENT_CREATE,
                RoleId = adminId,
            }, new IdentityRoleClaim<string>
            {
                Id = 11,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.COURSE_READ,
                RoleId = clientId,
            }, new IdentityRoleClaim<string>
            {
                Id = 12,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.INSTRUCTOR_READ,
                RoleId = clientId,
            }, new IdentityRoleClaim<string>
            {
                Id = 13,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.COMMENT_READ,
                RoleId = clientId,
            }, new IdentityRoleClaim<string>
            {
                Id = 14,
                ClaimType = CustomClaims.POLICIES,
                ClaimValue = PolicyMaster.COMMENT_CREATE,
                RoleId = clientId,
            });
        }
    }
}