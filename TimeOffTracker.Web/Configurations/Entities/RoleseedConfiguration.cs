using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeOffTracker.Web.Constants;

namespace TimeOffTracker.Web.Configurations.Entities
{
    public class RoleseedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "2cc9e3ff-0a5c-4a16-82af-da058d968180",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper(),
                },
                 new IdentityRole
                 {
                     Id = "571056d2-b48d-4474-95fe-ba0f4b01225e",
                     Name = Roles.User,
                     NormalizedName = Roles.User.ToUpper()
                 }
              );
        }
    }
}