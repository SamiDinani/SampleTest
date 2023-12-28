using Microsoft.EntityFrameworkCore;
using Sample.Models;

namespace Sample.Repositories;

public interface IBookRepository
{
    Task<IEnumerable<Book>> GetAllBooksAsync();  
}

public class BookRepository : IBookRepository
{
    private readonly ApplicationDbContext _context;

    public BookRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Book>> GetAllBooksAsync()
    {
        return await _context.Books.ToListAsync();
    }
}


