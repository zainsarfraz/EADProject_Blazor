<<<<<<< HEAD
#pragma checksum "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\LoginComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "596f545da52102157bee41757f8afbb3a764e821"
=======
#pragma checksum "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\LoginComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "596f545da52102157bee41757f8afbb3a764e821"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
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
<<<<<<< HEAD
#line 1 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
=======
#line 1 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
=======
#line 2 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
=======
#line 3 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
=======
#line 4 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
=======
#line 5 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 6 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
=======
#line 6 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 7 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
=======
#line 7 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 8 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
=======
#line 8 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
using BlazorApp1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 9 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
=======
#line 9 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
using BlazorApp1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 10 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
=======
#line 10 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class LoginComponent : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(7, "<h5 class=\"card-title\">Login</h5>\r\n        ");
            __builder.OpenComponent<BlazorApp1.Client.Pages.LoginFormComponent>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
<<<<<<< HEAD
#line 14 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\LoginComponent.razor"
=======
#line 14 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\LoginComponent.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
                      Register

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "btn btn-dark");
            __builder.AddContent(14, " Register Yourself ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 19 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\LoginComponent.razor"
=======
#line 19 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\LoginComponent.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
       

    void Register()
    {
        UriHelper.NavigateTo("Register");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
