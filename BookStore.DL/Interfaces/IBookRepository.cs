using BookStore.Models.Models;
using BookStore.Models.Requests;
using BookStore.Models.Responses;

namespace BookStore.DL.Interfaces
{
    public interface IBookRepository
    {
        GetAllBooksByAuthorResponse GetAllBooksByAuthor(GetAllBooksByAuthorRequest request);
        List<Book> GetAllBooksByAuthor(int authorId);
    }
}
