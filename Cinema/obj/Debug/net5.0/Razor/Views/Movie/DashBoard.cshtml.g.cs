#pragma checksum "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5249db363c3bed5390e43c99f54f8f5d60714a15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_DashBoard), @"mvc.1.0.view", @"/Views/Movie/DashBoard.cshtml")]
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
#line 1 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\_ViewImports.cshtml"
using Cinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\_ViewImports.cshtml"
using Cinema.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
using Cinema.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5249db363c3bed5390e43c99f54f8f5d60714a15", @"/Views/Movie/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88b38380ea0d4f64bad62cefdedd00944e4c52ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/chart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_LayoutEmpty.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5249db363c3bed5390e43c99f54f8f5d60714a154360", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"sidebar\">\r\n    <div class=\"sidebar-logo\">\r\n        <a href=\"/Home/Index\">\r\n            <img width=\"150px\" height=\"40px\" src=\"https://e-cinema.vercel.app/logo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 471, "\"", 477, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </a>
    </div>
    <div class=""sidebar-dashboard"">
        <ul class=""sidebar-list"">
            <li class=""sidebar-item""><i class=""fas fa-home"" style=""color:red""></i> <a href=""/Movie/Dashboard"" class=""sidebar-link"" style=""color: red;"">Home</a></li>
            <li class=""sidebar-item"">
                <i class=""fas fa-film-alt""></i><a href=""/Movie/List"" class=""sidebar-link"">Movie</a>
            </li>
            <li class=""sidebar-item""><i class=""fas fa-user""></i> <a href=""/Person/List"" class=""sidebar-link"">User</a></li>
        </ul>
    </div>
</div>

<div class=""container"">
    <div class=""dashboard-content"">
        <div class=""dashboard-static"">
            <i class=""fas fa-users dashboard-icon""></i>
            <h3 class=""dashboard-user"">User</h3>
            <p class=""dashboard-tt"">Total : ");
#nullable restore
#line 34 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                                       Write(ViewBag.user_tt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (user)</p>\r\n        </div>\r\n        <div class=\"dashboard-static\">\r\n            <i class=\"fas fa-film-alt dashboard-icon\"></i>\r\n            <h3 class=\"dashboard-user\">Movie</h3>\r\n            <p class=\"dashboard-tt\">Total : ");
#nullable restore
#line 39 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                                       Write(ViewBag.movie_tt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (movie)</p>\r\n        </div>\r\n        <div class=\"dashboard-static\">\r\n            <i class=\"fas fa-film dashboard-icon\"></i>\r\n            <h3 class=\"dashboard-user\">Genre</h3>\r\n            <p class=\"dashboard-tt\">Total : ");
#nullable restore
#line 44 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                                       Write(ViewBag.genre_tt);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" (genre)</p>
        </div>
    </div>
    <div class=""dashboard-chart"">
        <h1 class=""dashboard-chart-heading"">Chart (Top 7 Movies)</h1>
        <canvas id=""myChart"">
        </canvas>
    </div>
</div>


<script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
<script>
    const labels = ['");
#nullable restore
#line 57 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                Write(ViewBag.charts[0].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 57 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                                           Write(ViewBag.charts[1].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 57 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                                                                      Write(ViewBag.charts[2].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 57 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                                                                                                 Write(ViewBag.charts[3].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n        \'");
#nullable restore
#line 58 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
    Write(ViewBag.charts[4].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 58 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                               Write(ViewBag.charts[5].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \'");
#nullable restore
#line 58 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                                                          Write(ViewBag.charts[6].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"']
        const data = {
            labels: labels,
            datasets: [
                {
                    label: 'Totle Rating',
                    backgroundColor: 'red',
                    borderColor: 'red',
                    data: [");
#nullable restore
#line 66 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                      Write(ViewBag.charts[0].Score);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 66 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                                                Write(ViewBag.charts[1].Score);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 66 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                                                                          Write(ViewBag.charts[2].Score);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 66 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                                                                                                    Write(ViewBag.charts[3].Score);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n        ");
#nullable restore
#line 67 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
   Write(ViewBag.charts[4].Score);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 67 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                             Write(ViewBag.charts[5].Score);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 67 "C:\Users\ADMIN\OneDrive\Desktop\FPT\Summer2022\PRN211\Project\Cinema\Cinema\Views\Movie\DashBoard.cshtml"
                                                       Write(ViewBag.charts[6].Score);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"],
                },
            ],
        }
        const config = {
            type: 'bar',
            data: data,
        }

        const canvas = document.getElementById('myChart');
        const chart = new Chart(canvas, config);

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591