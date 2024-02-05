﻿using BookStore.BL.Interfaces;
using BookStore.Models.Requests;
using BookStore.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpPost("GetBooksByAuthor")]
        public GetAllBooksByAuthorResponse?
            GetBooksByAuthor(GetAllBooksByAuthorRequest request)
        {
            if (request == null) return null;

            return _libraryService.GetAllBooksByAuthorAfterDate(request);
        }

        [HttpPost("TestEndpoint")]
        public string GetTestEndpoint(
            [FromBody] TestRequest request)
        {
            return "Test OK";
        }

    }
}