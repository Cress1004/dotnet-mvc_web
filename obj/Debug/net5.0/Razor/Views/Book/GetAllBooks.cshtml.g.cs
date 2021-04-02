#pragma checksum "/home/cress/dotnet/dotnet-mvc_web/Views/Book/GetAllBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "941dbf0c0d5f4ff629d2e83b2e513d022283c886"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetAllBooks), @"mvc.1.0.view", @"/Views/Book/GetAllBooks.cshtml")]
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
#line 1 "/home/cress/dotnet/dotnet-mvc_web/Views/_ViewImports.cshtml"
using dotnet_mvc_web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/cress/dotnet/dotnet-mvc_web/Views/Book/GetAllBooks.cshtml"
using dotnet_mvc_web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"941dbf0c0d5f4ff629d2e83b2e513d022283c886", @"/Views/Book/GetAllBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c413920a7e078124f77894e19adad4925e6a084", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetAllBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/unnamed.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("unnamed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "/home/cress/dotnet/dotnet-mvc_web/Views/Book/GetAllBooks.cshtml"
  
    ViewData["Title"] = "Get All Books";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <div class=\"container\">\n         <h1 class=\"display-4\">All Books</h1>\n        <div class=\"row\">\n");
#nullable restore
#line 12 "/home/cress/dotnet/dotnet-mvc_web/Views/Book/GetAllBooks.cshtml"
             foreach (var book in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\n                <div class=\"card mb-4 shadow-sm\" style=\"width: 18rem;\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "941dbf0c0d5f4ff629d2e83b2e513d022283c8864756", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <div class=\"card-body\">\n                        <h3 class=\"card-title\">");
#nullable restore
#line 18 "/home/cress/dotnet/dotnet-mvc_web/Views/Book/GetAllBooks.cshtml"
                                          Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                        <p class=\"card-text\">");
#nullable restore
#line 19 "/home/cress/dotnet/dotnet-mvc_web/Views/Book/GetAllBooks.cshtml"
                                        Write(book.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <div class=\"d-flex justify-content-between align-items-center\">\n                            <div class=\"btn-group\">\n                                <a");
            BeginWriteAttribute("href", " href=\"", 891, "\"", 920, 2);
            WriteAttributeValue("", 898, "/book/getbook/", 898, 14, true);
#nullable restore
#line 22 "/home/cress/dotnet/dotnet-mvc_web/Views/Book/GetAllBooks.cshtml"
WriteAttributeValue("", 912, book.Id, 912, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-secondary\">View Details</a>\n                            </div>\n                            <small class=\"text-muted\">");
#nullable restore
#line 24 "/home/cress/dotnet/dotnet-mvc_web/Views/Book/GetAllBooks.cshtml"
                                                 Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n                        </div>\n                    </div>\n                </div>\n            </div>                \n");
#nullable restore
#line 29 "/home/cress/dotnet/dotnet-mvc_web/Views/Book/GetAllBooks.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
