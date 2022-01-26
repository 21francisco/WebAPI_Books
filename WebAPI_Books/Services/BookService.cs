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
            Console.WriteLine(wb.UploadString(CLARO_API, "POST", book));
            Console.WriteLine("Book: {0}", book);
            return wb.UploadString(CLARO_API, "POST", book);
        }

        public string DeleteBookByID(string id)
        {
           
            string method = "Delete";
            WebClient client = new WebClient();
            string response = client.UploadString(CLARO_API,method,id);

            Console.WriteLine("Delete");

            return response;

            
        }

        public string GetBookByID(int Id)
        {
            
            WebClient client = new WebClient();
            string response = client.DownloadString(CLARO_API);
            
            return response;

        }
        
        //Obtenemos la lista de libros
        public string  GetBooks()
        {
             
             WebClient client = new WebClient();
            string response = client.DownloadString(CLARO_API);

            return response;

            
        }

        public string UpdateBookByID(string book)
        {
            string method = "Put";
            var wb = new WebClient();
            wb.Headers.Add("Content-Type", "application/json");
            Console.WriteLine("Update");
            return wb.UploadString(CLARO_API,method,book);            
        }

        
    }
}

