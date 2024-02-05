using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Responses
{
    public class GetAllBooksByAuthorResponse
    {
        public object? Books;

        public object? Author { get; set; }
    }
}
