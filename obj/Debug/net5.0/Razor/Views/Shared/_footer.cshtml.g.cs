#pragma checksum "C:\Users\thanh.nth176871\Source\Repos\dotnet-mvc_web\Views\Shared\_footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f222474b1892bef7de79e85d4b0ea10b560bad53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__footer), @"mvc.1.0.view", @"/Views/Shared/_footer.cshtml")]
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
#line 1 "C:\Users\thanh.nth176871\Source\Repos\dotnet-mvc_web\Views\_ViewImports.cshtml"
using dotnet_mvc_web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thanh.nth176871\Source\Repos\dotnet-mvc_web\Views\_ViewImports.cshtml"
using dotnet_mvc_web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f222474b1892bef7de79e85d4b0ea10b560bad53", @"/Views/Shared/_footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ec8a79f37dd75cf31989a6f7f47915a38360e7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer class=\"border-top footer text-muted text-center\">\r\n    <div class=\"container\">\r\n        Copyright &copy; Book Store ");
#nullable restore
#line 3 "C:\Users\thanh.nth176871\Source\Repos\dotnet-mvc_web\Views\Shared\_footer.cshtml"
                               Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        <custom-email my-email=\"nuhoangchecnhac@gmail.com\"></custom-email>\r\n    </div>\r\n</footer>\r\n");
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
