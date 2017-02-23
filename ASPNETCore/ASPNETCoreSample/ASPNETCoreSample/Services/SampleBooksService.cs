using ASPNETCoreSample.Models;
using System.Collections.Generic;

namespace ASPNETCoreSample.Services
{
    public class SampleBooksService : IBooksService
    {
        private List<Book> _books = new List<Book>
        {
            new Book(1, "Professional C# 6 and .NET Core 1.0", "Wrox Press"),
            new Book(2, "Professional C# 7.1 and .NET Core 2.0", "Wrox Press")
        };

        public IEnumerable<Book> GetBooks() => _books;
    }
}
