#pragma checksum "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f67242ce95565a90cd949aa6efdc17bf5f7a6d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patrons_Details), @"mvc.1.0.view", @"/Views/Patrons/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patrons/Details.cshtml", typeof(AspNetCore.Views_Patrons_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f67242ce95565a90cd949aa6efdc17bf5f7a6d4", @"/Views/Patrons/Details.cshtml")]
    public class Views_Patrons_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Patron>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 64, true);
            WriteLiteral("<div class=\"container card\">\n<h2>Patron Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(125, 46, false);
#line 9 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Details.cshtml"
Write(Html.DisplayNameFor(model => model.PatronName));

#line default
#line hidden
            EndContext();
            BeginContext(171, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(174, 42, false);
#line 9 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Details.cshtml"
                                                Write(Html.DisplayFor(model => model.PatronName));

#line default
#line hidden
            EndContext();
            BeginContext(216, 8, true);
            WriteLiteral(" </h3>\n\n");
            EndContext();
#line 11 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Details.cshtml"
 if(Model.Copies.Count == 0)
{

#line default
#line hidden
            BeginContext(255, 43, true);
            WriteLiteral("    <p>No books have been checked out.</p>\n");
            EndContext();
#line 14 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(307, 41, true);
            WriteLiteral("    <h4>Checked out Books:</h4>\n    <ul>\n");
            EndContext();
#line 19 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Details.cshtml"
     foreach(var join in Model.Copies)
    {

#line default
#line hidden
            BeginContext(393, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(406, 16, false);
#line 21 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Details.cshtml"
       Write(join.Copy.CopyId);

#line default
#line hidden
            EndContext();
            BeginContext(422, 7, true);
            WriteLiteral("</li> \n");
            EndContext();
#line 22 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Details.cshtml"
    }

#line default
#line hidden
            BeginContext(435, 10, true);
            WriteLiteral("    </ul>\n");
            EndContext();
#line 24 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Details.cshtml"
}

#line default
#line hidden
            BeginContext(447, 10, true);
            WriteLiteral("<br />\n<p>");
            EndContext();
            BeginContext(458, 40, false);
#line 26 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Details.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(498, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(507, 48, false);
#line 27 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Details.cshtml"
Write(Html.ActionLink("Back to Patrons page", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(555, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Patron> Html { get; private set; }
    }
}
#pragma warning restore 1591
