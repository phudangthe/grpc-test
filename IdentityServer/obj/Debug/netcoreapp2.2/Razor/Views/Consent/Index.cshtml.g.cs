#pragma checksum "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eee53455a26f0d334ed58d87cae7cf3656816880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent_Index), @"mvc.1.0.view", @"/Views/Consent/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/Index.cshtml", typeof(AspNetCore.Views_Consent_Index))]
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
#line 1 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
using StsServerIdentity.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eee53455a26f0d334ed58d87cae7cf3656816880", @"/Views/Consent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb4a04f4a80204e19bfa929c1176379d28e4671", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StsServerIdentity.Models.ConsentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-scopecheck big_checkbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(122, 111, true);
            WriteLiteral("\r\n<div class=\"page-consent\">\r\n    <div class=\"row page-header consent-form\">\r\n        <div class=\"col-sm-10\">\r\n");
            EndContext();
#line 8 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
             if (Model.ClientLogoUrl != null)
            {

#line default
#line hidden
            BeginContext(295, 45, true);
            WriteLiteral("                <div class=\"client-logo\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 340, "\"", 366, 1);
#line 10 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
WriteAttributeValue("", 346, Model.ClientLogoUrl, 346, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(367, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 11 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(391, 34, true);
            WriteLiteral("            <h1>\r\n                ");
            EndContext();
            BeginContext(426, 16, false);
#line 13 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
           Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(442, 25, true);
            WriteLiteral("\r\n                <small>");
            EndContext();
            BeginContext(468, 79, false);
#line 14 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                  Write(SharedLocalizer.GetLocalizedHtmlString("CONSENT_IS_REQUESTING_YOUR_PERMISSION"));

#line default
#line hidden
            EndContext();
            BeginContext(547, 126, true);
            WriteLiteral("</small>\r\n            </h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(674, 45, false);
#line 21 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
       Write(await Html.PartialAsync("_ValidationSummary"));

#line default
#line hidden
            EndContext();
            BeginContext(719, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(735, 3199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eee53455a26f0d334ed58d87cae7cf36568168808308", async() => {
                BeginContext(781, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(799, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eee53455a26f0d334ed58d87cae7cf36568168808706", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 24 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(842, 25, true);
                WriteLiteral("\r\n\r\n                <div>");
                EndContext();
                BeginContext(868, 69, false);
#line 26 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                Write(SharedLocalizer.GetLocalizedHtmlString("CONSENT_IS_CHECK_UNREQUIRED"));

#line default
#line hidden
                EndContext();
                BeginContext(937, 10, true);
                WriteLiteral("</div>\r\n\r\n");
                EndContext();
#line 28 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                 if (Model.IdentityScopes.Any())
                {

#line default
#line hidden
                BeginContext(1016, 244, true);
                WriteLiteral("                    <div class=\"panel panel-default consent-buttons\">\r\n                        <div class=\"panel-heading consent-title-spacing-bottom\">\r\n                            <span class=\"fas fa-user\"></span>\r\n                            ");
                EndContext();
                BeginContext(1261, 70, false);
#line 33 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                       Write(SharedLocalizer.GetLocalizedHtmlString("CONSENT_PERSONAL_INFORMATION"));

#line default
#line hidden
                EndContext();
                BeginContext(1331, 83, true);
                WriteLiteral("\r\n                        </div>\r\n                        <ul class=\"list-group\">\r\n");
                EndContext();
#line 36 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                             foreach (var scope in Model.IdentityScopes)
                            {
                                

#line default
#line hidden
                BeginContext(1552, 48, false);
#line 38 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                           Write(await Html.PartialAsync("_ScopeListItem", scope));

#line default
#line hidden
                EndContext();
#line 38 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                                                                                 
                            }

#line default
#line hidden
                BeginContext(1633, 59, true);
                WriteLiteral("                        </ul>\r\n                    </div>\r\n");
                EndContext();
#line 42 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1711, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                 if (Model.ResourceScopes.Any())
                {

#line default
#line hidden
                BeginContext(1782, 255, true);
                WriteLiteral("                    <div class=\"panel panel-default\">\r\n                        <div class=\"panel-heading consent-title-spacing-bottom consent-title-spacing-top\">\r\n                            <span class=\"fas fa-tasks\"></span>\r\n                            ");
                EndContext();
                BeginContext(2038, 68, false);
#line 49 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                       Write(SharedLocalizer.GetLocalizedHtmlString("CONSENT_APPLICATION_ACCESS"));

#line default
#line hidden
                EndContext();
                BeginContext(2106, 83, true);
                WriteLiteral("\r\n                        </div>\r\n                        <ul class=\"list-group\">\r\n");
                EndContext();
#line 52 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                             foreach (var scope in Model.ResourceScopes)
                            {
                                

#line default
#line hidden
                BeginContext(2327, 48, false);
#line 54 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                           Write(await Html.PartialAsync("_ScopeListItem", scope));

#line default
#line hidden
                EndContext();
#line 54 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                                                                                 
                            }

#line default
#line hidden
                BeginContext(2408, 59, true);
                WriteLiteral("                        </ul>\r\n                    </div>\r\n");
                EndContext();
#line 58 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2486, 50, true);
                WriteLiteral("\r\n                <div class=\"consent-remember\">\r\n");
                EndContext();
#line 61 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                     if (Model.AllowRememberConsent)
                    {

#line default
#line hidden
                BeginContext(2613, 156, true);
                WriteLiteral("                        <div class=\"consent-title-spacing consent-title-spacing-top\">\r\n                            <label>\r\n                                ");
                EndContext();
                BeginContext(2769, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eee53455a26f0d334ed58d87cae7cf365681688016560", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 65 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2844, 65, true);
                WriteLiteral("\r\n                                <strong class=\"consent-middle\">");
                EndContext();
                BeginContext(2910, 70, false);
#line 66 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                                                          Write(SharedLocalizer.GetLocalizedHtmlString("CONSENT_REMEMBER_MY_DECISION"));

#line default
#line hidden
                EndContext();
                BeginContext(2980, 81, true);
                WriteLiteral("</strong>\r\n                            </label>\r\n                        </div>\r\n");
                EndContext();
#line 69 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(3084, 145, true);
                WriteLiteral("\r\n                    <div class=\"consent-buttons\">\r\n                        <button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>");
                EndContext();
                BeginContext(3230, 61, false);
#line 72 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                                                                                       Write(SharedLocalizer.GetLocalizedHtmlString("CONSENT_YES_ALLOWED"));

#line default
#line hidden
                EndContext();
                BeginContext(3291, 80, true);
                WriteLiteral("</button>\r\n                        <button name=\"button\" value=\"no\" class=\"btn\">");
                EndContext();
                BeginContext(3372, 64, false);
#line 73 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                                                                Write(SharedLocalizer.GetLocalizedHtmlString("CONSENT_NO_NOT_ALLOWED"));

#line default
#line hidden
                EndContext();
                BeginContext(3436, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 74 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                         if (Model.ClientUrl != null)
                        {

#line default
#line hidden
                BeginContext(3529, 81, true);
                WriteLiteral("                            <a class=\"pull-right btn btn-primary\" target=\"_blank\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3610, "\"", 3633, 1);
#line 76 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
WriteAttributeValue("", 3617, Model.ClientUrl, 3617, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3634, 140, true);
                WriteLiteral(">\r\n                                <span class=\"fas fa-info-circle\"></span>\r\n                                <strong class=\"consent-middle\">");
                EndContext();
                BeginContext(3775, 16, false);
#line 78 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                                                          Write(Model.ClientName);

#line default
#line hidden
                EndContext();
                BeginContext(3791, 45, true);
                WriteLiteral("</strong>\r\n                            </a>\r\n");
                EndContext();
#line 80 "D:\Dev\Lowell\Dev\Main\TestgRPCAuthentication\TestgRPCAuthentication\IdentityServer\Views\Consent\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(3863, 64, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3934, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StsServerIdentity.Models.ConsentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
