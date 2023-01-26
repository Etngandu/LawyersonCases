#pragma checksum "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a51f71c1f5e8bf97a85c2370cf3a298e570f1d28"
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
#line 2 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
using ENB.Blazor.Lawyer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
using ENB.Blazor.Lawyer.HttpRepository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lawyertable")]
    public partial class LawyerTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"alert alert-info\" role=\"alert\"><h2><strong>Lawyer Dashboard <i class=\"fas fa-book-open-reader\"></i></strong></h2></div>\r\n\r\n");
            __builder.AddMarkupContent(1, "<a href=\"/CreateLawyer\" class=\"btn btn-info\" style=\"margin-bottom:5px\"> Create New Lawyer</a>\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenDataGrid<DisplayLawyer>>(2);
            __builder.AddAttribute(3, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<DisplayLawyer>>(
#nullable restore
#line 12 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                       LawyerList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "PageSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                      10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "PagerHorizontalAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.HorizontalAlign>(
#nullable restore
#line 13 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                             HorizontalAlign.Left

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ShowPagingSummary", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "AllowSrolling", "true");
            __builder.AddAttribute(9, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                                                                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 13 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                                                                                        FilterMode.Advanced

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<DisplayLawyer>>(13);
                __builder2.AddAttribute(14, "Frozen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Property", "Id");
                __builder2.AddAttribute(16, "Title", "ID");
                __builder2.AddAttribute(17, "Width", "80px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<DisplayLawyer>>(19);
                __builder2.AddAttribute(20, "Property", "FullName");
                __builder2.AddAttribute(21, "Title", "Name");
                __builder2.AddAttribute(22, "Template", (Microsoft.AspNetCore.Components.RenderFragment<DisplayLawyer>)((Lawyers) => (__builder3) => {
                    __builder3.OpenElement(23, "a");
                    __builder3.AddAttribute(24, "href", 
#nullable restore
#line 18 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                            $"DetailsLawyer/{Lawyers.Id}"

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 18 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
__builder3.AddContent(25, Lawyers.FullName);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<DisplayLawyer>>(27);
                __builder2.AddAttribute(28, "Property", "Hourly_rate");
                __builder2.AddAttribute(29, "Title", "H/Rate");
                __builder2.AddAttribute(30, "Width", "100px");
                __builder2.AddAttribute(31, "Template", (Microsoft.AspNetCore.Components.RenderFragment<DisplayLawyer>)((Lawyers) => (__builder3) => {
#nullable restore
#line 23 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
__builder3.AddContent(32, String.Format(new System.Globalization.CultureInfo("fr-BE"), "{0:C}", Lawyers.Hourly_rate));

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<DisplayLawyer>>(34);
                __builder2.AddAttribute(35, "Property", "DateOfBirth");
                __builder2.AddAttribute(36, "FormatString", "{0:dd/MM/yyyy}");
                __builder2.AddAttribute(37, "Title", "Date of Birth");
                __builder2.AddAttribute(38, "Width", "¨140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n        \r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<DisplayLawyer>>(40);
                __builder2.AddAttribute(41, "Property", "PhoneNumber");
                __builder2.AddAttribute(42, "Title", "Phone Number");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<DisplayLawyer>>(44);
                __builder2.AddAttribute(45, "Property", "EmailAddres");
                __builder2.AddAttribute(46, "Title", "Email");
                __builder2.AddAttribute(47, "Width", "¨140px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<DisplayLawyer>>(49);
                __builder2.AddAttribute(50, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                  false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                                   false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 31 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                                                     TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "Width", "120px");
                __builder2.AddAttribute(54, "Template", (Microsoft.AspNetCore.Components.RenderFragment<DisplayLawyer>)((Lawyers) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(55);
                    __builder3.AddAttribute(56, "Icon", "edit");
                    __builder3.AddAttribute(57, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 33 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                       ButtonStyle.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "Class", "m-1");
                    __builder3.AddAttribute(59, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 33 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                           ButtonSize.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                                                      args => OnClickEdit(Lawyers.Id)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddEventStopPropagationAttribute(61, "onclick", 
#nullable restore
#line 33 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                                                                                                                  true

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(62, "Width", "150px");
                    __builder3.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(64, "<strong><i class=\'fas fa-pencil\'></i>  Edit</strong>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<DisplayLawyer>>(66);
                __builder2.AddAttribute(67, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                  false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                                   false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 38 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                                                     TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "Width", "60px");
                __builder2.AddAttribute(71, "Template", (Microsoft.AspNetCore.Components.RenderFragment<DisplayLawyer>)((Lawyers) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(72);
                    __builder3.AddAttribute(73, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 40 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "Icon", "delete");
                    __builder3.AddAttribute(75, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 40 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                   ButtonSize.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "Class", "m-1");
                    __builder3.AddAttribute(77, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                                                          args => OnClickDelete(Lawyers.Id)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddEventStopPropagationAttribute(78, "onclick", 
#nullable restore
#line 40 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
                                                                                                                                                                                        true

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(79, "Width", "150px");
                    __builder3.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(81, "<strong><i class=\'fa-solid fa-trash-can\'></i>    Delete</strong>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Devsource\LawyerOffice\ENB.Blazor.Lawyer\Pages\Lawyer\LawyerTable.razor"
       
    public IEnumerable<DisplayLawyer> LawyerList { get; set; }

    [Inject]
    public ILawyerHttpRepository LawyerRepo { get; set; }
    protected async override Task OnInitializedAsync()
    {
        LawyerList = await LawyerRepo.GetLawyers();
        //just for testing
        foreach (var lawyer in LawyerList)
        {
            Console.WriteLine(lawyer.DateOfBirth);
        }
    }

    void OnClickEdit(int Id)
    {
        NavigationManager.NavigateTo($"EditLawyer/{Id}");
    }
    

    void OnClickDelete(int Id)
    {
        NavigationManager.NavigateTo($"DeleteLawyer/{Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
