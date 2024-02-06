using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TimeOffTracker.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<String>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<String>> builder)
        {
            builder.HasData(
                 new IdentityUserRole<String>
                 {
                     RoleId = "2cc9e3ff-0a5c-4a16-82af-da058d968180",
                     UserId = "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34"
                 },
                  new IdentityUserRole<String>
                  {
                      RoleId = "571056d2-b48d-4474-95fe-ba0f4b01225e",
                      UserId = "778e5a26-f556-40be-83c9-a2c47af93338"
                  }
                );
        }
    }
}