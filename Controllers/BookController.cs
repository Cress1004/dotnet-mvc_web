using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotnet_mvc_web.Models;
using dotnet_mvc_web.Repository;

namespace dotnet_mvc_web.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        
        public BookController() 
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
            // return "This is all books";
            // https://localhost:5001/book/getallbook
        }


        [Route("book-details/{id}", Name="bookDetailsRoute")]
        public ViewResult GetBook(int id) 
        {
            var data = _bookRepository.GetBookById(id);
            
            return View(data);
            // return $"Book with id={id}";
            // https://localhost:5001/book/getbook/1
        }
        public List<BookModel> SearchBooks(string bookName, string authorName) 
        {
            return _bookRepository.SearchBooks(bookName, authorName);
            // return $"Book with name = {bookName} & authorName = {authorName}"
            // https://localhost:5001/book/searchbooks?bookName=cress&authorName=crescentmoon
        }
    }
}
