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
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id=1, Title="Mastering React.js", Author="Jason Brown", 
                                Detail=$"Both new and seasoned developers are using it to build app front-ends " +
                                $"that are fast, dynamic and stand out. If you want to see what React apps are like, " +
                                $"just think of the big popular sites like Facebook, Instagram, Netflix, Yahoo, the list goes on…" },
                new BookModel() { Id=2, Title="Beginning ASP.NET Core", Author="Amy Bront",
                                Detail=$"This course is thoroughly practical, focusing on getting started with ASP.NET Core 3.0 " +
                                $"and the .NET Core 3.0 framework, and putting them into practice to build an amazing web application." +
                                $" This course will teach you the essentials for getting started in ASP.NET Core 3.0. You will learn " +
                                $"to take advantage of the various features of the framework and work with the well-known code editor, " +
                                $"Visual Studio Code."
                                },
                new BookModel() { Id=3, Title="Advanced Javascript", Author="Kurt Russell",
                                Detail=$"Main course contains 2 parts which cover JavaScript as a programming language and working with a " +
                                $"browser. There are also additional series of thematic articles."
                                },
                new BookModel() { Id=4, Title="Vue.js: The Complete Guide", Author="Mosh Hamedani",
                                Detail=$"If you’d like to learn more about Vue before diving in, we created a video walking through the core " +
                                $"principles and a sample project."},
                new BookModel() { Id=5, Title="Ubuntu Server Administration", Author="Brandon Huang",
                                   Detail=$"The official guide assumes intermediate level knowledge of HTML, CSS, and JavaScript. If you are totally " +
                                   $"new to frontend development, it might not be the best idea to jump right into a framework as your first step - grasp " +
                                   $"the basics then come back! Prior experience with other frameworks helps, but is not required."
                                }
            };
            
        }
    }
}
