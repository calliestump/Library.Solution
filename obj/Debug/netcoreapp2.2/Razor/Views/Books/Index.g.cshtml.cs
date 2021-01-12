#pragma checksum "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d538b9998bc850107018cf9e4de2424c77bfe9c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Index.cshtml", typeof(AspNetCore.Views_Books_Index))]
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
#line 5 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
using Library.Models;

#line default
#line hidden
#line 6 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d538b9998bc850107018cf9e4de2424c77bfe9c9", @"/Views/Books/Index.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(121, 43, true);
            WriteLiteral("<div class=\"container card\">\n<h2>Books for ");
            EndContext();
            BeginContext(165, 18, false);
#line 9 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
         Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(183, 143, true);
            WriteLiteral("</h2>\n<form>\n    <i class=\"glyphicon glyphicon-search\"></i><input type=\"text\" name=\"BookSearch\" placeholder=\"search and press enter\">\n</form>\n\n");
            EndContext();
#line 14 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(346, 7, true);
            WriteLiteral("  <ul>\n");
            EndContext();
#line 17 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
     foreach (Book book in Model)
    {

#line default
#line hidden
            BeginContext(393, 14, true);
            WriteLiteral("      <br><li>");
            EndContext();
            BeginContext(408, 72, false);
#line 19 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
         Write(Html.ActionLink($"{book.BookName}", "Details", new { id = book.BookId }));

#line default
#line hidden
            EndContext();
            BeginContext(480, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 20 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(492, 10, true);
            WriteLiteral("  </ul>  \n");
            EndContext();
#line 22 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(511, 37, true);
            WriteLiteral("  <h3>No books have been added.</h3>\n");
            EndContext();
#line 26 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
}

#line default
#line hidden
            BeginContext(550, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(554, 41, false);
#line 27 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
Write(Html.ActionLink("Add new book", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(595, 71, true);
            WriteLiteral("</p>\n<input class=\"btn btn-info\" type=\"button\" value=\"Delete All Books\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 666, "\'", 717, 3);
            WriteAttributeValue("", 676, "location.href=\"", 676, 15, true);
#line 28 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
WriteAttributeValue("", 691, Url.Action("DeleteAll"), 691, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 715, "\";", 715, 2, true);
            EndWriteAttribute();
            BeginContext(718, 15, true);
            WriteLiteral(" /><br>\n<br><p>");
            EndContext();
            BeginContext(734, 40, false);
#line 29 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Index.cshtml"
  Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(774, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591