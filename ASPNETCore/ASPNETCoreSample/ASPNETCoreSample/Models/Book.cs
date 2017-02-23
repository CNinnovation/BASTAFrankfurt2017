using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreSample.Models
{
    public class Book
    {
        public Book(int bookId, string title, string publisher)
        {
            BookId = bookId;
            Title = title;
            Publisher = publisher;
        }
        public int BookId { get; }
        public string Title { get; }
        public string Publisher { get; }
        public override string ToString() => Title;
    }
}
