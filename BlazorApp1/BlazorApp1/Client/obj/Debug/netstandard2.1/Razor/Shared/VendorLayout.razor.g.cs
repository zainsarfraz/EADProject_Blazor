#pragma checksum "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Shared\VendorLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95705003e7b0235d858155a5cbe223d88319cd40"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Client.Shared
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
    public partial class VendorLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "bs-example");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "nav");
            __builder.AddAttribute(7, "class", "navbar navbar-expand-md navbar-light bg-light");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<a href=\"/Dashboard\" class=\"navbar-brand\">\r\n                <img src=\"/Images/logo.png\" height=\"50\" width=\"50\">\r\n            </a>\r\n\r\n            ");
            __builder.AddMarkupContent(10, "<button type=\"button\" class=\"navbar-toggler\" data-toggle=\"collapse\" data-target=\"#navbarCollapse\">\r\n                <span class=\"navbar-toggler-icon\"></span>\r\n            </button>\r\n\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "collapse navbar-collapse");
            __builder.AddAttribute(13, "id", "navbarCollapse");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.AddMarkupContent(15, "<div class=\"navbar-nav\">\r\n                    <a href=\"/Dashboard\" class=\"nav-item nav-link active\">Home</a>\r\n\r\n                </div>\r\n              \r\n            \r\n                ");
            __builder.AddMarkupContent(16, "<div class=\"navbar-nav\" style=\"margin-left:600px\">\r\n                    <input type=\"text\" placeholder=\"Search Product\">\r\n                    <button class=\"btn btn-success\">Search</button>\r\n                </div>\r\n                ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "navbar-nav ml-auto");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Shared\VendorLayout.razor"
                                      Navigate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "nav-item nav-link");
            __builder.AddContent(23, "Logout");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "content px-4");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.AddContent(32, 
#nullable restore
#line 36 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Shared\VendorLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Shared\VendorLayout.razor"
 
    void Navigate()
    {
        UriHelper.NavigateTo("Logout");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
