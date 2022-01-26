using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Mime;
using System.Text.Json;
using WebAPI_Books.Services;

namespace WebAPI_Books.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private IBookService _bookService;

        public BookController(IBookService bookService)

        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<string> IndeX()
        {
            return _bookService.GetBooks();
        }

        [HttpPost]
        public ActionResult<string> AddBook([FromBody] JsonElement bookAsJson)
        {
            Console.WriteLine(bookAsJson.ToString());
            return _bookService.AddBook(bookAsJson.ToString());

        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult<string> GetBookById(int id)
        {
            return _bookService.GetBookByID(id);
        }

        
        [HttpPut]
        public ActionResult<string> UpdateBookByID([FromBody] JsonElement bookAsJson)
        {

            return _bookService.UpdateBookByID(bookAsJson.ToString());
        }

        [Route("{id}")]
        [HttpDelete]

        public ActionResult<string> DeleteDeleteBookByID(string id)         
        {
           
            return _bookService.DeleteBookByID(id);
            
        }


    }
}
