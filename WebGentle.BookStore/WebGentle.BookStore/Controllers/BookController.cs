using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Data;
using WebGentle.BookStore.Models;
using WebGentle.BookStore.Repository;

namespace WebGentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private BookRepository _repo;

        public BookController(BookRepository repo)
        {
            _repo = repo;
        }
        public async Task<ViewResult> GetAllBooks()
        {
            var books = await _repo.GetAllBooks();
            return View(books);
        }

        public async Task<ViewResult> GetBook(long id)
        {
            var book = await _repo.GetBookById(id);
            return View(book);
        }
        public async Task<ViewResult> SearchBooks(string title, string author)
        {
            var books = await _repo.SearchBooks(title, author);
            return View("GetAllBooks",books);
        }

        public ViewResult AddBook(bool IsSuccess = false, long BookId = 0)
        {
            ViewBag.IsSuccess = IsSuccess;
            ViewBag.BookId = BookId;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBook(BookModel book)
        {
            if(ModelState.IsValid)
            {
                long id = await _repo.AddBook(book);
                if (id > 0)
                {
                    return RedirectToAction("AddBook", new { IsSuccess = true, BookId = id });
                }
            }
 
            return View();
        }
    }
}
