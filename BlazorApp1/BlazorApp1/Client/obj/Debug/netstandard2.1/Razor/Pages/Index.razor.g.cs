#pragma checksum "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2355b4c4fd6f519eeb773f8914ca105203db665"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Products</h1>\r\n\r\n    ");
            __builder.OpenComponent<BlazorApp1.Client.Pages.FilterComponent>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n    \r\n");
#nullable restore
#line 8 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
     foreach (var product in products)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenComponent<BlazorApp1.Client.Pages.ProductComponent>(7);
            __builder.AddAttribute(8, "product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp1.Shared.Product>(
#nullable restore
#line 10 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
                                  product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 11 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\Index.razor"
       

    List<Product> products = new List<Product>
    {
        new Product(1,"Prod1","Details",2.5),
        new Product(2,"Prod2","Details",2.3),
        new Product(3,"Prod3","Details",5.1),
        new Product(3,"Prod3","Details",5.1),
        new Product(3,"Prod3","Details",5.1),

    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
