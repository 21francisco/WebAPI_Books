using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebAPI_Books.Models;

namespace WebAPI_Books.Services
{

    
   
    public class BookService : IBookService

        {
        public Books AddBook(Books book)
        {
            throw new NotImplementedException();
        }

        public Books DeleteBookByID(int id)
        {
            throw new NotImplementedException();
        }

        public Books GetBookByID(int Id)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        //Obtenemos la lista de libros
        public  List<Books> GetBooks(Books book)
        {
             var url = "https://fakerestapi.azurewebsites.net/api/v1/Books";
             HttpClient client  = new HttpClient();

            return await(Books);
        }

        public Books UpdateBookByID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

