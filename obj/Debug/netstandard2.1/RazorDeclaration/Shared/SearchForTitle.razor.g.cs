// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyShowWatch.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 1 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
using MyShowWatch.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class SearchForTitle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\BLAZOR\CA3\MyShowWatch\MyShowWatch\Client\Shared\SearchForTitle.razor"
      

    private static readonly String baseURL = "https://localhost:5001/Show/Search/";


    
    public String Title { get; set; }

    [Parameter]
    public String titleNoSpaces { get; set; }

    private Show searchResult;

    private bool found;

    private string errormessage;


    public async Task Search()
    {
        try
        {
            // replace any spaces with %20 for url

            titleNoSpaces = Title.Replace(" ", "%20");

            searchResult = await Http.GetFromJsonAsync<Show>(baseURL + titleNoSpaces);

            found = true;
            errormessage = String.Empty;
        }
        catch (Exception e)
        {
            found = false;
            errormessage = "This title wasn't found, maybe check your spelling or try another one!";
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
