using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppNetCore6.Models;
using WebAppNetCore6.Repositories;

namespace WebAppNetCore6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IBookRepository _bookRepo;

        public ProductsController(IBookRepository repo) {
            _bookRepo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            try
            {
                return Ok(await _bookRepo.GetAllBooksAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBodyById(int id)
        {
            var book = await _bookRepo.GetBookAsync(id);
            return book == null ? NotFound() : Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel model)
        {
            try
            {
                var newBookId = await _bookRepo.AddBookAsync(model);
                var book = await _bookRepo.GetBookAsync(newBookId);
                return book == null ? NotFound() : Ok(book);
            }
            catch 
            {
                return BadRequest();
            }
        }
    }
}
