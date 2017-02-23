using ASPNETCoreSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreSample.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetBooks();
    }
}
