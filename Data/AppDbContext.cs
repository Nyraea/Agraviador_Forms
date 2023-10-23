using Agraviador_Forms.Models;
using Microsoft.EntityFrameworkCore;

namespace Agraviador_Forms.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 100,
                    FirstName = "Imran",
                    LastName = "Beltran",
                    Email = "imran.beltran.cics@ust.edu.ph",
                    IsTenured = true,
                    Birthday = DateTime.Parse("2019-08-15"),
                    Status = Status.Permanent
                },
                new Instructor()
                {
                    Id = 200,
                    FirstName = "Kiel",
                    LastName = "Tejada",
                    Email = "kiel.tejada.cics@ust.edu.ph",
                    IsTenured = true,
                    Birthday = DateTime.Parse("2002-10-28"),
                    Status = Status.Permanent
                }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 300,
                    FirstName = "Mark Jearald",
                    LastName = "Agraviador",
                    Email = "mark.agraviador.cics@ust.edu.ph",
                    Course = Course.IT,
                    PrelimGrade = 89,
                    FinalGrade = 93,
                    AdmissionDate = DateTime.Parse("2019-08-15")
                },
                new Student()
                {
                    Id = 400,
                    FirstName = "Joseph",
                    LastName = "Magtanggol",
                    Email = "joseph.magtanggol.cics@ust.edu.ph",
                    Course = Course.IT,
                    PrelimGrade = 99,
                    FinalGrade = 95,
                    AdmissionDate = DateTime.Parse("2002-10-28")
                }
                );

        }
    }
}