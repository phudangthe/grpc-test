#pragma checksum "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\LoggedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adc477800dfad2b233f5b3758e871b7bdf09d644"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LoggedOut), @"mvc.1.0.view", @"/Views/Account/LoggedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/LoggedOut.cshtml", typeof(AspNetCore.Views_Account_LoggedOut))]
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
#line 1 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\_ViewImports.cshtml"
using StsServerIdentity;

#line default
#line hidden
#line 2 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\_ViewImports.cshtml"
using StsServerIdentity.Models;

#line default
#line hidden
#line 3 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\_ViewImports.cshtml"
using StsServerIdentity.Models.AccountViewModels;

#line default
#line hidden
#line 4 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\_ViewImports.cshtml"
using StsServerIdentity.Models.ManageViewModels;

#line default
#line hidden
#line 5 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\LoggedOut.cshtml"
using StsServerIdentity.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adc477800dfad2b233f5b3758e871b7bdf09d644", @"/Views/Account/LoggedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb4a04f4a80204e19bfa929c1176379d28e4671", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LoggedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StsServerIdentity.Models.LoggedOutViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(124, 54, true);
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <h1>\r\n        <small>");
            EndContext();
            BeginContext(179, 53, false);
#line 7 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\LoggedOut.cshtml"
          Write(SharedLocalizer.GetLocalizedHtmlString("LOGOUT_TEXT"));

#line default
#line hidden
            EndContext();
            BeginContext(232, 23, true);
            WriteLiteral("</small>\r\n    </h1>\r\n\r\n");
            EndContext();
#line 10 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\LoggedOut.cshtml"
     if (Model.PostLogoutRedirectUri != null)
    {

#line default
#line hidden
            BeginContext(309, 27, true);
            WriteLiteral("        <div>\r\n            ");
            EndContext();
            BeginContext(337, 58, false);
#line 13 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\LoggedOut.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("LOGOUT_RETURN_TO"));

#line default
#line hidden
            EndContext();
            BeginContext(395, 3, true);
            WriteLiteral(" <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 398, "\"", 433, 1);
#line 13 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 405, Model.PostLogoutRedirectUri, 405, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(434, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(436, 16, false);
#line 13 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\LoggedOut.cshtml"
                                                                                                          Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(452, 22, true);
            WriteLiteral("</a>\r\n        </div>\r\n");
            EndContext();
#line 15 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            BeginContext(481, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\LoggedOut.cshtml"
     if (Model.SignOutIframeUrl != null)
    {

#line default
#line hidden
            BeginContext(532, 44, true);
            WriteLiteral("        <iframe class=\"signout logoutiframe\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 576, "\"", 605, 1);
#line 19 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 582, Model.SignOutIframeUrl, 582, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(606, 12, true);
            WriteLiteral("></iframe>\r\n");
            EndContext();
#line 20 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            BeginContext(625, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StsServerIdentity.Models.LoggedOutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
