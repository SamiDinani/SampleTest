using Sample.Models;
using Sample.Repositories;

namespace Sample.Services;

public interface IBookService
{
    Task<IEnumerable<Book>> GetAllBooksAsync();
}

public class BookService : IBookService
{
    private readonly IBookRepository _repository;

    public BookService(IBookRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Book>> GetAllBooksAsync()
    {
        return await _repository.GetAllBooksAsync();
    }
}


