using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Data;
using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _ctx = null;
        public BookRepository(BookStoreContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<long> AddBook(BookModel model)
        {
            var book = new Books();
            book.Title = model.Title;
            book.Author = model.Author;
            book.Detail = model.Detail;
            book.CreateOn = DateTime.UtcNow;

            await _ctx.Books.AddAsync(book);
            await _ctx.SaveChangesAsync();

            return book.Id;
        }
        public async Task<List<BookModel>> GetAllBooks() {
            var bookList = new List<BookModel>();
            var bookData = await _ctx.Books.ToListAsync();

            if(bookData?.Any() == true)
            {
                foreach(var book in bookData)
                {
                    bookList.Add(new BookModel
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Author = book.Author,
                        Detail = book.Detail
                    });
                }
            }
            return bookList;
        }
        public async Task<BookModel> GetBookById(long id) {
            var book = await _ctx.Books.FindAsync(id);
            if(book != null)
            {
                return new BookModel
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = book.Author,
                    Detail = book.Detail
                };
            }
            return null;
        }
        public async Task<List<BookModel>> SearchBooks(string title, string author) {
            var bookList = new List<BookModel>();
            var bookData = await _ctx.Books.Where(
                x => (x.Title.Contains(title) || x.Author.Contains(author))
                ).ToListAsync();

            if (bookData?.Any() == true)
            {
                foreach (var book in bookData)
                {
                    bookList.Add(new BookModel
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Author = book.Author,
                        Detail = book.Detail
                    });
                }
            }
            return bookList;
        }
        
    }
}
