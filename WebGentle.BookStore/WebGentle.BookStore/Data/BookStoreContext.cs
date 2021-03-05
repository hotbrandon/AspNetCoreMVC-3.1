using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebGentle.BookStore.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {

        }
        public DbSet<Books> Books { get; set; }

        // this method is not required if the connection string is configured in Startup.cs
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("server=192.168.124.31;user=demo;password=demo;database=demo");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
