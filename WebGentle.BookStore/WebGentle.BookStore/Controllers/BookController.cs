using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Models;
using WebGentle.BookStore.Repository;

namespace WebGentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private BookRepository _repo;
        public BookController()
        {
            _repo = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var books =_repo.GetAllBooks();
            return View(books);
        }

        public ViewResult GetBook(long id)
        {
            var book = _repo.GetBookById(id);
            return View(book);
        }
        public ViewResult SearchBooks(string title, string author)
        {
            var books = _repo.SearchBooks(title, author);
            return View(books);
        }

        public ViewResult AddBook()
        {
            return View();
        }
    }
}
