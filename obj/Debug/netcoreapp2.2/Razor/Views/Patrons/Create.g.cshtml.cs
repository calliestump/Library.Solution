#pragma checksum "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c23a574d711338c5e14318f7a671e1fee9e1762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patrons_Create), @"mvc.1.0.view", @"/Views/Patrons/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patrons/Create.cshtml", typeof(AspNetCore.Views_Patrons_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c23a574d711338c5e14318f7a671e1fee9e1762", @"/Views/Patrons/Create.cshtml")]
    public class Views_Patrons_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Patron>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Create.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(58, 55, true);
            WriteLiteral("<div class=\"container card\">\n<h4>Add a new Patron</h4>\n");
            EndContext();
#line 7 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Create.cshtml"
 using(Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(143, 25, false);
#line 9 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Create.cshtml"
Write(Html.Label("Patron Name"));

#line default
#line hidden
            EndContext();
            BeginContext(169, 9, true);
            WriteLiteral("  <br />\n");
            EndContext();
            BeginContext(181, 42, false);
#line 11 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Create.cshtml"
Write(Html.TextBoxFor(model => model.PatronName));

#line default
#line hidden
            EndContext();
            BeginContext(224, 60, true);
            WriteLiteral("  <br />\n  <input type=\"submit\" value=\"Add a new Patron\" />\n");
            EndContext();
#line 14 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Create.cshtml"
}

#line default
#line hidden
            BeginContext(286, 10, true);
            WriteLiteral("<br />\n<p>");
            EndContext();
            BeginContext(297, 44, false);
#line 16 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Create.cshtml"
Write(Html.ActionLink("Show all patrons", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(341, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(350, 40, false);
#line 17 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Patrons/Create.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(390, 11, true);
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