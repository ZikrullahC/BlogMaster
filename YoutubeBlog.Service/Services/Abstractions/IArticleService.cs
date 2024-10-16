using YoutubeBlog.Entity.DTOs.Articles;

namespace YoutubeBlog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesAsync();
    }
}
