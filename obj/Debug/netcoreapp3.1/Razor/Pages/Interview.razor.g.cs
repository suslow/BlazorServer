#pragma checksum "D:\IT\BlazorServer\Pages\Interview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a4dcbf394a2818b9591fe172012c16fe8922807"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\IT\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IT\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\IT\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\IT\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\IT\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\IT\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\IT\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\IT\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\IT\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/interview")]
    public partial class Interview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Опрос</h1>\r\n\r\nПройдите, пожалуйста, опрос\r\n\r\n");
            __builder.AddMarkupContent(1, "<h2>Выберите один вариант из каждой группы</h2>\r\n\r\n");
            __builder.AddMarkupContent(2, @"<body>
<div class=""category-wrap"">
  <h3>Варианты неисправностей</h3>
  <ul>
    <li><a href>Неисправность 1</a></li>
    <li><a href>Неисправность 2</a></li>
    <li><a href>Неисправность 3</a></li>
    <li><a href>Неисправность 4</a></li>
    <li><a href>Неисправность 5</a></li>
  </ul>
</div></body>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
