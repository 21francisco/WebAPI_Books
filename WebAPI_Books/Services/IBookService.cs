using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Books.Models;

namespace WebAPI_Books.Services
{
     public interface IBookService
    {


        public string GetBooks();

        public string AddBook(string book);

        public  string GetBookByID(int Id);

        public Books  UpdateBookByID(int Id);

        public Books  DeleteBookByID(int id);



    }
}
