#pragma checksum "C:\Users\roelt\source\repos\AquilaGUI\AquilaGUI\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "199276ce4d8186e41eab7faff19c561fefc264e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AquilaGUI.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AquilaGUI.Pages
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
#line 1 "C:\Users\roelt\source\repos\AquilaGUI\AquilaGUI\Pages\_ViewImports.cshtml"
using AquilaGUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\roelt\source\repos\AquilaGUI\AquilaGUI\Pages\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"199276ce4d8186e41eab7faff19c561fefc264e2", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cdfed81933663e687c59a0e46d767f98955e1c7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\roelt\source\repos\AquilaGUI\AquilaGUI\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome</h1>\r\n\r\n\r\n        ");
#nullable restore
#line 11 "C:\Users\roelt\source\repos\AquilaGUI\AquilaGUI\Pages\Index.cshtml"
    Write(Html.DevExtreme().LinearGauge()
        .ID("gauge")
        .Scale(s => s
            .StartValue(0)
            .EndValue(5)
            .TickInterval(2.5)
            .MinorTickInterval(0.625)
            .MinorTick(m => m.Visible(true))
        )
        .Export(e => e.Enabled(true))
        .Title(t => t
            .Text("TV Show Rating")
            .Font(f => f.Size(28))
        )
        .Value(4.3)
        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
