<<<<<<< HEAD
#pragma checksum "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c9b9076d90fcdb1a56f473baac93f1a5674243b"
=======
#pragma checksum "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d770826c34f2bf6e9d2a741eecfb9f34888f9af1"
>>>>>>> 66acaecd2e09d1b9a2667bc2926c639d76d5572d
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
    public partial class MainLayout : LayoutComponentBase
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
            __builder.AddMarkupContent(9, "<a href class=\"navbar-brand\">\r\n                <img src=\"/Images/logo.png\" height=\"50\" width=\"50\">\r\n            </a>\r\n            \r\n            ");
            __builder.AddMarkupContent(10, "<button type=\"button\" class=\"navbar-toggler\" data-toggle=\"collapse\" data-target=\"#navbarCollapse\">\r\n                <span class=\"navbar-toggler-icon\"></span>\r\n            </button>\r\n\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "collapse navbar-collapse");
            __builder.AddAttribute(13, "id", "navbarCollapse");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.AddMarkupContent(15, "<div class=\"navbar-nav\">\r\n                    <a href class=\"nav-item nav-link active\">Home</a>\r\n\r\n                </div>\r\n                ");
            __builder.AddMarkupContent(16, "<div class=\"navbar-nav\">\r\n                    <a href=\"/Shops\" class=\"nav-item nav-link active\">Shops</a>\r\n\r\n                </div>\r\n                ");
            __builder.AddMarkupContent(17, "<div class=\"navbar-nav\">\r\n                    <a href=\"/Categories\" class=\"nav-item nav-link active\">Categories</a>\r\n\r\n                </div>\r\n                ");
            __builder.AddMarkupContent(18, "<div class=\"navbar-nav\" style=\"margin-left:600px\">\r\n                    <input type=\"text\" placeholder=\"Search Product\">\r\n                    <button class=\"btn btn-success\">Search</button>\r\n                </div>\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "navbar-nav ml-auto");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Shared\MainLayout.razor"
                                      Navigate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "nav-item nav-link");
            __builder.AddContent(25, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "content px-4");
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.AddContent(34, 
#nullable restore
#line 42 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Shared\MainLayout.razor"
 
    void Navigate()
    {
        UriHelper.NavigateTo("Login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
