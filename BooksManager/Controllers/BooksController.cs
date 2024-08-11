using BooksManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BooksManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookDbContext _bookContext;
        public BooksController(BookDbContext bookContext)
        {
            _bookContext = bookContext;
;
        }

        // Get : api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            if (_bookContext.Books == null)
            {
                return NotFound();
            }
            return await _bookContext.Books.ToListAsync();
        }
    }
}
