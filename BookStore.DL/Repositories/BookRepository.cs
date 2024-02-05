using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using BookStore.Models.Requests;
using BookStore.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Repositories
{
    public class BookRepository : IBookRepository
    {

        public GetAllBooksByAuthorResponse GetAllBooksByAuthor(GetAllBooksByAuthorRequest request)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByAuthor(int authorId)
        {
            throw new NotImplementedException();
        }
    }
}
