using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks() { 
            return DataSource();  
        }
        public BookModel GetBookById(long id) {
            return DataSource().Find(x => x.Id == id);
        }
        public List<BookModel> SearchBooks(string title, string author) {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(author)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id=1, Title="Mastering React.js", Author="Jason Brown" },
                new BookModel() { Id=2, Title="Beginning ASP.NET Core", Author="Amy Bront" },
                new BookModel() { Id=3, Title="Advanced Javascript", Author="Kurt Russell" },
                new BookModel() { Id=4, Title="Vue.js: The Complete Guide", Author="Mosh Hamedani" },
                new BookModel() { Id=5, Title="Ubuntu Server Administration", Author="Brandon Huang" }
            };
            
        }
    }
}
