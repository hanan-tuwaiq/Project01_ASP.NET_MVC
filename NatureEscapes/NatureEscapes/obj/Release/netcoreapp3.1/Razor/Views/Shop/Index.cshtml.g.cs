#pragma checksum "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d18ebf1ce9da64a16371e244457495f68e4a2d3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/_ViewImports.cshtml"
using NatureEscapes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/_ViewImports.cshtml"
using NatureEscapes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d18ebf1ce9da64a16371e244457495f68e4a2d3b", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018f63d0b5da91033f25bdb84cc878fbf1f23620", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Index.cshtml"
  
    var products = (List<ProductModel>) ViewData["products"];
    var rows = (int)products.Count() / 3 + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"border-b border-black p-4 text-center text-5xl\">\n    Nature Escapes\n</div>\n<div class=\"border-b border-black p-4 text-center text-3xl\">\n    Natural Soap Bars\n</div>\n\n<section");
            BeginWriteAttribute("class", " class=\"", 299, "\"", 349, 6);
            WriteAttributeValue("", 307, "grid", 307, 4, true);
            WriteAttributeValue(" ", 311, "grid-rows-", 312, 11, true);
#nullable restore
#line 12 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Index.cshtml"
WriteAttributeValue("", 322, rows, 322, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 327, "grid-cols-4", 328, 12, true);
            WriteAttributeValue(" ", 339, "gap-2", 340, 6, true);
            WriteAttributeValue(" ", 345, "p-8", 346, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\n    <div");
            BeginWriteAttribute("class", " class=\"", 360, "\"", 411, 6);
            WriteAttributeValue("", 368, "row-span-", 368, 9, true);
#nullable restore
#line 13 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Index.cshtml"
WriteAttributeValue("", 377, rows, 377, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 382, "pl-4", 383, 5, true);
            WriteAttributeValue(" ", 387, "pr-2", 388, 5, true);
            WriteAttributeValue(" ", 392, "pb-2", 393, 5, true);
            WriteAttributeValue(" ", 397, "leading-loose", 398, 14, true);
            EndWriteAttribute();
            WriteLiteral(">\n        <h2 class=\"text-2xl mb-4 font-medium\">Categories</h2>\n        <ul>\n            <li><a href=\"#\">(");
#nullable restore
#line 16 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Index.cshtml"
                        Write(products.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(") Soaps</a></li>\n            <li class=\"italic\">Candles (soon..)</li>\n            <li class=\"italic\">Bath bombs (soon..)</li>\n            <li class=\"italic\">Gift sets (soon..)</li>\n        </ul>\n    </div>\n");
#nullable restore
#line 22 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Index.cshtml"
     foreach(var p in products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"border border-black p-2 text-center\">\n                    <div class=\"image-holder mb-4\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 933, "\"", 947, 1);
#nullable restore
#line 26 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Index.cshtml"
WriteAttributeValue("", 939, p.Image, 939, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n                    </div>\n                    <h3 class=\"font-semibold uppercase\">");
#nullable restore
#line 28 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Index.cshtml"
                                                   Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <h6 class=\"text-gray-500 italic text-sm\">");
#nullable restore
#line 29 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Index.cshtml"
                                                        Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" USD</h6>\n\n                    <button class=\"bg-black text-white pl-6 pr-6 font-sans font-semibold mt-2\">\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1245, "\"", 1271, 2);
            WriteAttributeValue("", 1252, "/shop/details/", 1252, 14, true);
#nullable restore
#line 32 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Index.cshtml"
WriteAttributeValue("", 1266, p.ID, 1266, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">BUY</a>\n                    </button>\n                </div>\n");
#nullable restore
#line 35 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\n");
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
