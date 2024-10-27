using Microsoft.AspNetCore.Identity;

namespace YoutubeBlog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("8092A603-4AC8-42B6-8DD6-B4297DC37EBC");
        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}