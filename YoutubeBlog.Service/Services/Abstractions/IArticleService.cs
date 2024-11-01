using YoutubeBlog.Entity.DTOs.Articles;

namespace YoutubeBlog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
        Task<List<ArticleDto>> GetAllArticlesWithCategoryDeletedAsync();
        Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId);
        Task <string>SafeDeleteArtisticAsync(Guid articleId);
        Task <string>UndoDeleteArtisticAsync(Guid articleId);
        Task <string>UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);
        Task CreateArticleAsync(ArticleAddDto articleAddDto);
    }
}
