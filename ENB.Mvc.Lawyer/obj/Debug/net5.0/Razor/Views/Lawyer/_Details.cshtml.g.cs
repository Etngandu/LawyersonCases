#pragma checksum "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c30286f4035e4021cc704523cce9b815431589ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lawyer__Details), @"mvc.1.0.view", @"/Views/Lawyer/_Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\_ViewImports.cshtml"
using ENB.Mvc.Lawyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\_ViewImports.cshtml"
using ENB.Mvc.Lawyer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30286f4035e4021cc704523cce9b815431589ed", @"/Views/Lawyer/_Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c7e29448ab6f291b1dd792d6c8db58f0c85d720", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Lawyer__Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ENB.Mvc.Lawyer.Models.DisplayLawyer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    \r\n    <dl class=\"row\">\r\n        \r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 8 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 11 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Qualications));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayFor(model => model.Qualications));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Speciality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayFor(model => model.Speciality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmailAddres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayFor(model => model.EmailAddres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hourly_rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Lawyer\_Details.cshtml"
       Write(Html.DisplayFor(model => model.Hourly_rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n    </div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ENB.Mvc.Lawyer.Models.DisplayLawyer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
