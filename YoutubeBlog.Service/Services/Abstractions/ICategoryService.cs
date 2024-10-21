using YoutubeBlog.Entity.DTOs.Categories;

namespace YoutubeBlog.Service.Services.Abstractions
{
    public interface ICategoryService
    {
        public Task<List<CategoryDto>> GetAllCategoriesNonDeleted();
    }
}
