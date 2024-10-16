using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
                {
                    Id = Guid.Parse("FA44C043-FA75-43E3-B43C-159BF33861CF"),
                    Name = "Spring Boot",
                    CreatedBy = "Admin Test",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("3D072495-4C20-46CF-A307-E3650F903BD3"),
                    Name = "ASP.NET Core",
                    CreatedBy = "Admin Test",
                    IsDeleted = false
                }
            );
        }
    }
}
