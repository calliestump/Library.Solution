#pragma checksum "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Account/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad0fbdcc323d8fcda4e93e2acb51af0f5a1a30c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 5 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Account/Login.cshtml"
using Library.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad0fbdcc323d8fcda4e93e2acb51af0f5a1a30c6", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Account/Login.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(54, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(77, 70, true);
            WriteLiteral("<div class=\"container card\">\n<h2>Log in with your account</h2>\n<hr />\n");
            EndContext();
#line 11 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Account/Login.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(180, 27, false);
#line 13 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Account/Login.cshtml"
Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(207, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
            BeginContext(217, 29, false);
#line 14 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Account/Login.cshtml"
Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(246, 9, true);
            WriteLiteral("<br><br>\n");
            EndContext();
            BeginContext(261, 30, false);
#line 16 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Account/Login.cshtml"
Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(291, 5, true);
            WriteLiteral("<br>\n");
            EndContext();
            BeginContext(301, 33, false);
#line 17 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Account/Login.cshtml"
Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(334, 9, true);
            WriteLiteral("<br><br>\n");
            EndContext();
            BeginContext(344, 67, true);
            WriteLiteral("    <input type=\"submit\" value=\"Log in\" class=\"btn btn-default\" />\n");
            EndContext();
#line 20 "/Users/callie/Desktop/Week12/Library.Solution/Library/Views/Account/Login.cshtml"
}

#line default
#line hidden
            BeginContext(413, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
