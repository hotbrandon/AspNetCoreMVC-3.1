using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebGentle.BookStore.Models
{
    public class BookModel
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "需要 Title")]
        [StringLength(100, MinimumLength = 10, ErrorMessage="Title 至少 10 個字")]
        public string Title { get; set; }
        [Required(ErrorMessage = "需要 Author")]
        public string Author { get; set; }
        [Required(ErrorMessage = "需要 Detail")]
        [StringLength(100)]
        [Display(Name ="詳細介紹")]
        public string Detail { get; set; }
    }
}
