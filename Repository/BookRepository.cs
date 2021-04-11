using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_mvc_web.Data;
using dotnet_mvc_web.Models;
using Microsoft.EntityFrameworkCore;

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
                TotalPages = model.TotalPages.HasValue ? model.TotalPages.Value : 0,
                UpdateOn = DateTime.UtcNow,
            };
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            return newBook.Id;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>();
            var allBooks = await _context.Books.ToListAsync();
            if (allBooks?.Any() == true)
            {
                foreach (var book in allBooks)
                {
                    books.Add(new BookModel()
                    {
                        Author = book.Author,
                        Category = book.Category,
                        Description = book.Description,
                        Id = book.Id,
                        Language = book.Language,
                        Title = book.Title,
                        TotalPages = book.TotalPages,
                    });
                }
            }
            return books;
        }

        public async Task<BookModel> GetBookById(int id)
        {
            // var allBooks = await _context.Books.ToListAsync();
            // if (allBooks?.Any() == true)
            // {
            //     bookDetails = allBooks.Where(x => x.Id == id).FirstOrDefault();
            //     var book = new BookModel(){
            //     ...
            //     };
            // }
            // return book;
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                var bookDetails = new BookModel()
                {
                    Author = book.Author,
                    Category = book.Category,
                    Description = book.Description,
                    Id = book.Id,
                    Language = book.Language,
                    Title = book.Title,
                    TotalPages = book.TotalPages,
                };
                return bookDetails;
            }
            return null;
        }

        // public List<BookModel> SearchBooks(string title, string authorName)
        // {
        //     return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        // }
    }
}