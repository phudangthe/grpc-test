#pragma checksum "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\ResetPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84a2400ac4390e08348d69862f875ab0b819568f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ResetPasswordConfirmation), @"mvc.1.0.view", @"/Views/Account/ResetPasswordConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ResetPasswordConfirmation.cshtml", typeof(AspNetCore.Views_Account_ResetPasswordConfirmation))]
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
#line 1 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\ResetPasswordConfirmation.cshtml"
using StsServerIdentity.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84a2400ac4390e08348d69862f875ab0b819568f", @"/Views/Account/ResetPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb4a04f4a80204e19bfa929c1176379d28e4671", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ResetPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\ResetPasswordConfirmation.cshtml"
  
    ViewData["Title"] = @SharedLocalizer.GetLocalizedHtmlString("RESET_PASSWORD_CONFIRMATION");

#line default
#line hidden
            BeginContext(176, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(181, 17, false);
#line 6 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\ResetPasswordConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(198, 17, true);
            WriteLiteral(".</h1>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(216, 85, false);
#line 8 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\ResetPasswordConfirmation.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("RESET_PASSWORD_YOUR_PASSWORD_HAS_BEEN_RESET"));

#line default
#line hidden
            EndContext();
            BeginContext(301, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(302, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84a2400ac4390e08348d69862f875ab0b819568f5947", async() => {
                BeginContext(350, 76, false);
#line 8 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\ResetPasswordConfirmation.cshtml"
                                                                                                                                     Write(SharedLocalizer.GetLocalizedHtmlString("RESET_PASSWORD_CLICK_HERE_TO_LOGIN"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(430, 18, true);
            WriteLiteral(".\r\n</p>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(449, 75, false);
#line 11 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\ResetPasswordConfirmation.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("RESET_PASSWORD_CONFIRMATION_TEXT1"));

#line default
#line hidden
            EndContext();
            BeginContext(524, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84a2400ac4390e08348d69862f875ab0b819568f8226", async() => {
                BeginContext(572, 80, false);
#line 11 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Account\ResetPasswordConfirmation.cshtml"
                                                                                                                          Write(SharedLocalizer.GetLocalizedHtmlString("RESET_PASSWORD_CONFIRMATION_CLICK_HERE"));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(656, 9, true);
            WriteLiteral(".\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
