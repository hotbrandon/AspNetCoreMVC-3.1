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
        public List<BookModel> GetAllBooks()
        {
            return _repo.GetAllBooks();
        }

        public BookModel GetBookById(long id)
        {
            return _repo.GetBookById(id);
        }
        public List<BookModel> SearchBooks(string title, string author)
        {
            return _repo.SearchBooks(title, author);
        }
    }
}
