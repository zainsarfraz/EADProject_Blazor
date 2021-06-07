#pragma checksum "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21a1e652cd76e2ab860f11363317c58dfae358bf"
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
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "mb-5");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, @"<div class=""col-md-6 mb-4 mb-md-0"">

            <div id=""mdb-lightbox-ui""></div>

            <div class=""mdb-lightbox"">

                <div class=""row product-gallery mx-1"">

                    <div class=""col-12"">
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""view overlay rounded z-depth-1 gallery-item"">
                                    <img src=""https://mdbootstrap.com/img/Photos/Horizontal/E-commerce/Vertical/15a.jpg"" class=""img-fluid"">
                                    <div class=""mask rgba-white-slight""></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>
        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-6");
            __builder.AddMarkupContent(9, "\r\n\r\n            ");
            __builder.OpenElement(10, "h5");
            __builder.AddContent(11, 
#nullable restore
#line 35 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"
                 product.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
#nullable restore
#line 37 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"
             if (categories == null)
            { }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"
                 foreach (Category category in categories)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                    ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "class", "mb-2 text-muted text-uppercase small");
            __builder.AddContent(16, 
#nullable restore
#line 43 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"
                                                                     category.categoryName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " , ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 44 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "\r\n\r\n\r\n            ");
            __builder.OpenElement(20, "p");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "class", "mr-1");
            __builder.OpenElement(23, "strong");
            __builder.AddContent(24, 
#nullable restore
#line 50 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"
                                           product.price

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " $");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "p");
            __builder.AddAttribute(28, "class", "pt-1");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.AddContent(30, 
#nullable restore
#line 52 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"
                 product.description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "table-responsive");
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "table");
            __builder.AddAttribute(37, "class", "table table-sm table-borderless mb-0");
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "tbody");
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "tr");
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.AddMarkupContent(43, "<th class=\"pl-0 w-25\" scope=\"row\"><strong>Contact Number</strong></th>\r\n                            ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 59 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"
                                 product.shop.vendor.contact

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "tr");
            __builder.AddMarkupContent(49, "\r\n                            ");
            __builder.AddMarkupContent(50, "<th class=\"pl-0 w-25\" scope=\"row\"><strong>Shop Address</strong></th>\r\n                            ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 63 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"
                                 product.shop.details

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            <hr>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\ProductDetailComponent.razor"
       
    [Parameter]
    public int id { get; set; }

    public Product product = new Product();
    public List<Category> categories = new List<Category>();

    protected override async Task OnInitializedAsync()
    {
        product = await Http.GetFromJsonAsync<Product>($"api/Product/{id}");
        categories = await Http.GetFromJsonAsync<List<Category>>($"api/Category/{id}");

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
