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
            optionsBuilder.UseSqlServer("Server=.; Database=BookStore; Integrated Security=True; Trusted_Connection=True");
            // optionsBuilder.UseMySQL("server=localhost;userid=root;password=;database=BookStore");
            return new BookStoreContext(optionsBuilder.Options);
        }
    }
}