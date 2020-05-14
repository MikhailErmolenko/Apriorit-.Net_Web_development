using ConsoleApp7.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Infrastructure
{
    public interface IDataProvider<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(int id);
        Task<bool> RemoveAsync(TEntity b);
        Task<bool> AddAsync(TEntity b);

    }
}
