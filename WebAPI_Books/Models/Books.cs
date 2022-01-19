using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Books.Models
{
    public class Books
    {


        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int PageCount { get; set; }

        public string  Excerpt { get; set; }

        public string PublishDate { get; set; }
    }
}
