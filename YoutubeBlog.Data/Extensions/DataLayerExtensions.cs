using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repositories.Abstractions;
using YoutubeBlog.Data.Repositories.Concretes;
using YoutubeBlog.Data.UnitOfWorks;

namespace YoutubeBlog.Data.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
        {
            //Bu metot IRepository'ye her talep geldiginde Repository sinifinin bir orneginin verilmesini saglar.
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //Burada AppDbContext sinifina Dependency Injection uygulaniyor.
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
