#pragma checksum "C:\Users\ajame\Desktop\Csharp\FinalProject\BigBookWarehouse\BigBookWarehouse\Pages\RoutingPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dc4887981654419703b7d50dd1e6995c9d21180"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BigBookWarehouse.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ajame\Desktop\Csharp\FinalProject\BigBookWarehouse\BigBookWarehouse\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ajame\Desktop\Csharp\FinalProject\BigBookWarehouse\BigBookWarehouse\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ajame\Desktop\Csharp\FinalProject\BigBookWarehouse\BigBookWarehouse\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ajame\Desktop\Csharp\FinalProject\BigBookWarehouse\BigBookWarehouse\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ajame\Desktop\Csharp\FinalProject\BigBookWarehouse\BigBookWarehouse\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ajame\Desktop\Csharp\FinalProject\BigBookWarehouse\BigBookWarehouse\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ajame\Desktop\Csharp\FinalProject\BigBookWarehouse\BigBookWarehouse\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ajame\Desktop\Csharp\FinalProject\BigBookWarehouse\BigBookWarehouse\_Imports.razor"
using BigBookWarehouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ajame\Desktop\Csharp\FinalProject\BigBookWarehouse\BigBookWarehouse\_Imports.razor"
using BigBookWarehouse.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/routing/{Id:int}")]
    public partial class RoutingPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\ajame\Desktop\Csharp\FinalProject\BigBookWarehouse\BigBookWarehouse\Pages\RoutingPage.razor"
       
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [Parameter]
    public int Id { get; set; }
    private void GoToNextIndex()
    {
        NavigationManager.NavigateTo($"/routing/{Id + 1}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591