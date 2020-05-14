using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigBookWarehouse.Web.Pages
{
    public partial class RoutingPage : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int Id { get; set; }
        private void GoToNextIndex()
        {
            NavigationManager.NavigateTo($"/routing/{Id + 1}");
        }
    }
}
