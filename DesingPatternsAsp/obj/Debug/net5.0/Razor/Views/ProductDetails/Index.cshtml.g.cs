#pragma checksum "C:\Users\vmartinez\Source\Repos\vmartinez1984\TutorialHDeLeon\DesingPatternsAsp\Views\ProductDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "649ceae67a9f17becdc1b2a8d0c48ac8b1827810"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetails_Index), @"mvc.1.0.view", @"/Views/ProductDetails/Index.cshtml")]
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
#line 1 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TutorialHDeLeon\DesingPatternsAsp\Views\_ViewImports.cshtml"
using DesingPatternsAsp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TutorialHDeLeon\DesingPatternsAsp\Views\_ViewImports.cshtml"
using DesingPatternsAsp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"649ceae67a9f17becdc1b2a8d0c48ac8b1827810", @"/Views/ProductDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef61e95e8e937e11b4b9efe6156e9b0e9df145f3", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TutorialHDeLeon\DesingPatternsAsp\Views\ProductDetails\Index.cshtml"
  
    decimal totalLocal = (decimal)ViewBag.TotalLocal;
    decimal totalForeign = (decimal)ViewBag.TotalForeign;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n       Total local: <b>");
#nullable restore
#line 8 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TutorialHDeLeon\DesingPatternsAsp\Views\ProductDetails\Index.cshtml"
                  Write(totalLocal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        Total extranjero: <b>");
#nullable restore
#line 14 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TutorialHDeLeon\DesingPatternsAsp\Views\ProductDetails\Index.cshtml"
                        Write(totalForeign);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    </div>\r\n</div>");
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
