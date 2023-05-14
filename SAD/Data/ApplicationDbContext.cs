using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SAD.Models;
using System.Reflection.Emit;

namespace SAD.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUserModel>
    {
        public DbSet<FollowModel> Follow { get; set; }
        public DbSet<TutorAvailability> TutorAvailabilities { get; set; }
        public DbSet<BookingModel> Booking { get; set; }
        public DbSet<SlotModel> Slot { get; set; }

        public DbSet<Subject> Subject { get; set; }
        public DbSet<UserSubject> UserSubject { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            base.OnModelCreating(builder);
            SeedAdmin(builder);
            SeedStudent(builder);
            SeedTutor(builder);
            SeedRoles(builder);
            SeedUserRoles(builder);

            builder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Mathematics" },
                new Subject { Id = 2, Name = "Physics" },
                new Subject { Id = 3, Name = "Chemistry" },
                new Subject { Id = 4, Name = "Biology" },
                new Subject { Id = 5, Name = "English Literature" },
                new Subject { Id = 6, Name = "History" },
                new Subject { Id = 7, Name = "Geography" },
                new Subject { Id = 8, Name = "Computer Science" },
                new Subject { Id = 9, Name = "Spanish" },
                new Subject { Id = 10, Name = "French" },
                new Subject { Id = 11, Name = "German" },
                new Subject { Id = 12, Name = "Art" },
                new Subject { Id = 13, Name = "Music" },
                new Subject { Id = 14, Name = "Physical Education" },
                new Subject { Id = 15, Name = "Psychology" },
                new Subject { Id = 16, Name = "Sociology" },
                new Subject { Id = 17, Name = "Economics" },
                new Subject { Id = 18, Name = "Business Studies" },
                new Subject { Id = 19, Name = "Accounting" },
                new Subject { Id = 20, Name = "Chemical Engineering" },
                new Subject { Id = 21, Name = "Civil Engineering" },
                new Subject { Id = 22, Name = "Electrical Engineering" },
                new Subject { Id = 23, Name = "Mechanical Engineering" },
                new Subject { Id = 24, Name = "Astronomy" },
                new Subject { Id = 25, Name = "Environmental Science" },
                new Subject { Id = 26, Name = "Political Science" },
                new Subject { Id = 27, Name = "Law" },
                new Subject { Id = 28, Name = "Philosophy" },
                new Subject { Id = 29, Name = "Anthropology" },
                new Subject { Id = 30, Name = "Archaeology" },
                new Subject { Id = 31, Name = "Religious Studies" },
                new Subject { Id = 32, Name = "Film Studies" },
                new Subject { Id = 33, Name = "Media Studies" },
                new Subject { Id = 34, Name = "Graphic Design" },
                new Subject { Id = 35, Name = "Web Development" },
                new Subject { Id = 36, Name = "Mobile App Development" },
                new Subject { Id = 37, Name = "Data Science" },
                new Subject { Id = 38, Name = "Machine Learning" },
                new Subject { Id = 39, Name = "Artificial Intelligence" },
                new Subject { Id = 40, Name = "Robotics" },
                new Subject { Id = 41, Name = "Marketing" },
                new Subject { Id = 42, Name = "Advertising" },
                new Subject { Id = 43, Name = "Finance" },
                new Subject { Id = 44, Name = "Statistics" },
                new Subject { Id = 45, Name = "Mathematical Statistics" },
                new Subject { Id = 46, Name = "Actuarial Science" },
                new Subject { Id = 47, Name = "Literary Studies" }
            );

            builder.Entity<UserSubject>().HasKey(us => new { us.UserId, us.SubjectId });
        }

        //Seed roles
        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "78bf8cbe-1f70-4d6d-890b-247bc57e6150",
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper(),
                    ConcurrencyStamp = "231728ec-ceef-4de5-8c95-7f82a488cc0d"

                }
                );            
            
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02",
                    Name = "Tutor",
                    NormalizedName = "Tutor".ToUpper(),
                    ConcurrencyStamp = "68144efc-092a-403e-a7fe-3c276de06a72",
                }
                );            
            
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "2e97d46f-5885-4d65-aa2f-29e7e2d323fd",
                    Name = "Student",
                    NormalizedName = "Student".ToUpper(),
                    ConcurrencyStamp = "2a956498-1cb2-4a0f-8d27-236a95c6e820"

                }
                );
        }

        //Seed tutor user
        private void SeedTutor(ModelBuilder builder)
        {
            PasswordHasher<CustomUserModel> hasher = new PasswordHasher<CustomUserModel>();
            CustomUserModel user = new CustomUserModel();
            user.Id = "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd";
            user.UserName = "tutor@tutor.com";
            user.NormalizedUserName = "tutor@tutor.com".ToUpper();
            user.NormalizedEmail = "tutor@tutor.com".ToUpper();
            user.Email = "tutor@tutor.com";
            user.LockoutEnabled = false;
            user.FName = "Tutor";
            user.SName = "Tutor";
            user.ConcurrencyStamp = "68144efc-092a-403e-a7fe-3c276de06a72";
            user.PasswordHash = hasher.HashPassword(user, "Qwe123!");

            user.About = "I am an experienced teacher with 10 years of experience in teaching Math and Science.";
            user.teacherCode = "1234567890";

            builder.Entity<CustomUserModel>().HasData(user);
        }

        //Seed student user
        private void SeedStudent(ModelBuilder builder)
        {
            PasswordHasher<CustomUserModel> hasher = new PasswordHasher<CustomUserModel>();
            CustomUserModel user = new CustomUserModel();
            user.Id = "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb";
            user.UserName = "student@student.com";
            user.NormalizedUserName = "student@student.com".ToUpper();
            user.NormalizedEmail = "student@student.com".ToUpper();
            user.Email = "student@student.com";
            user.LockoutEnabled = false;
            user.FName = "Student";
            user.SName = "Student";
            user.ConcurrencyStamp = "2a956498-1cb2-4a0f-8d27-236a95c6e820";
            user.PasswordHash = hasher.HashPassword(user, "Qwe123!");

            builder.Entity<CustomUserModel>().HasData(user);
        }

        //Seed admin user
        private void SeedAdmin(ModelBuilder builder)
        {
            PasswordHasher<CustomUserModel> hasher = new PasswordHasher<CustomUserModel>();
            CustomUserModel user = new CustomUserModel();
            user.Id = "143d3180-1104-46f0-8646-62d630056f42";
            user.UserName = "admin@admin.com";
            user.NormalizedUserName = "admin@admin.com".ToUpper();
            user.NormalizedEmail = "admin@admin.com".ToUpper();
            user.Email = "admin@admin.com";
            user.LockoutEnabled = false;
            user.FName = "Admin";
            user.SName = "Admin";
            user.ConcurrencyStamp = "231728ec-ceef-4de5-8c95-7f82a488cc0d";
            user.PasswordHash = hasher.HashPassword(user, "Admin123!");

            builder.Entity<CustomUserModel>().HasData(user);
        }

        //Give users their roles
        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(

                //Admin
                new IdentityUserRole<string>()
                {
                    RoleId = "78bf8cbe-1f70-4d6d-890b-247bc57e6150",
                    UserId = "143d3180-1104-46f0-8646-62d630056f42"
                },

                //Student
                new IdentityUserRole<string>()
                {
                    RoleId = "2e97d46f-5885-4d65-aa2f-29e7e2d323fd",
                    UserId = "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb"
                },

                //Tutor
                new IdentityUserRole<string>()
                {
                    RoleId = "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02",
                    UserId = "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd"
                });
        }

    }
}
