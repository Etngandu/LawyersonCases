#pragma checksum "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\Lawyer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ff7a824037d330d2214a207853cebfaeba1c365"
// <auto-generated/>
#pragma warning disable 1591
namespace ENB.Blazor.Lawyer.Pages.Lawyer
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\_Imports.razor"
using ENB.Blazor.Lawyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\_Imports.razor"
using ENB.Blazor.Lawyer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\Lawyer.razor"
using ENB.Blazor.Lawyer.Pages.Lawyer;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lawyer")]
    public partial class Lawyer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lawyer</h3>\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"row\"><div class=\"col-md-10\"></div>\r\n    <div class=\"col-md-2\"><a href=\"/createProduct\">Create Lawyer</a></div></div>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.OpenComponent<ENB.Blazor.Lawyer.Pages.Lawyer.LawyerTable>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.AddMarkupContent(8, "<div class=\"row\"><div class=\"col\"></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
