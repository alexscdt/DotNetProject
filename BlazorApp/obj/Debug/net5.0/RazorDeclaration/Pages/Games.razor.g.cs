// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\Pages\Games.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\Pages\Games.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\Pages\Games.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\Pages\Games.razor"
using System.Reflection.Metadata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\Pages\Games.razor"
using System.Runtime.CompilerServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\Pages\Games.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\Pages\Games.razor"
using Microsoft.AspNetCore.Razor.TagHelpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/games")]
    public partial class Games : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\alexs\Documents\Efficom\dotnet\DotNetProject\BlazorApp\Pages\Games.razor"
       

    static int Image = 0;
    static int Historique = 0;

    private void Start()
    {
        JS.InvokeAsync<object>("start");
    }

    private void click(int id)
    {
        JS.InvokeAsync<object>("hidden", id);
        JS.InvokeAsync<object>("visible");
        Image ++;
    }
    
    [JSInvokable]
    public static void Finish()
    {
        Console.WriteLine("finis");
        Historique = Image;
        Image = 0;
        Console.WriteLine("test mec");
    }
    
    protected async Task PostScore()
    {
        if (Image != 0)
        {
            var postBody = new {    
                IdUser = "1",
                Score = Image,
                Date =  DateTime.Now
            };
            using var response = await HttpClient.PostAsJsonAsync("https://localhost:5001/api/history", postBody);
        }
        else
        {
            Console.WriteLine("pas mtn");
        }


        // convert response data to Article object
        // article = await response.Content.ReadFromJsonAsync<Article>();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
