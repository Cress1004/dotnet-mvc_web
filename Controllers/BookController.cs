using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet_mvc_web.Models;

namespace dotnet_mvc_web.Controllers
{
    public class BookController : Controller
    {
        public string getAllBooks()
        {
            return "This is all books";
            // https://localhost:5001/book/getallbook
        }

        public string getBook(int id) 
        {
            return $"Book with id={id}";
            // https://localhost:5001/book/getbook/1
        }
        public string searchBooks(string bookName, string authorName) 
        {
            return $"Book with name = {bookName} & authorName = {authorName}"
            // https://localhost:5001/book/searchbooks?bookName=cress&authorName=crescentmoon
        }
    }
}
