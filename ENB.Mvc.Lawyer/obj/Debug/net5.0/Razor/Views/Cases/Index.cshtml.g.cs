#pragma checksum "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0716d3a1c531ffaec55f8c90df404a9e9c60114b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cases_Index), @"mvc.1.0.view", @"/Views/Cases/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
using LawyerOffice.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0716d3a1c531ffaec55f8c90df404a9e9c60114b", @"/Views/Cases/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c7e29448ab6f291b1dd792d6c8db58f0c85d720", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cases_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ENB.Mvc.Lawyer.Models.DisplayCase>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cases", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/DataTables/css/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("charset", new global::Microsoft.AspNetCore.Html.HtmlString("utf8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/DataTables/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
  
    ViewBag.Title = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<div class=\"alert alert-info\" role=\"alert\">\r\n    <h2><strong>Cases Dashboard <i class=\"fas fa-briefcase\"></i></strong></h2>\r\n</div>\r\n");
#nullable restore
#line 12 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
 if (User.IsInRole("Visitor"))
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<strong>Action is not available</strong>");
            WriteLiteral("\r\n    <br />\r\n");
#nullable restore
#line 16 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0716d3a1c531ffaec55f8c90df404a9e9c60114b7775", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i> New Case");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table id=""Lawyertable"" class=""table table-striped table-bordered"" width=""100%"">
    <thead>
        <tr>
            <th>Id</th>
            <th>CaseTitle</th>
            <th>Opened_date</th>
            <th>Closed_date</th>
            <th>Case_description</th>
            <th>Statuscase</th>
            <th> </th>
        </tr>
    </thead>
</table>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0716d3a1c531ffaec55f8c90df404a9e9c60114b9895", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\" charset=\"utf8\" src=\"https://code.jquery.com/jquery-3.5.1.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0716d3a1c531ffaec55f8c90df404a9e9c60114b11313", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\" charset=\"utf8\" src=\"https://cdn.datatables.net/1.11.4/js/dataTables.bootstrap4.min.js\"></script>\r\n    <script>\r\n            var Popup, datatable, IdPatient = parseInt(\'");
#nullable restore
#line 44 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
                                                   Write(ViewBag.Patient_Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'),IdWard=parseInt(\'");
#nullable restore
#line 44 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
                                                                                          Write(ViewBag.Ward_Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"')
            $(document).ready(function () {
               var datatable = $(""#Lawyertable"").DataTable({
                    ""ajax"": {
                        ""url"": ""/Cases/GetCasesData"",
                        ""type"": ""GET"",
                        ""datatype"": ""json""
                    },
                    ""columns"": [

                        { ""data"": ""id"" },
                        {
                            ""data"": ""caseTitle"",
                            ""width"":""250px"",
                            ""render"": function (data, type, row, meta) {
                                return '<a href=""/Cases/Details/' + row.id + '"">' + data + '</a>';
                            }
                        },
                        {
                            ""data"": ""case_Opened_date"",
                            ""render"": dateFormatter
                        },
                        {
                            ""data"": ""case_Closed_date"",
                            ""render");
                WriteLiteral(@""": dateFormatter
                        },
                        { ""data"": ""case_description"" },
                        {
                            ""data"": ""statuscase"",
                            ""render"": statuscase
                        },
                        {
                            ""data"": ""id"", ""render"": function (data) {
                                return ""<a class= 'btn btn-primary btn-sm text-white' onclick=location.href='");
#nullable restore
#line 77 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
                                                                                                        Write(Url.Action("Edit","Cases"));

#line default
#line hidden
#nullable disable
                WriteLiteral("/\" + data + \"\'><i class=\'fas fa-pencil\'></i><b> Edit</b></a><a class= \'btn btn-danger btn-sm text-white\' style=\'margin-left:5px\' onclick=location.href=\'");
#nullable restore
#line 77 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
                                                                                                                                                                                                                                                                                           Write(Url.Action("Delete","Cases"));

#line default
#line hidden
#nullable disable
                WriteLiteral("/\" + data + \"\'><i class=\'fa-solid fa-trash-can\'></i><b> Delete</b> </a> \" + \"\\r\\n\" +\r\n                                    \"<a class= \'btn btn-info btn-sm text-white\' style=\'margin-left:5px\' onclick=location.href=\'");
#nullable restore
#line 78 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
                                                                                                                          Write(Url.Action("LawyersperCaseList", "LawyersOnCases"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?caseId="" + data + ""'><i class='fas fa-external-link'></i> Lawyer </a>"";
                            },
                            ""orderable"": false,
                            ""searchable"": false,
                            ""width"": ""600px""
                        }

                    ],
                    ""language"": {

                        ""emptyTable"": ""No data Found, Please Click On <b>Add New</b> Button""
                    },
                ""footerCallback"": function (row, data, start, end, display) {

");
#nullable restore
#line 92 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
          
            if (User.IsInRole("Visitor"))
            {

                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            var api = this.api(datatable);\r\n\r\n                            var column = api.column(6);\r\n                            column.visible(false);\r\n                            console.log(api.column);\r\n\r\n                ");
#nullable restore
#line 103 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
                       

            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


                        }
              
                
                

                });

            });



            

            


            




      function  dateFormatter(data) {
            var dateAsString = data;

            var yearNumber = dateAsString.substring(0, 4);
            var monthNumber = dateAsString.substring(5, 7);
            var dayNumber = dateAsString.substring(8, 10);
          var dat = dayNumber + ""/"" + monthNumber + ""/"" + yearNumber;
            return dat;
        }


        function statuscase(data) {
                var stcs;
                switch (data) {
                    case 1:
                        stcs=""Open""
                        break;
                    case 2:
                        stcs=""Closed""
                        break;
                    default:
                    // code block
                }
                return stcs;
            }

    </script>
");
            }
            );
            WriteLiteral("    <h2>Claim details</h2>\r\n    <ul>\r\n");
#nullable restore
#line 161 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><strong>");
#nullable restore
#line 163 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
               Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>: ");
#nullable restore
#line 163 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
                                     Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 164 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\Cases\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ENB.Mvc.Lawyer.Models.DisplayCase> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
