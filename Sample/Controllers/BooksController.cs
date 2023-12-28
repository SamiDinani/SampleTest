using Microsoft.AspNetCore.Mvc;
using Sample.Models;
using Sample.Services;

namespace Sample.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public async Task<IEnumerable<Book>> Get()
    {
        return await _bookService.GetAllBooksAsync();
    }
}

