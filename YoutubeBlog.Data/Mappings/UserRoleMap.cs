using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("E220B1CC-7F5B-47C7-96F4-01AF756FBD9F"),
                RoleId = Guid.Parse("DC7FFFE4-9E29-4D4E-9986-11684C1EBCD7")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("BC17922C-11F6-4993-8E63-E9D7255ACDA5"),
                RoleId = Guid.Parse("ACBD2027-D44C-4AD9-82A1-0663E938700C")
            });
        }
    }
}
