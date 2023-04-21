using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SAD.Models;

namespace SAD.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUserModel>
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedAdmin(builder);
            SeedStudent(builder);
            SeedTutor(builder);
            SeedRoles(builder);
            SeedUserRoles(builder);
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

        //Give admin user it's admin role
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
