using BooksManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksManager
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; } = null!;
    }
}
