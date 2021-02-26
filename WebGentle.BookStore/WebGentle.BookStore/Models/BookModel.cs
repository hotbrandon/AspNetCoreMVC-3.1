﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle.BookStore.Models
{
    public class BookModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Detail { get; set; }
    }
}
