#pragma checksum "C:\Users\azerh\Desktop\C# Html\Asp.net\Fiorello\Fiorello\Fiorello\Views\Shared\Components\Blog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f77c2d8ac6942c6d1e11b162c3d6882cdf2cde41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Blog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Blog/Default.cshtml")]
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
#line 1 "C:\Users\azerh\Desktop\C# Html\Asp.net\Fiorello\Fiorello\Fiorello\Views\_ViewImports.cshtml"
using Fiorello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\azerh\Desktop\C# Html\Asp.net\Fiorello\Fiorello\Fiorello\Views\_ViewImports.cshtml"
using Fiorello.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\azerh\Desktop\C# Html\Asp.net\Fiorello\Fiorello\Fiorello\Views\_ViewImports.cshtml"
using Fiorello.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f77c2d8ac6942c6d1e11b162c3d6882cdf2cde41", @"/Views/Shared/Components/Blog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ff8a5cd5c9001ff4c6f2ac6a74a3397547b9e88", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Blog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section id=""blog"">
    <div class=""container"">
        <div class=""row py-5"">
            <div class=""offset-lg-3 col-lg-6"">
                <div class=""section-title"">
                    <h1>From our Blog</h1>
                    <p class=""text-black-50"">
                        A perfect blend of creativity, energy, communication, happiness and
                        love. Let us arrange
                        a smile for you.
                    </p>
                </div>
            </div>
        </div>
        <div class=""row pb-5"">
");
#nullable restore
#line 18 "C:\Users\azerh\Desktop\C# Html\Asp.net\Fiorello\Fiorello\Fiorello\Views\Shared\Components\Blog\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4\">\r\n                    <div class=\"item\">\r\n                        <div class=\"img position-relative\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 834, "\"", 855, 2);
            WriteAttributeValue("", 840, "img/", 840, 4, true);
#nullable restore
#line 23 "C:\Users\azerh\Desktop\C# Html\Asp.net\Fiorello\Fiorello\Fiorello\Views\Shared\Components\Blog\Default.cshtml"
WriteAttributeValue("", 844, item.Image, 844, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 874, "\"", 880, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                                <span>");
#nullable restore
#line 25 "C:\Users\azerh\Desktop\C# Html\Asp.net\Fiorello\Fiorello\Fiorello\Views\Shared\Components\Blog\Default.cshtml"
                                 Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"text mt-3 text-center px-5\">\r\n                            <h5>");
#nullable restore
#line 29 "C:\Users\azerh\Desktop\C# Html\Asp.net\Fiorello\Fiorello\Fiorello\Views\Shared\Components\Blog\Default.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"text-black-50\">\r\n                                ");
#nullable restore
#line 31 "C:\Users\azerh\Desktop\C# Html\Asp.net\Fiorello\Fiorello\Fiorello\Views\Shared\Components\Blog\Default.cshtml"
                           Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 36 "C:\Users\azerh\Desktop\C# Html\Asp.net\Fiorello\Fiorello\Fiorello\Views\Shared\Components\Blog\Default.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
