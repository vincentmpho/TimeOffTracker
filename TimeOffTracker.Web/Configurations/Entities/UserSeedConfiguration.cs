using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeOffTracker.Web.Data;

namespace TimeOffTracker.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                     Id = "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34",
                     Email ="admin@localhost.com",
                     NormalizedEmail ="ADMIN@LOCALHOST.COM",
                     NormalizedUserName ="ADMIN@LOCALHOST.COM",
                     UserName= "admin@localhost.com",
                     FirstName ="System",
                     LastName ="Admin",
                     PasswordHash =hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                },
                 new Employee
                 {
                     Id = "778e5a26-f556-40be-83c9-a2c47af93338",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER@LOCALHOST.COM",
                     NormalizedUserName = "USER@LOCALHOST.COM",
                     UserName = "user@localhost.com",
                     FirstName = "System",
                     LastName = "User",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 }

           );
        }
    }
}