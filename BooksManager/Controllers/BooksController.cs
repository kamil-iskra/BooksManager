﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
