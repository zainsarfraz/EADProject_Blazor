#pragma checksum "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\CategoryDetailComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1217023b4b1e558eb01b84083c3cf430f8b410b3"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/CategoryDetail/{id:int}")]
    public partial class CategoryDetailComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "\r\nCategory # ");
            __builder.AddContent(1, 
#nullable restore
#line 3 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\CategoryDetailComponent.razor"
            id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 6 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\CategoryDetailComponent.razor"
     foreach (var pro in products)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenComponent<BlazorApp1.Client.Pages.ProductComponent>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 9 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\CategoryDetailComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(10, "<h3>Category Name</h3>");
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\CategoryDetailComponent.razor"
       
    [Parameter]
    public int id { get; set; }


    public List<Product> products = new List<Product>();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
