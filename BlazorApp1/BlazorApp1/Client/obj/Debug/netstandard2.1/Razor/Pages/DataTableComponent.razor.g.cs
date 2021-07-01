#pragma checksum "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f28131bffc938b0ee07ed5bdede7a3457b0ef4b"
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
#line 1 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
    public partial class DataTableComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableComponent.razor"
                  () => AddProduct()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "style", "float:right");
            __builder.AddContent(4, "Add Item");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "id", "example");
            __builder.AddAttribute(8, "class", "table table-striped table-bordered");
            __builder.AddAttribute(9, "style", "width:100%");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddMarkupContent(11, "<thead>\r\n        <tr>\r\n            <th>Product ID</th>\r\n            <th>Product Name</th>\r\n            <th>Product Details</th>\r\n            <th>Product Price</th>\r\n            <th>Manage Product</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n\r\n\r\n");
#nullable restore
#line 21 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableComponent.razor"
         foreach (Product product in products)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "            ");
            __builder.OpenComponent<BlazorApp1.Client.Pages.DataTableItemComponent>(15);
            __builder.AddAttribute(16, "product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp1.Shared.Product>(
#nullable restore
#line 23 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableComponent.razor"
                                             product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 24 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "\r\n\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.AddMarkupContent(20, "<tfoot>\r\n        <tr>\r\n            <th>Product ID</th>\r\n            <th>Product Name</th>\r\n            <th>Product Details</th>\r\n            <th>Product Price</th>\r\n            <th>Manage Product</th>\r\n        </tr>\r\n    </tfoot>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableComponent.razor"
       


    public List<Product> products = new List<Product>();

    protected override async Task OnInitializedAsync()
    {
        products = await Http.GetFromJsonAsync<List<Product>>("api/Product/VendorId/1");

    }

   

    void AddProduct()
    {
        UriHelper.NavigateTo("/AddProduct");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
