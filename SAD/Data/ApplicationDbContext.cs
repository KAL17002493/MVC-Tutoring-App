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
                    ConcurrencyStamp = "68144efc-092a-403e-a7fe-3c276de06a72"

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

                new IdentityUserRole<string>()
                {
                    RoleId = "78bf8cbe-1f70-4d6d-890b-247bc57e6150",
                    UserId = "143d3180-1104-46f0-8646-62d630056f42"
                });
        }

    }
}
