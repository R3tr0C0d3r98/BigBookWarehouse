using BigBookWarehouse.DAL.Models.Books;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BigBookWarehouse.Core.Services.Books
{
    public interface IBookService
    {
        Book[] GetBook();
    }
    public class BookService : IBookService
    {
        public Book[] GetBook()
        {
            return new Book[]
            {
                new Book{Id = 0, Title = "Test Book", Overview = "Random Overview", Price = 10},
                new Book{Id = 1, Title = "Example Book", Overview = "Example Overview", Price = 100},
                new Book{Id = 2, Title = "Best Book", Overview = "Best Overview", Price = 1}
            };  
        }
    }
}
