﻿using Microsoft.AspNetCore.SignalR;
using YoutubeBlog.Core.Entities;

namespace YoutubeBlog.Entity.Entities
{
    public class Article : EntityBase
    {
        public Article()
        {

        }
        
        public Article(string title, string content, Guid userId, Guid categoryId,Guid imageId,string createdBy)
        {
            Title = title;
            Content = content;
            UserId = userId;
            CategoryId = categoryId;
            ImageId = imageId;
            CreatedBy = createdBy;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; } = 0;

        //Id degerini EF Core otomatik olarak sinifin ismine gore ayarlar. Mesela CategoryId degeri Category sinifina aittir.
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid? ImageId { get; set; }
        public Image Image { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
