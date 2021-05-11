using System.Linq;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotnet_mvc_web.Models;
using dotnet_mvc_web.Repository;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;


namespace dotnet_mvc_web.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        private readonly LanguageRepository _languageRepository = null;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BookController(
            BookRepository bookRepository, 
            LanguageRepository languageRepository,
            IWebHostEnvironment webHostEnvironment
         ) {
            _bookRepository = bookRepository;
            _languageRepository = languageRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        [Route("all-books")]
        public async Task<ViewResult> GetAllBooks()
        {
            var data = await _bookRepository.GetAllBooks();
            return View(data);
            // https://localhost:5001/book/getallbook
        }


        [Route("book-details/{id:int:min(1)}", Name = "bookDetailsRoute")]
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

        public async Task<ViewResult> AddNewBookAsync(bool isSuccess = false, int bookId = 0)
        {
            ViewBag.Language = new SelectList(await _languageRepository.GetLanguages(), "Id", "Name");
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if(bookModel.CoverPhoto != null)
            {
                string folder = "books/covers/";
                bookModel.CoverImageUrl = await UploadImage(folder, bookModel.CoverPhoto);
            }

            if(bookModel.GalleryFiles != null)
            {
                string folder = "books/gallery/";
                bookModel.Gallery = new List<GalleryModel>();

                foreach(var file in bookModel.GalleryFiles)
                {
                    var gallery = new GalleryModel()
                    {
                        Name = file.FileName,
                        URL = await UploadImage(folder, file),
                    };
                    bookModel.Gallery.Add(gallery);
                }
            }

            if(bookModel.BookPdf != null)
            {
                string folder = "books/pdf/";
                bookModel.BookPdfUrl = await UploadImage(folder, bookModel.BookPdf);
            }

            if (ModelState.IsValid)
            {
                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
            }

            ViewBag.Language = new SelectList(await _languageRepository.GetLanguages(), "Id", "Name");
            
            return View();
        }
        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {
             
            folderPath += file.FileName;
            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderPath;
        }
    }
}