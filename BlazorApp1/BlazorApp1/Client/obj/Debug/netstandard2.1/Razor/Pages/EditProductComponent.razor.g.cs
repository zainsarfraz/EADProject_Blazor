#pragma checksum "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\EditProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4d46deb61b0d616cccb9d74a7fd3db1258ce8af"
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
#line 1 "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(VendorLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditProduct/{id:int}")]
    public partial class EditProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<form class=\"form-horizontal\">\r\n    <fieldset>\r\n\r\n        \r\n        <legend>Edit Product</legend>\r\n\r\n        \r\n        <div class=\"form-group\">\r\n            <label class=\"col-md-4 control-label\" for=\"product_id\">Product ID</label>\r\n            <div class=\"col-md-4\">\r\n                <input id=\"product_id\" name=\"product_id\" placeholder=\"Product ID\" class=\"form-control input-md\" required type=\"text\">\r\n\r\n            </div>\r\n        </div>\r\n\r\n        \r\n        <div class=\"form-group\">\r\n            <label class=\"col-md-4 control-label\" for=\"product_name\">Product Name</label>\r\n            <div class=\"col-md-4\">\r\n                <input id=\"product_name\" name=\"product_name\" placeholder=\"Product Name\" class=\"form-control input-md\" required type=\"text\">\r\n\r\n            </div>\r\n        </div>\r\n\r\n        \r\n        <div class=\"form-group\">\r\n            <label class=\"col-md-4 control-label\" for=\"product_description\">Product Description</label>\r\n            <div class=\"col-md-4\">\r\n                <input id=\"product_description\" name=\"product_description\" placeholder=\"Product Description\" class=\"form-control input-md\" required type=\"text\">\r\n\r\n            </div>\r\n        </div>\r\n\r\n        \r\n        <div class=\"form-group\">\r\n            <label class=\"col-md-4 control-label\" for=\"product_category\">Product Category</label>\r\n            <div class=\"col-md-4\">\r\n                <input id=\"product_category\" name=\"product_category\" placeholder=\"Product Category\" class=\"form-control input-md\" required type=\"text\"></div>\r\n        </div>\r\n\r\n        \r\n        <div class=\"form-group\">\r\n            <label class=\"col-md-4 control-label\" for=\"price\">Product Price</label>\r\n            <div class=\"col-md-4\">\r\n                <input id=\"price\" name=\"price\" placeholder=\"Price\" class=\"form-control input-md\" required type=\"number\">\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n        \r\n        <div class=\"form-group\">\r\n            <label class=\"col-md-4 control-label\" for=\"filebutton\">Main Image</label>\r\n            <div class=\"col-md-4\">\r\n                <input id=\"filebutton\" name=\"filebutton\" class=\"input-file\" type=\"file\">\r\n            </div>\r\n        </div>\r\n        \r\n        <div class=\"form-group\">\r\n            <label class=\"col-md-4 control-label\" for=\"filebutton\">Auxiliary Images</label>\r\n            <div class=\"col-md-4\">\r\n                <input id=\"filebutton\" name=\"filebutton\" class=\"input-file\" type=\"file\">\r\n            </div>\r\n        </div>\r\n\r\n        \r\n        <div class=\"form-group\">\r\n            <label class=\"col-md-4 control-label\" for=\"singlebutton\"></label>\r\n            <div class=\"col-md-4\">\r\n                <button id=\"singlebutton\" name=\"singlebutton\" class=\"btn btn-primary\">Edit Item</button>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </fieldset>\r\n</form>");
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "F:\Study -_-\6th Semester\Enterprise Application Developement - Dr Shuja ul Rehman\Project\EADProject_Blazor\BlazorApp1\BlazorApp1\Client\Pages\EditProductComponent.razor"
       
    [Parameter]
    public int id { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
