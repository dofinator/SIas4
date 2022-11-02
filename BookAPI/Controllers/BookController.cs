using BookAPI.Models;
using BookAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }


        [HttpGet]
        public async Task<List<Book>> GetAllBooks()
        {
            return await _bookService.GetAllBooks();
        }
    }
}
