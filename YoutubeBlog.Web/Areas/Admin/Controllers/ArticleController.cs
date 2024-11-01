using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using YoutubeBlog.Entity.DTOs.Articles;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Service.Extensions;
using YoutubeBlog.Service.Services.Abstractions;
using YoutubeBlog.Web.Consts;
using YoutubeBlog.Web.ResultMessages;

namespace YoutubeBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;
        private readonly IValidator<Article> validator;
        private readonly IToastNotification toastNotification;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, IMapper mapper, IValidator<Article> validator, IToastNotification toastNotification)
        {
            this.articleService = articleService;
            this.mapper = mapper;
            this.categoryService = categoryService;
            this.validator = validator;
            this.toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}, {RoleConsts.User}")]
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        [HttpGet]
        public async Task<IActionResult> DeletedArticle()
        {
            var articles = await articleService.GetAllArticlesWithCategoryDeletedAsync();
            return View(articles);
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDto { Categories = categories});
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {
            var map = mapper.Map<Article>(articleAddDto);
            var result = await validator.ValidateAsync(map);
    
            if (result.IsValid)
            {
                await articleService.CreateArticleAsync(articleAddDto);
                toastNotification.AddSuccessToastMessage(Messages.Article.Add(articleAddDto.Title));
                return RedirectToAction("Index", "Article", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);
                var categories = await categoryService.GetAllCategoriesNonDeleted();
                return View(new ArticleAddDto { Categories = categories });
            }
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        [HttpGet]
        public async Task<IActionResult>Update(Guid articleId)
        {
            var article = await articleService.GetArticleWithCategoryNonDeletedAsync(articleId);
            var categories = await categoryService.GetAllCategoriesNonDeleted();

            var articleUpdateDto = mapper.Map<ArticleUpdateDto>(article);
            articleUpdateDto.Categories = categories;

            if(articleUpdateDto.Image == null)
            {
                Console.WriteLine("ArticleUpdateDto = Null");
            }
            else
            {
                Console.WriteLine("ArticleUpdateDto != Null");
            }

            return View(articleUpdateDto);
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        [HttpPost]
        public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
        {
            var map = mapper.Map<Article>(articleUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var title = await articleService.UpdateArticleAsync(articleUpdateDto);
                toastNotification.AddSuccessToastMessage(Messages.Article.Update(title), new ToastrOptions() { Title = "Update process successful" });
                return RedirectToAction("Index", "Article", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);
            }


            var categories = await categoryService.GetAllCategoriesNonDeleted();
            articleUpdateDto.Categories = categories;

            return RedirectToAction("Index", "Article", new { Area = "Admin" });
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Delete(Guid articleId)
        {
            var title = await articleService.SafeDeleteArtisticAsync(articleId);
            toastNotification.AddSuccessToastMessage(Messages.Article.Delete(title), new ToastrOptions() { Title = "Delete process successful" });

            return RedirectToAction("Index", "Article", new { Area = "Admin" });
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> UndoDelete(Guid articleId)
        {
            var title = await articleService.UndoDeleteArtisticAsync(articleId);
            toastNotification.AddSuccessToastMessage(Messages.Article.UndoDelete(title), new ToastrOptions() { Title = "Delete process successful" });

            return RedirectToAction("Index", "Article", new { Area = "Admin" });
        }
    }
}
