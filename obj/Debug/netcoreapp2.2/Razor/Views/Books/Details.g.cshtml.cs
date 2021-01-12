#pragma checksum "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82309de7c4a6d2d69a28cef7ff58b93965438f38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Details.cshtml", typeof(AspNetCore.Views_Books_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82309de7c4a6d2d69a28cef7ff58b93965438f38", @"/Views/Books/Details.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 69, true);
            WriteLiteral("\n<div class=\"container card\">\n  <h2>Book Details</h2>\n  <hr />\n  <h3>");
            EndContext();
            BeginContext(128, 25, false);
#line 10 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
 Write(Html.DisplayName("Title"));

#line default
#line hidden
            EndContext();
            BeginContext(153, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(156, 40, false);
#line 10 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
                             Write(Html.DisplayFor(model => model.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(196, 9, true);
            WriteLiteral("</h3>\n  \n");
            EndContext();
#line 12 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
   if(@Model.Copies.Count == 0)
  {

#line default
#line hidden
            BeginContext(241, 54, true);
            WriteLiteral("    <p>There are no available copies of this book</p>\n");
            EndContext();
#line 15 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
  }
  else
  {

#line default
#line hidden
            BeginContext(310, 35, true);
            WriteLiteral("    <p>Number of available copies: ");
            EndContext();
            BeginContext(346, 18, false);
#line 18 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
                              Write(Model.Copies.Count);

#line default
#line hidden
            EndContext();
            BeginContext(364, 6, true);
            WriteLiteral(" </p>\n");
            EndContext();
#line 19 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(374, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 21 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
   if(@Model.Authors.Count == 0)
  {

#line default
#line hidden
            BeginContext(412, 44, true);
            WriteLiteral("    <p>No authors assigned to this book</p>\n");
            EndContext();
#line 24 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
  }
  else
  {

#line default
#line hidden
            BeginContext(471, 28, true);
            WriteLiteral("    <h4><u>Authors</u></h4>\n");
            EndContext();
#line 28 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
     foreach(var join in Model.Authors)
    {

#line default
#line hidden
            BeginContext(545, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(556, 22, false);
#line 30 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
     Write(join.Author.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(578, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 31 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
       using (Html.BeginForm("DeleteAuthor", "Books"))
      {
        

#line default
#line hidden
            BeginContext(656, 41, false);
#line 33 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
   Write(Html.Hidden("joinId", @join.AuthorBookId));

#line default
#line hidden
            EndContext();
            BeginContext(698, 46, true);
            WriteLiteral("        <input type=\"submit\" value=\"Delete\"/>\n");
            EndContext();
#line 35 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
      }

#line default
#line hidden
#line 35 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
       
    }

#line default
#line hidden
#line 36 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
     
  }

#line default
#line hidden
            BeginContext(762, 6, true);
            WriteLiteral("\n  <p>");
            EndContext();
            BeginContext(769, 67, false);
#line 39 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
Write(Html.ActionLink("Add a copy", "AddCopy", new { id = Model.BookId }));

#line default
#line hidden
            EndContext();
            BeginContext(836, 19, true);
            WriteLiteral("</p>\n  <br />\n  <p>");
            EndContext();
            BeginContext(856, 46, false);
#line 41 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
Write(Html.ActionLink("Back to books page", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(902, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(913, 69, false);
#line 42 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
Write(Html.ActionLink("Add author", "AddAuthor", new { id = Model.BookId }));

#line default
#line hidden
            EndContext();
            BeginContext(982, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(993, 67, false);
#line 43 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
Write(Html.ActionLink("Delete Book", "Delete", new { id = Model.BookId }));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 10, true);
            WriteLiteral("</p>\n  <p>");
            EndContext();
            BeginContext(1071, 40, false);
#line 44 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Details.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 12, true);
            WriteLiteral("</p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
