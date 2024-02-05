using BookStore.Models.Requests;
using BookStore.Models.Responses;
using System;


namespace BookStore.BL.Interfaces
{
    public interface ILibraryService
    {
        GetAllBooksByAuthorResponse?
            GetAllBooksByAuthorAfterDate(GetAllBooksByAuthorRequest request);
    }
}