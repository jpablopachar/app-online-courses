using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Persistence
{
    public class OnlineCoursesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=OnlineCourses.db").LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information).EnableSensitiveDataLogging();
        }

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
        }
    }
}