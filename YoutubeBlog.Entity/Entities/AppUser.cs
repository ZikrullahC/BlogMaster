using Microsoft.AspNetCore.Identity;
using YoutubeBlog.Core.Entities;

namespace YoutubeBlog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>, IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("48cc551b-0cd9-4ca4-b8b1-7deadf243f6b");
        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}