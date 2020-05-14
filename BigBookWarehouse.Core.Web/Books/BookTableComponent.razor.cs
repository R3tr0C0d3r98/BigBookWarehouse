using BigBookWarehouse.DAL.Models.Books;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigBookWarehouse.Core.Web.Books
{
    public partial class BookTableComponent : ComponentBase
    {
        [Parameter]
        public IEnumerable<Book> Books { get; set; }
    }
}
