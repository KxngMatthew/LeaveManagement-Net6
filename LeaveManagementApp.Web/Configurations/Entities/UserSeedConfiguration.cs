using LeaveManagementApp.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementApp.Web.Configurations.Entities
{
    internal class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hash = new PasswordHasher<Employee>();
            builder.HasData(
              new Employee
              {
                  Id = "35c280b6-f6a1-4b66-9b56-8e1b7a479a57",
                  Email = "admin@yopmail.com",
                  NormalizedEmail = "ADMIN@YOPMAIL.COM",
                  NormalizedUserName = "ADMIN@YOPMAIL.COM",
                  UserName = "admin@yopmail.com",
                  FirstName = "System",
                  LastName = "Admin",
                  PasswordHash = hash.HashPassword(null,"P@ssword1"),
                  EmailConfirmed = true

              },
              new Employee
              {
                  Id = "35c290b6-f6a1-4b66-9d56-8e1b7a333a57",
                  Email = "user@yopmail.com",
                  NormalizedEmail = "USER@YOPMAIL.COM",
                  NormalizedUserName = "USER@YOPMAIL.COM",
                  UserName = "user@yopmail.com",
                  FirstName = "System",
                  LastName = "User",
                  PasswordHash = hash.HashPassword(null, "P@ssword1"),
                  EmailConfirmed = true

              }
              );
        }
    }
}