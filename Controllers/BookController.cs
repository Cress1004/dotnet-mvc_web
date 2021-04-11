using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotnet_mvc_web.Models;
using dotnet_mvc_web.Repository;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace dotnet_mvc_web.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<ViewResult> GetAllBooks()
        {
            var data = await _bookRepository.GetAllBooks();
            return View(data);
            // https://localhost:5001/book/getallbook
        }


        [Route("book-details/{id}", Name = "bookDetailsRoute")]
        public async Task<ViewResult> GetBook(int id)
        {
            var data = await _bookRepository.GetBookById(id);

            return View(data);
            // return $"Book with id={id}";
            // https://localhost:5001/book/getbook/1
        }
        // public List<BookModel> SearchBooks(string bookName, string authorName)
        // {
        //     return _bookRepository.SearchBooks(bookName, authorName);
        //     // return $"Book with name = {bookName} & authorName = {authorName}"
        //     // https://localhost:5001/book/searchbooks?bookName=cress&authorName=crescentmoon
        // }

        public ViewResult AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            ViewBag.Language = new SelectList(new List<string>() {
                "Vietnamese", "Japanese", "English"
            });
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
                return View();
            }

            ViewBag.Language = new SelectList(new List<string>(){
                "Vietnamese", "Japanese", "English"
            }); 

            ModelState.AddModelError("", "My error message");
            ModelState.AddModelError("", "My second error message");

            return View();
        }
    }
}
