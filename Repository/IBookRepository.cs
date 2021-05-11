using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_mvc_web.Models;

namespace dotnet_mvc_web.Repository
{
    public interface IBookRepository
    {
        Task<int> AddNewBook(BookModel model);
        Task<List<BookModel>> GetAllBooks();
        Task<BookModel> GetBookById(int id);
        Task<List<BookModel>> GetTopBooksAsync(int count);
        string GetAppName();
    }
}