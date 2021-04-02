using System;
using System.Collections.Generic;
using System.Linq;
using dotnet_mvc_web.Models;

namespace dotnet_mvc_web.Repository 
{
    public class BookRepository
    {
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
                new BookModel() {Id = 2, Title = "Scarlet", Author = "Scarling", Description = "The Lunar Chronicles chap 2"},
                new BookModel() {Id = 2, Title = "Winter", Author = "Winter", Description = "The Lunar Chronicles chap 4"}
            };
        }
    }
}