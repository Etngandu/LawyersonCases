#pragma checksum "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\LawyersOnCases\CasesperLawyerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27098c140cc53d4288153d0061623872581d252c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LawyersOnCases_CasesperLawyerList), @"mvc.1.0.view", @"/Views/LawyersOnCases/CasesperLawyerList.cshtml")]
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
#line 1 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\LawyersOnCases\CasesperLawyerList.cshtml"
using LawyerOffice.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27098c140cc53d4288153d0061623872581d252c", @"/Views/LawyersOnCases/CasesperLawyerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c7e29448ab6f291b1dd792d6c8db58f0c85d720", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LawyersOnCases_CasesperLawyerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ENB.Mvc.Lawyer.Models.DisplayLawyerOnCase>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "LawyersOnCases", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CasesperLawyerCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\LawyersOnCases\CasesperLawyerList.cshtml"
  
    ViewBag.Title = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<div class=\"alert alert-info\" role=\"alert\">\r\n    <h2><strong>Lawyer ");
#nullable restore
#line 10 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\LawyersOnCases\CasesperLawyerList.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Related Cases <i class=\"fas fa-book-open-reader\"></i></strong></h2>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27098c140cc53d4288153d0061623872581d252c7714", async() => {
                WriteLiteral("<i class=\"fas fa-user-plus\"></i> New Link-Case");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-lawyerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\LawyersOnCases\CasesperLawyerList.cshtml"
                                                                                                                                           WriteLiteral(ViewBag.Lawyer_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lawyerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-lawyerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lawyerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table id=""Lawyertable"" class=""table table-striped table-bordered"" width=""100%"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Case Title</th>
            <th>Reference role</th>
            <th>Date creation</th>
            <th>Duration</th>
            <th>Case status</th>
            <th> </th>
        </tr>
    </thead>
</table>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "27098c140cc53d4288153d0061623872581d252c10794", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27098c140cc53d4288153d0061623872581d252c12213", async() => {
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
                WriteLiteral("\r\n    <script type=\"text/javascript\" charset=\"utf8\" src=\"https://cdn.datatables.net/1.11.4/js/dataTables.bootstrap4.min.js\"></script>\r\n    <script>\r\n            var Popup, datatable, IdLawyer = parseInt(\'");
#nullable restore
#line 35 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\LawyersOnCases\CasesperLawyerList.cshtml"
                                                  Write(ViewBag.Lawyer_Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'),IdWard=parseInt(\'");
#nullable restore
#line 35 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\LawyersOnCases\CasesperLawyerList.cshtml"
                                                                                        Write(ViewBag.Ward_Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"')
            $(document).ready(function () {
                datatable = $(""#Lawyertable"").DataTable({
                    ""ajax"": {
                        ""url"": ""/LawyersOnCases/GetCasesperLawyerList/?lawyerId="" + IdLawyer + """",
                        ""type"": ""GET"",
                        ""datatype"": ""json""
                    },
                    ""columns"": [

                        { ""data"": ""id"" },
                        {
                            ""data"": ""titlecase"",
                            ""width"":""250px"",
                            ""render"": function (data, type, row, meta) {
                                return '<a href=""/LawyersOnCases/CasesperLawyerDetails?id=' + row.id + ""&lawyerid="" + IdLawyer +  '"">' + data + '</a>';
                            }
                        },
                        {
                            ""data"": ""reference_role"",
                            ""render"": Reference_roleparse
                        },
                    ");
                WriteLiteral(@"    {
                            ""data"": ""dateCreated"",
                            ""render"": dateFormatter
                        },
                        {
                            ""data"": ""duration""
                        },
                        {
                            ""data"": ""case_status"",
                            ""render"": Case_status_parse
                        },
                        {
                            ""data"": ""id"", ""render"": function (data) {
                                return ""<a class= 'btn btn-primary btn-sm text-white' onclick=location.href='");
#nullable restore
#line 70 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\LawyersOnCases\CasesperLawyerList.cshtml"
                                                                                                        Write(Url.Action("CasesperLawyerEdit", "LawyersOnCases"));

#line default
#line hidden
#nullable disable
                WriteLiteral("?id=\" + data + \"&lawyerid=\" + IdLawyer + \"\'><i class=\'fas fa-pencil\'></i><b> Edit</b></a><a class= \'btn btn-danger btn-sm text-white\' style=\'margin-left:5px\' onclick=location.href=\'");
#nullable restore
#line 70 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\LawyersOnCases\CasesperLawyerList.cshtml"
                                                                                                                                                                                                                                                                                                                                                Write(Url.Action("DeleteCaseperLawyer","LawyersOnCases"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?id="" + data + ""&lawyerid="" + IdLawyer + ""'><i class='fa-solid fa-trash-can'></i><b> Delete</b> </a> "";
                            },
                            ""orderable"": false,
                            ""searchable"": false,
                            ""width"": ""150px""
                        }

                    ],
                    ""language"": {

                        ""emptyTable"": ""No data Found, Please Click On <b>Add New</b> Button""
                    }

                });

            });



            function Delete(id) {
                if (confirm('Are You Sure to Delete this Record'))
                {

                    $.ajax({
                        type: ""POST"",
                        url: '");
#nullable restore
#line 95 "C:\Devsource\LawyerOffice\ENB.Mvc.Lawyer\Views\LawyersOnCases\CasesperLawyerList.cshtml"
                         Write(Url.Action("Delete","Ward"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/'+ id,
                        success: function (data) {
                            if (data.success) {
                                datatable.ajax.reload();

                                $.notify(data.message, {
                                    globalposition: ""top center"",
                                    className: ""success""
                                })
                            }
                        }

                    });

                }


            }




      function  dateFormatter(data) {
            var dateAsString = data;

            var yearNumber = dateAsString.substring(0, 4);
            var monthNumber = dateAsString.substring(5, 7);
            var dayNumber = dateAsString.substring(8, 10);
          var dat = dayNumber + ""/"" + monthNumber + ""/"" + yearNumber;
            return dat;
        }


        function Reference_roleparse(data) {
                var refrole;
                switch (data) {
                    ca");
                WriteLiteral(@"se 1:
                        refrole =""Advise and represent clients in courts""
                        break;
                    case 2:
                        refrole =""Communicate with clients,colleagues,judges""
                        break;
                    case 3:
                        refrole = ""Conduct research and analysis of legal problems""
                        break;
                    case 4:
                        refrole = ""Interpret laws, rulings, and regulations""
                        break;
                    default:
                    // code block
                }
                return refrole;
        }

        function Case_status_parse(data) {
            var csstt;
            switch (data) {
                case 1:
                    csstt = ""Open""
                    break;
                case 2:
                    csstt = ""Closed""
                    break;
                default:
                // code block
            }
      ");
                WriteLiteral("      return csstt;\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ENB.Mvc.Lawyer.Models.DisplayLawyerOnCase> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
