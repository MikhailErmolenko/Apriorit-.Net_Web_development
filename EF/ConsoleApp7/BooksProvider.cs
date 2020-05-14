using ConsoleApp7.NEDatabase;
using ConsoleApp7.Infrastructure;
using ConsoleApp7.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class BooksProvider : IDataProvider<Book>
    {
        private readonly ApplicationContext db;

        public BooksProvider(ApplicationContext db)
        {
            this.db = db;
        }

        public Task<bool> AddAsync(Book b) => Task.FromResult(db.Books.Add(b) != null ? true : false);

        public async Task<Book> GetAsync(int id) => await db.Books.FindAsync(id);

        public async Task<IEnumerable<Book>> GetAllAsync() => await db.Books.ToListAsync();

        public Task<bool> RemoveAsync(Book b) => Task.FromResult(db.Books.Remove(b) != null ? true : false);
    }
}
