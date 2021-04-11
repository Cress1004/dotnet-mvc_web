using dotnet_mvc_web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace dotnet_mvc_web.Factory
{
    public class BookStoreContextFactory : IDesignTimeDbContextFactory<BookStoreContext>
    {
        public BookStoreContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookStoreContext>();
            optionsBuilder.UseSqlServer("User ID=sa; password=Th@nh1004; Server=localhost; Database=BookStore; Trusted_Connection=False;");
            // optionsBuilder.UseMySQL("server=localhost;userid=root;password=;database=BookStore");
            return new BookStoreContext(optionsBuilder.Options);
        }
    }
}