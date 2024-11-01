using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YoutubeBlog.Entity.Entities;  

namespace YoutubeBlog.Entity.DTOs.Users
{
    public class UserProfileDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CurrentPassword { get; set; }
        public string? NewPassword { get; set; }
        [FromForm]
        public IFormFile? Photo { get; set; }
        public Image? Image { get; set; }
    }
}