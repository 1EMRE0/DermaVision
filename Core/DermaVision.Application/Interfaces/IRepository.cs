using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DermaVision.Application.Interfaces
{
    public interface IRepository<T> where T: class //IRepository veri tabanı için contract oluşturur.
    {
        Task<List<T>> GetAllAsync(); //bu satır asenkron şeklinde tüm verileri getirir.
        Task<T> GetByIdAsync(int id); // id ye göre getirme işlemi.
        Task CreateAsync(T entity);//veritabanına nesne ekler. ör product
        Task UpdateAsync(T entity); //veri tabanındaki mevcut nesneyi günceller.
        Task RemoveAsync(T entity);
    }
}


//T sadece class entity alabilir.