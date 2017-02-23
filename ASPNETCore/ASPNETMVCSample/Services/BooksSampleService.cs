using BooksLib;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASPNETMVCSample.Services
{
    public class BooksSampleService : IBooksService
    {
        private readonly List<Book> _books = new List<Book>();
        public BooksSampleService() => InitBooks();

        private void InitBooks()
        {
            _books.AddRange(new Book[]
            {
                new Book(1, "Professional C# 6 and .NET Core 1.0", "Wrox Press"),
                new Book(2, "Enterprise Services", "AWL"),
                new Book(3, "Professional C# 5 and .NET 4.5.1", "Wrox Press")
            });
        }
        public Task<IEnumerable<Book>> GetBooksAsync() =>
            Task.FromResult<IEnumerable<Book>>(_books);
    }
}
