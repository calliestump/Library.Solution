#pragma checksum "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c942d078bc741a8f2040d9f24194abed1364dfc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Create), @"mvc.1.0.view", @"/Views/Authors/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authors/Create.cshtml", typeof(AspNetCore.Views_Authors_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c942d078bc741a8f2040d9f24194abed1364dfc4", @"/Views/Authors/Create.cshtml")]
    public class Views_Authors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Create.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 55, true);
            WriteLiteral("<div class=\"container card\">\n<h4>Add a new author</h4>\n");
            EndContext();
#line 8 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(145, 25, false);
#line 10 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Create.cshtml"
Write(Html.Label("Author Name"));

#line default
#line hidden
            EndContext();
            BeginContext(170, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
            BeginContext(178, 42, false);
#line 11 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Create.cshtml"
Write(Html.TextBoxFor(model => model.AuthorName));

#line default
#line hidden
            EndContext();
            BeginContext(220, 9, true);
            WriteLiteral("<br><br>\n");
            EndContext();
            BeginContext(230, 51, true);
            WriteLiteral("  <input type=\"submit\" value=\"Add a new author\" />\n");
            EndContext();
#line 14 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Create.cshtml"
}

#line default
#line hidden
            BeginContext(283, 8, true);
            WriteLiteral("\n<br><p>");
            EndContext();
            BeginContext(292, 44, false);
#line 16 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Create.cshtml"
  Write(Html.ActionLink("Show all Authors", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(336, 11, true);
            WriteLiteral("</p>\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
