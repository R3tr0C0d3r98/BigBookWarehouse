using BigBookWarehouse.Core.Services.Books;
using BigBookWarehouse.DAL.Models.Books;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigBookWarehouse.Web.Pages
{
    public partial class BookPage : ComponentBase
    {
        [Inject]
        public IBookService BookService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int Id { get; set; }

        private Book book;

        protected override void OnInitialized()
        {
            book = BookService.GetBook().FirstOrDefault(x => x.Id == Id);
            if (book == null)
            {
                NavigationManager.NavigateTo("/");
                return;
            }
        }
    }
}
