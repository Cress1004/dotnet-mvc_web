using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_mvc_web.Data;
using dotnet_mvc_web.Models;

namespace dotnet_mvc_web.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _context = null;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreateOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                TotalPages = model.TotalPages,
                UpdateOn = DateTime.UtcNow,
            };
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();
            
            return newBook.Id;
        }
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBooks(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() {Id = 1, Title = "Cress", Author = "CrescentMoon", Description = "The lunar chronicles chap 3", Category = "The lunar chronicles", Language = "English", TotalPages = 120},
                // new BookModel() {Id = 2, Title = "Scarlet", Author = "Scarling", Description = "The Lunar Chronicles chap 2"},
                // new BookModel() {Id = 3, Title = "Winter", Author = "Winter", Description = "The Lunar Chronicles chap 4"}
            };
        }
    }
}