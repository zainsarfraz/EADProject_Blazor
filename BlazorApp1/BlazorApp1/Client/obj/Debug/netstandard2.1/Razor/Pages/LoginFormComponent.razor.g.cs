#pragma checksum "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\LoginFormComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca10361ae66350f5e7f633433a1b49c8e2a01e83"
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
#line 1 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
    public partial class LoginFormComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddAttribute(1, "class", "form-signin");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.AddMarkupContent(3, "<label for=\"inputEmail\" class=\"sr-only\">Email address</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "email");
            __builder.AddAttribute(6, "id", "inputEmail");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "placeholder", "Email address");
            __builder.AddAttribute(9, "required", true);
            __builder.AddAttribute(10, "autofocus", true);
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\LoginFormComponent.razor"
                                                email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(14, "<label for=\"inputPassword\" class=\"sr-only\">Password</label>\r\n\r\n    ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "password");
            __builder.AddAttribute(17, "id", "inputPassword");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "placeholder", "Password");
            __builder.AddAttribute(20, "required", true);
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\LoginFormComponent.razor"
                                                      password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(24, "<div class=\"checkbox mb-3\">\r\n        <label>\r\n            <input type=\"checkbox\" value=\"remember-me\"> Remember me\r\n        </label>\r\n    </div>\r\n    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\LoginFormComponent.razor"
                      login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "class", "btn btn-lg btn-primary btn-block");
            __builder.AddAttribute(28, "type", "submit");
            __builder.AddContent(29, "Sign in");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\LoginFormComponent.razor"
       

    public string email;
    public string password;
    public Vendor vendor = new Vendor();

    protected async Task checkLogin()
    {
        vendor = await Http.GetFromJsonAsync<Vendor>($"api/Vendor/email/{email}");
    }

    public void login()
    {
        var vendor = new Vendor { email = email, password = password };


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
