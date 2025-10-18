using DermaVision.Application.Interfaces;
using DermaVision.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaVision.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DermaVisionContext _context; //ef core da repositorynin veritabanı işlemleri yapabilmesi için contextbağımlılığı nesnesi oluşturdum.

        public Repository(DermaVisionContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity); //Set<T> veritabanındaki T türüne karşılık gelen DbSet’i (tabloyu) döndürür.
            await _context.SaveChangesAsync();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
