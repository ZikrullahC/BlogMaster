using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Service.FluentValidations;
using YoutubeBlog.Service.Helpers.Images;
using YoutubeBlog.Service.Services.Abstractions;
using YoutubeBlog.Service.Services.Concrete;

namespace YoutubeBlog.Service.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IImageHelper, ImageHelper>();
            services.AddScoped<IValidator<Category>, CategoryValidator>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDashboardService, DashboardService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            

            services.AddAutoMapper(assembly);
            services.AddValidatorsFromAssemblyContaining<ArticleValidator>();
           
            return services;
        }
    }
}