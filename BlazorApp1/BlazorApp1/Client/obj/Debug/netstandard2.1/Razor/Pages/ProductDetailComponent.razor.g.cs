#pragma checksum "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f10a6aca2927eb55cbe81f5bce5c35f6064be4b8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/{id:int}")]
    public partial class ProductDetailComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "\r\nproduct detail ");
            __builder.AddContent(1, 
#nullable restore
#line 3 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"
                id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "\r\n");
            __builder.AddMarkupContent(3, @"<div class=""card"" style=""width: 18rem; margin:15px;"">
    <img class=""card-img-top"" src=""..."" alt=""Card image cap"">
    <div class=""card-body"">
        <h5 class=""card-title"">Name</h5>
        <p class=""card-text"">Description</p>
        <p class=""card-text""><b>Price</b></p>
        <p class=""card-text"">Shop Address</p>
        <p class=""card-text"">Phone#</p>   
    </div>
</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"
       
    [Parameter]
    public int id { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
