<<<<<<< HEAD
#pragma checksum "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a38d5202ae93b8a9f97d4b9c29a18fab1adefee5"
=======
#pragma checksum "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a38d5202ae93b8a9f97d4b9c29a18fab1adefee5"
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
    public partial class DataTableItemComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "td");
            __builder.AddContent(3, 
#nullable restore
<<<<<<< HEAD
#line 4 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
=======
#line 4 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
         product.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
<<<<<<< HEAD
#line 5 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
=======
#line 5 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
         product.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
<<<<<<< HEAD
#line 6 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
=======
#line 6 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
         product.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
<<<<<<< HEAD
#line 7 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
=======
#line 7 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
         product.price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.OpenElement(16, "ul");
            __builder.AddAttribute(17, "class", "list-inline m-0");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "li");
            __builder.AddAttribute(20, "class", "list-inline-item");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
<<<<<<< HEAD
#line 12 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
=======
#line 12 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
                                  () => ProductDetails(product.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "data-toggle", "");
            __builder.AddAttribute(27, "data-placement", "top");
            __builder.AddAttribute(28, "title", "View");
            __builder.AddContent(29, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "list-inline-item");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
<<<<<<< HEAD
#line 15 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
=======
#line 15 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
                                  () => EditProduct(product.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "class", "btn btn-success btn-sm");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "data-toggle", "tooltip");
            __builder.AddAttribute(40, "data-placement", "top");
            __builder.AddAttribute(41, "title", "Edit");
            __builder.AddContent(42, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "list-inline-item");
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
<<<<<<< HEAD
#line 18 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
=======
#line 18 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
                                  () => DeleteProduct(product.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(51, "type", "button");
            __builder.AddAttribute(52, "data-toggle", "tooltip");
            __builder.AddAttribute(53, "data-placement", "top");
            __builder.AddAttribute(54, "title", "Delete");
            __builder.AddContent(55, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 25 "E:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
=======
#line 25 "F:\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\DataTableItemComponent.razor"
>>>>>>> 3fd50291eba5be7d6cd6dfb50c890e9d55af35c2
       
    [Parameter]
    public Product product { get; set; }

    [Parameter]
    public int id { get; set; }
    [Parameter]
    public EventCallback<int> updateList { get; set; }


    void EditProduct(int id)
    {
        UriHelper.NavigateTo("/EditProduct/" + id);
    }

    void ProductDetails(int id)
    {
        UriHelper.NavigateTo("/VendorProduct/" + id);
    }




    protected async Task DeleteProduct(int id)
    {

        await Http.DeleteAsync("api/Product/delete/" + id);
        //await updateList.InvokeAsync(id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
