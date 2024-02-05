using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using BookStore_C.BL.Interfaces;


namespace BookStore_C.BL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> GetAllBooksByAuthor(int authorId)
        {
            return _bookRepository.GetAllBooksByAuthor(authorId);
        }
    }
}
