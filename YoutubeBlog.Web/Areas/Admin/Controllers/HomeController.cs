using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using YoutubeBlog.Data.UnitOfWorks;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Service.Services.Abstractions;

namespace YoutubeBlog.Web.Areas.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;
        private readonly IDashboardService dashboardService;
        private readonly IUnitOfWork unitOfWork;

        public HomeController(IArticleService articleService, IDashboardService dashboardService, IUnitOfWork unitOfWork)
        {
            this.articleService = articleService;
            this.dashboardService = dashboardService;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(articles);
        }

        [HttpGet]
        public async Task<IActionResult> YearlyArticleCounts()
        {
            var count = await dashboardService.GetYearlyArticleCounts();
            return Json(JsonConvert.SerializeObject(count));
        }

        [HttpGet]
        public async Task<IActionResult> TotalArticleCount()
        {
            var count = await dashboardService.GetTotalArticleCount();
            return Json(count);
        }

        [HttpGet]
        public async Task<IActionResult> TotalCategoryCount()
        {
            var count = await dashboardService.GetTotalCategoryCount();
            return Json(count);
        }
    }
}
