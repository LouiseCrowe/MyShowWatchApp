#pragma checksum "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f213723db570e61169d21649f636c05fa773aa86"
// <auto-generated/>
#pragma warning disable 1591
namespace MyShowWatch.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using MyShowWatch.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using MyShowWatch.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
using MyShowWatch.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/detailedview")]
    public partial class DetailedView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenComponent<MyShowWatch.Client.Shared.SearchForTitle>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n<br>\r\n\r\n");
            __Blazor.MyShowWatch.Client.Pages.DetailedView.TypeInference.CreateTelerikGrid_0(__builder, 4, 5, 
#nullable restore
#line 12 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
                   shows

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 12 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
                                    true

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 12 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
                                                    true

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 12 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
                                                                      GridFilterMode.FilterMenu

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(10);
                __builder2.AddAttribute(11, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
                            nameof(Show.Title)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(13);
                __builder2.AddAttribute(14, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
                            nameof(Show.ShowType)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Title", "Show Type");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(17);
                __builder2.AddAttribute(18, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
                            nameof(Show.Availability)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(20);
                __builder2.AddAttribute(21, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
                            nameof(Show.WatchStatus)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Title", "Watched it?");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(24);
                __builder2.AddAttribute(25, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
                            nameof(Show.RunningStatus)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Title", "Still running?");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(28);
                __builder2.AddAttribute(29, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
                            nameof(Show.AgeRating)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Title", "For kids?");
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Pages\DetailedView.razor"
       


    private List<Show> shows { get; set; }

    //private int numTvShows, numMovies, numDocumentaries;

    private static readonly String baseURL = "https://localhost:5001/Show/";

    protected override async Task OnInitializedAsync()
    {
        shows = await Http.GetFromJsonAsync<List<Show>>(baseURL + "all");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.MyShowWatch.Client.Pages.DetailedView
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Telerik.Blazor.GridFilterMode __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Sortable", __arg1);
        __builder.AddAttribute(__seq2, "Pageable", __arg2);
        __builder.AddAttribute(__seq3, "FilterMode", __arg3);
        __builder.AddAttribute(__seq4, "GridColumns", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
