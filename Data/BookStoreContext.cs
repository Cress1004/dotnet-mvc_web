using Microsoft.EntityFrameworkCore;

namespace dotnet_mvc_web.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Language> Language { get; set; }
    }
}