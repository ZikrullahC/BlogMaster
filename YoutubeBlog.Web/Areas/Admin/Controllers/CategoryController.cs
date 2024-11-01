using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Reflection;
using YoutubeBlog.Entity.DTOs.Categories;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Service.Services.Abstractions;
using YoutubeBlog.Web.Consts;
using YoutubeBlog.Web.ResultMessages;

namespace YoutubeBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IValidator<Category> validator;
        private readonly IMapper mapper;
        private readonly IToastNotification toastNotification;

        public CategoryController(ICategoryService categoryService, IValidator<Category> validator, IMapper mapper, IToastNotification toastNotification)
        {
            this.validator = validator;
            this.mapper = mapper;
            this.categoryService = categoryService;
            this.toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}, {RoleConsts.User}")]
        public async Task<IActionResult> Index()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(categories);
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> DeletedCategory()
        {
            var categories = await categoryService.GetAllCategoriesDeleted();
            return View(categories);
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            var map = mapper.Map<Category>(categoryAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await categoryService.CreateCategoryAsync(categoryAddDto);
                toastNotification.AddSuccessToastMessage(Messages.Category.Add(categoryAddDto.Name));
                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        [HttpPost]
        public async Task<IActionResult> AddWithAjax([FromBody] CategoryAddDto categoryAddDto)
        {
            var map = mapper.Map<Category>(categoryAddDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                await categoryService.CreateCategoryAsync(categoryAddDto);
                toastNotification.AddSuccessToastMessage(Messages.Category.Add(categoryAddDto.Name));
                return Json(Messages.Category.Add(categoryAddDto.Name));
            }
            else
            {
                toastNotification.AddErrorToastMessage(result.Errors.First().ErrorMessage);
                return Json(result.Errors.First().ErrorMessage);
            }
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        [HttpGet]
        public async Task<IActionResult> Update(Guid categoryId)
        {
            var category = await categoryService.GetCategoryByGuid(categoryId);
            var map = mapper.Map<Category, CategoryUpdateDto>(category);

            return View(map);
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            var map = mapper.Map<Category>(categoryUpdateDto);
            var result = await validator.ValidateAsync(map);

            if (result.IsValid)
            {
                var name = await categoryService.UpdateCategoryAsync(categoryUpdateDto);
                toastNotification.AddSuccessToastMessage(Messages.Category.Update(name), new ToastrOptions { Title = "Update process successfull." });
                return RedirectToAction("Index", "Category", new { Area = "Admin" });
            }

            result.AddToModelState(this.ModelState);
            return View();
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> Delete(Guid categoryId)
        {
            var name = await categoryService.SafeDeleteCategoryAsync(categoryId);
            toastNotification.AddSuccessToastMessage(Messages.Category.Delete(name), new ToastrOptions() { Title = "Delete process successfull"});

            return RedirectToAction("Index", "Category", new { Area = "Admin" });
        }

        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task<IActionResult> UndoDelete(Guid categoryId)
        {
            var name = await categoryService.SafeDeleteCategoryAsync(categoryId);
            toastNotification.AddSuccessToastMessage(Messages.Category.UndoDelete(name), new ToastrOptions() { Title = "Delete process successfull" });

            return RedirectToAction("Index", "Category", new { Area = "Admin" });
        }
    }
}
