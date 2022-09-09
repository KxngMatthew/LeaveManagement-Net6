using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LeaveManagementApp.Web.Constants;

namespace LeaveManagementApp.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "35c786b6-f6a1-4b28-9b58-8e1b7c479a57",
                    Name = Roles.Administrator ,
                    NormalizedName = Roles.Administrator.ToUpper(),

                },
                 new IdentityRole
                 {
                     Id = "45c576b6-f6a1-4b28-9b58-8e1b7c479b57",
                     Name = Roles.User,
                     NormalizedName = Roles.User.ToUpper(),

                 }
                );
        }
    }
}