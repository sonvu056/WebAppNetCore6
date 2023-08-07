using Microsoft.EntityFrameworkCore;

namespace WebAppNetCore6.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) 
        { 
        }

        #region DbSet
        public DbSet<Book> Books { get; set;}
        #endregion
    }
}
