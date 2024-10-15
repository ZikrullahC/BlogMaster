using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using YoutubeBlog.Core.Entities;
using YoutubeBlog.Data.Context;

namespace YoutubeBlog.Data.Repositories.Concretes
{
    public class Repository<T> where T : class, IEntityBase, new()  
    {
        private readonly AppDbContext dbContext;

        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }


        //Bu parametre, bir filtreleme ifadesini(predicate) temsil eder.Expression<Func<T, bool>> bir lambda ifadesidir.Örneğin, x => x.Age > 18 şeklinde bir filtreleme yapılabilir.
        //Bu ifade null olabilir, bu durumda hiçbir filtreleme yapılmaz ve tüm veriler getirilir.Eğer filtre belirtilmişse, bu filtre fonksiyona veritabanında hangi verilerin alınacağını söyler.
        
        //Bu fonksiyonda kullanilan predicate ile getirilecek verilere sorgu ile kisit koyulabilir.
        //includeProperties ile de tablo ile iliskili veri tabanlari da cekilebilir. (Eager Loading)
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if (predicate != null)
                query = query.Where(predicate);

            if (includeProperties.Any())
                foreach (var item in includeProperties)
                    query = query.Include(item);
            return await query.ToListAsync();
        }

        //Task = void (asenkron fonksiyonlar icin)
        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }
    }
}
