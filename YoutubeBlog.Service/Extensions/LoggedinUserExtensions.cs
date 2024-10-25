using System.Security.Claims;

namespace YoutubeBlog.Service.Extensions
{
    public static class LoggedinUserExtensions
    {
        public static Guid GetLoggedInUserId(this ClaimsPrincipal principal)
        {
            var id = principal.FindFirstValue(ClaimTypes.NameIdentifier);
            if (id == null)
            {
                throw new InvalidOperationException("User indetifier not found");
            }

            return Guid.Parse(id);
        }

        public static string GetLoggedInEmail(this ClaimsPrincipal principal)
        {
            var email = principal.FindFirstValue(ClaimTypes.Name);
            if(email == null)
            {
                throw new InvalidOperationException("Email not found");
            }

            return email;
        }
    }
}
