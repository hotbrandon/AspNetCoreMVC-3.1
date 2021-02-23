using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        public string FindBooks(string author, string bookName)
        {
            return $"author:{author}, Book Name:{bookName}";
        }
    }
}
