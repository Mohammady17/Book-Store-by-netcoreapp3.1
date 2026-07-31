using Microsoft.EntityFrameworkCore;

namespace Book_api_core.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) 
            : base(options)
        {


        }
        public DbSet<Book> Books { get; set; }
    }
}