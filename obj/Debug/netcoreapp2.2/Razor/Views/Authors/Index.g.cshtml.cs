#pragma checksum "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68de0c186fc7e94ef230dc27cf23577d0114b0dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Index), @"mvc.1.0.view", @"/Views/Authors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authors/Index.cshtml", typeof(AspNetCore.Views_Authors_Index))]
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
#line 5 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Index.cshtml"
using Library.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68de0c186fc7e94ef230dc27cf23577d0114b0dc", @"/Views/Authors/Index.cshtml")]
    public class Views_Authors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Library.Models.Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(89, 193, true);
            WriteLiteral("<div class=\"container card\">\n<h1>Authors</h1>\n<form>\n    <i class=\"glyphicon glyphicon-search\"></i><input type=\"text\" name=\"AuthorSearch\" placeholder=\"search and press enter\"><br><br>\n</form>\n\n");
            EndContext();
#line 13 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(308, 58, true);
            WriteLiteral("  <h3>No authors have been added to library database</h3>\n");
            EndContext();
#line 16 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Index.cshtml"
}

#line default
#line hidden
            BeginContext(368, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 18 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Index.cshtml"
 foreach(Author author in Model)
{

#line default
#line hidden
            BeginContext(404, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(411, 80, false);
#line 20 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Index.cshtml"
 Write(Html.ActionLink($"{author.AuthorName}", "Details", new { id = author.AuthorId }));

#line default
#line hidden
            EndContext();
            BeginContext(491, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 21 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Index.cshtml"
}

#line default
#line hidden
            BeginContext(499, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(564, 68, true);
            WriteLiteral("<input class=\"btn btn-info\" type=\"button\" value=\"Delete All Authors\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 632, "\'", 683, 3);
            WriteAttributeValue("", 642, "location.href=\"", 642, 15, true);
#line 24 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Index.cshtml"
WriteAttributeValue("", 657, Url.Action("DeleteAll"), 657, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 681, "\";", 681, 2, true);
            EndWriteAttribute();
            BeginContext(684, 15, true);
            WriteLiteral(" /><br>\n<br><p>");
            EndContext();
            BeginContext(700, 43, false);
#line 25 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Index.cshtml"
  Write(Html.ActionLink("Add new author", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(743, 12, true);
            WriteLiteral("</p>\n<br><p>");
            EndContext();
            BeginContext(756, 40, false);
#line 26 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Authors/Index.cshtml"
  Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(796, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Library.Models.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
