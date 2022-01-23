using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebAPI_Books.Models;

namespace WebAPI_Books.Services
{

    
   
    public class BookService : IBookService
    { 
         private string CLARO_API = "https://fakerestapi.azurewebsites.net/api/v1/Books";


        public string AddBook(string book)
        {
            var wb = new WebClient();
            wb.Headers.Add("Content-Type", "application/json");
            return wb.UploadString(CLARO_API, book);
            
        }

        public Books DeleteBookByID(int id)
        {
            throw new NotImplementedException();
        }

        public string GetBookByID(int Id)
        {
            string url = "https://fakerestapi.azurewebsites.net/api/v1/Books/" + Id;
            WebClient client = new WebClient();
            string response = client.DownloadString(url);

            return response;

        }
        
        //Obtenemos la lista de libros
        public string  GetBooks()
        {
             string url = "https://fakerestapi.azurewebsites.net/api/v1/Books";
             WebClient client = new WebClient();
            string response = client.DownloadString(url);

            return response;

            
        }

        public Books UpdateBookByID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

