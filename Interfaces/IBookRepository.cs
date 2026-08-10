using System.Collections.Generic;
using System.Threading.Tasks;
using Book_api_core.Models;

namespace Book_api_core.Interfaces
{
    public interface IBookRepository
    {
        Task<List<BookDetailsDto>> GetAllBooks();
        Task<BookDetailsDto> GetBookDetailsById(int id);
        Task<int> CreateBook(CreateBookDto model);
        Task<bool> UpdateBook(int id, UpdateBookDto model);
        Task<bool> RemoveBook(int id);
    }
}