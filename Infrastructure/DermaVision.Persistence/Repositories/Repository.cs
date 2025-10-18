using DermaVision.Application.Interfaces;
using DermaVision.Persistence.Context;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();

        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
