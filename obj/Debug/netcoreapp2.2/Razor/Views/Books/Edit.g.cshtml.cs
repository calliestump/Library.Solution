#pragma checksum "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13340bbe82f302b0e89e0c025e3c348a39e68e6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Edit), @"mvc.1.0.view", @"/Views/Books/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Edit.cshtml", typeof(AspNetCore.Views_Books_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13340bbe82f302b0e89e0c025e3c348a39e68e6b", @"/Views/Books/Edit.cshtml")]
    public class Views_Books_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(54, 58, true);
            WriteLiteral("<div class=\"container card\">\n<h1>Edit This Book</h1>\n\n<h4>");
            EndContext();
            BeginContext(113, 40, false);
#line 8 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Edit.cshtml"
Write(Html.DisplayFor(model => model.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(153, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 10 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(193, 37, false);
#line 12 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Edit.cshtml"
Write(Html.HiddenFor(model => model.BookId));

#line default
#line hidden
            EndContext();
            BeginContext(238, 38, false);
#line 14 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Edit.cshtml"
Write(Html.LabelFor(model => model.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(282, 39, false);
#line 15 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Edit.cshtml"
Write(Html.EditorFor(model => model.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(323, 64, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" class=\"btn btn-warning\"/>\n");
            EndContext();
#line 18 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(389, 64, true);
            WriteLiteral("\n<input class=\"btn btn-info\" type=\"button\" value=\"Engineer List\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 453, "\'", 500, 3);
            WriteAttributeValue("", 463, "location.href=\"", 463, 15, true);
#line 20 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Edit.cshtml"
WriteAttributeValue("", 478, Url.Action("Index"), 478, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 498, "\";", 498, 2, true);
            EndWriteAttribute();
            BeginContext(501, 58, true);
            WriteLiteral(" />\n<input class=\"btn btn-info\" type=\"button\" value=\"Home\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 559, "\'", 614, 3);
            WriteAttributeValue("", 569, "location.href=\"", 569, 15, true);
#line 21 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Books/Edit.cshtml"
WriteAttributeValue("", 584, Url.Action("Index", "Home"), 584, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 612, "\";", 612, 2, true);
            EndWriteAttribute();
            BeginContext(615, 3, true);
            WriteLiteral(" />");
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
