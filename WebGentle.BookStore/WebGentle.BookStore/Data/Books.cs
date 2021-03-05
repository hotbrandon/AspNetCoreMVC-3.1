using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle.BookStore.Data
{
    public class Books
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Detail { get; set; }
        public DateTime? CreateOn { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
