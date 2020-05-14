using BigBookWarehouse.Core.Services.Books;
using BigBookWarehouse.DAL.Models.Books;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigBookWarehouse.Web.Pages
{
    public partial class BooksPage : ComponentBase
    {
        [Inject]
        public IBookService BookService { get; set; }

        private Book[] books;

        protected override void OnInitialized()
        {
            books = BookService.GetBook();
        }
    }
}
