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

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=.; Database=BookStore; Integrated Security=True");
        //     base.OnConfiguring(optionsBuilder);
        // }
        // dont need after add in startup file
    }
}