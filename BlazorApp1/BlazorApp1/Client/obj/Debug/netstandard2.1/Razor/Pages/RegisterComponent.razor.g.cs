#pragma checksum "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\RegisterComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c14504eb6220234425c6683a7e02592b6ceb277d"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class RegisterComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card text-center");
            __builder.AddAttribute(2, "style", "width: 18rem; margin:auto; margin-top:100px;");
            __builder.AddMarkupContent(3, "\r\n    <img src=\"/Images//logo.png\" height=\"50\" width=\"50 \" class=\"rounded mx-auto d-block\" alt=\"Card image cap\">\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<h5 class=\"card-title\">Register Yourself</h5>\r\n        ");
            __builder.OpenComponent<BlazorApp1.Client.Pages.RegisterFormComponent>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\RegisterComponent.razor"
                      Login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "btn btn-dark");
            __builder.AddContent(14, " login if already a user !");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\RegisterComponent.razor"
       
    void Login()
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
