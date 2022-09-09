using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementApp.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "35c786b6-f6a1-4b28-9b58-8e1b7c479a57",
                    UserId = "35c280b6-f6a1-4b66-9b56-8e1b7a479a57"

                },
                new IdentityUserRole<string>
                {
                    RoleId = "45c576b6-f6a1-4b28-9b58-8e1b7c479b57",
                    UserId = "35c290b6-f6a1-4b66-9d56-8e1b7a333a57"

                }
                );
            
        }
    }
}