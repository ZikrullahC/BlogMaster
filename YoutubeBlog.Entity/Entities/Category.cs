﻿using YoutubeBlog.Core.Entities;

namespace YoutubeBlog.Entity.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {
            
        }
        public Category(string name, string createdBy)
        {
            CreatedBy = createdBy;
            Name = name;
        }
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
