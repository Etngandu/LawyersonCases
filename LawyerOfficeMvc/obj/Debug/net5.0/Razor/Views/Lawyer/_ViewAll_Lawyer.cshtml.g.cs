#pragma checksum "D:\Devsource\LawyerOffice\LawyerOfficeMvc\Views\Lawyer\_ViewAll_Lawyer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cedbcd09ea0d64264618f4f45ff95d304edf8713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lawyer__ViewAll_Lawyer), @"mvc.1.0.view", @"/Views/Lawyer/_ViewAll_Lawyer.cshtml")]
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
#line 1 "D:\Devsource\LawyerOffice\LawyerOfficeMvc\Views\_ViewImports.cshtml"
using LawyerOfficeMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Devsource\LawyerOffice\LawyerOfficeMvc\Views\_ViewImports.cshtml"
using LawyerOfficeMvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Devsource\LawyerOffice\LawyerOfficeMvc\Views\Lawyer\_ViewAll_Lawyer.cshtml"
using LawyerOffice.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cedbcd09ea0d64264618f4f45ff95d304edf8713", @"/Views/Lawyer/_ViewAll_Lawyer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2891c44d608613b5455d85f8a61b89b1dd231be", @"/Views/_ViewImports.cshtml")]
    public class Views_Lawyer__ViewAll_Lawyer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LawyerOfficeMvc.Models.DisplayLawyer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/DataTables/css/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("charset", new global::Microsoft.AspNetCore.Html.HtmlString("utf8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/DataTables/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Devsource\LawyerOffice\LawyerOfficeMvc\Views\Lawyer\_ViewAll_Lawyer.cshtml"
  
    ViewBag.Title = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<div class=\"alert alert-info\" role=\"alert\">\r\n    <h2><strong>Lawyer Dashboard <i class=\"fas fa-ambulance\"></i></strong></h2>\r\n</div>\r\n<a class=\"btn btn-success text-white\" style=\"margin-bottom:10px\"");
            BeginWriteAttribute("onclick", " onclick=\"", 326, "\"", 382, 4);
            WriteAttributeValue("", 336, "showInPopup", 336, 11, true);
            WriteAttributeValue(" ", 347, "(\'", 348, 3, true);
#nullable restore
#line 13 "D:\Devsource\LawyerOffice\LawyerOfficeMvc\Views\Lawyer\_ViewAll_Lawyer.cshtml"
WriteAttributeValue("", 350, Url.Action("Create","Lawyer"), 350, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 380, "\')", 380, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-plus""></i> New Lawyer</a>
<table id=""Lawyertable"" class=""table table-striped table-bordered"" width=""100%"">
    <thead>
        <tr>
            <th>FullName</th>
            <th>Hourly_rate</th>
            <th>DateOfBirth</th>
            <th>EmailAddres</th>
            <th>PhoneNumber</th>
            <th> </th>
        </tr>
    </thead>
</table>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cedbcd09ea0d64264618f4f45ff95d304edf87136935", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cedbcd09ea0d64264618f4f45ff95d304edf87138353", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\" charset=\"utf8\" src=\"https://cdn.datatables.net/1.11.4/js/dataTables.bootstrap4.min.js\"></script>\r\n    <script>\r\n        var Popup, datatable, IdPatient = parseInt(\'");
#nullable restore
#line 35 "D:\Devsource\LawyerOffice\LawyerOfficeMvc\Views\Lawyer\_ViewAll_Lawyer.cshtml"
                                               Write(ViewBag.Patient_Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'),IdWard=parseInt(\'");
#nullable restore
#line 35 "D:\Devsource\LawyerOffice\LawyerOfficeMvc\Views\Lawyer\_ViewAll_Lawyer.cshtml"
                                                                                      Write(ViewBag.Ward_Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"')
        $(document).ready(function () {
            datatable = $(""#Lawyertable"").DataTable({
                ""ajax"": {
                    ""url"": ""/Lawyer/GetLawyerData"",
                    ""type"": ""GET"",
                    ""datatype"": ""json""
                },
                ""columns"": [

                    {
                        ""data"": ""fullName"",
                        ""width"":""250px"",
                        ""render"": function (data, type, row, meta) {
                            return '<a href=""/Lawyer/Detail/' + row.Id + '"">' + data + '</a>';
                        }
                    },
                    { ""data"": ""hourly_rate"" },
                    {
                        ""data"": ""dateOfBirth"",
                        ""render"": formatdate
                    },
                    { ""data"": ""emailAddres"" },
                    { ""data"": ""phoneNumber"" },
                    {
                        ""data"": ""Id"", ""render"": function (data) {
              ");
                WriteLiteral("              return \"<a class= \'btn btn-primary btn-sm text-white\' onclick=PopupForm(\'");
#nullable restore
#line 61 "D:\Devsource\LawyerOffice\LawyerOfficeMvc\Views\Lawyer\_ViewAll_Lawyer.cshtml"
                                                                                                Write(Url.Action("Edit","Patient"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/"" + data + ""')><i class='fas fa-pencil'></i><b> Edit</b></a><a class= 'btn btn-danger btn-sm text-white' style='margin-left:5px' onclick=Delete("" + data + "")><i class='fa-solid fa-trash-can'></i><b> Delete</b> </a> "" + ""\r\n"" +
                                ""<a class= 'btn btn-default btn-sm' style='margin-left:5px' onclick=location.href='");
#nullable restore
#line 62 "D:\Devsource\LawyerOffice\LawyerOfficeMvc\Views\Lawyer\_ViewAll_Lawyer.cshtml"
                                                                                                              Write(Url.Action("List", "Patient_in_Room"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?patient_Id="" + data + ""'><i class='fa-solid fa-link-horizontal'></i>Link Case </a>"";
                        },
                        ""orderable"": false,
                        ""searchable"": false,
                        ""width"": ""600px""
                    }

                ],
                ""language"": {

                    ""emptyTable"": ""No data Found, Please Click On <b>Add New</b> Button""
                }

            });

        });

        function PopupForm(url) {
            var formdiv = $('<div/>')
            $.get(url)
                .done(function (response) {
                    formdiv.html(response);

                    Popup = formdiv.dialog({

                        autoOpen: true,
                        resizable: false,
                        title: 'Fill Patient details',
                        height: 700,
                        width: 1500,
                        close: function () {

                            Popup.dialog('destroy')");
                WriteLiteral(@".remove();
                        }


                    })

                })
        }

        function SubmitForm(form) {

            $.validator.unobtrusive.parse(form);
            if ($(form).valid()) {
                $.ajax({
                    type: 'POST',
                    url: form.action,
                    data: $(form).serialize(),
                    success: function (data) {
                        if (data.success) {
                            Popup.dialog('close');
                            datatable.ajax.reload();

                            $.notify(data.message, {
                                globalPosition: ""top center"",
                                className: ""success""
                            })

                        }
                    }

                });
            }
            return false;
        }

        function Delete(id) {
            if (confirm('Are You Sure to Delete this Record'))
            {

   ");
                WriteLiteral("             $.ajax({\r\n                    type: \"POST\",\r\n                    url: \'");
#nullable restore
#line 135 "D:\Devsource\LawyerOffice\LawyerOfficeMvc\Views\Lawyer\_ViewAll_Lawyer.cshtml"
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


        function formatdate(data) {
            var value = new Date
                (
                    parseInt(data.replace(/(^.*\()|([+-].*$)/g, ''))
                );
            var dat = value.getMonth() +
                1 +
                ""/"" +
                value.getDate() +
                ""/"" +
                value.getFullYear();
            return(dat);

        }

        function Genderparse(data) {
            var gnder;
            switch (data) {
                case 1:
                    gnder=""Male""
 ");
                WriteLiteral("                   break;\r\n                case 2:\r\n                    gnder=\"Female\"\r\n                    break;\r\n                default:\r\n                // code block\r\n            }\r\n            return gnder;\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LawyerOfficeMvc.Models.DisplayLawyer> Html { get; private set; }
    }
}
#pragma warning restore 1591
