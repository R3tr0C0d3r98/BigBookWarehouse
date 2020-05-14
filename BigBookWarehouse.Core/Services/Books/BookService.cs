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
                new Book{Id = 0, Title = "Test Book", Author = "Random Author", Rating = 10},
                new Book{Id = 1, Title = "Example Book", Author = "Example Author", Rating = 15},
                new Book{Id = 2, Title = "Best Book", Author = "Best Author", Rating = 1}
            };  
        }
    }
}
