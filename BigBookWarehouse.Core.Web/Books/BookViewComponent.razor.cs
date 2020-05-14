using BigBookWarehouse.DAL.Models.Books;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigBookWarehouse.Core.Web.Books
{
    public partial class BookViewComponent : ComponentBase
    {
        [Parameter]
        public Book Book { get; set; }
    }
}
