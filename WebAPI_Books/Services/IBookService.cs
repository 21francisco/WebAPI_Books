using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Books.Models;

namespace WebAPI_Books.Services
{
    interface IBookService
    {


        public List<Books> GetBooks();


        public Books AddBook(Books book);

        public  Books GetBookByID(int Id);

        public Books  UpdateBookByID(int Id);

        public Books  DeleteBookByID(int id);



    }
}
