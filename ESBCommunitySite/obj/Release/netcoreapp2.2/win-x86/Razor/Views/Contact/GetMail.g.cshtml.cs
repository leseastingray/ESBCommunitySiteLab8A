#pragma checksum "C:\Users\Merokemeh\Documents\CS295N\ESBCommunitySiteLab8A\ESBCommunitySite\Views\Contact\GetMail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77463e728e7bee42ec288150ec58a3ed6e743c3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_GetMail), @"mvc.1.0.view", @"/Views/Contact/GetMail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/GetMail.cshtml", typeof(AspNetCore.Views_Contact_GetMail))]
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
#line 1 "C:\Users\Merokemeh\Documents\CS295N\ESBCommunitySiteLab8A\ESBCommunitySite\Views\_ViewImports.cshtml"
using ESBCommunitySite;

#line default
#line hidden
#line 2 "C:\Users\Merokemeh\Documents\CS295N\ESBCommunitySiteLab8A\ESBCommunitySite\Views\_ViewImports.cshtml"
using ESBCommunitySite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77463e728e7bee42ec288150ec58a3ed6e743c3b", @"/Views/Contact/GetMail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ed60a2e532aef52573d7ccb64d093e975eeef96", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_GetMail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ESBCommunitySite.Models.MessageInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetPriorityMail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetMail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Merokemeh\Documents\CS295N\ESBCommunitySiteLab8A\ESBCommunitySite\Views\Contact\GetMail.cshtml"
  
    ViewData["Title"] = "Mailbox";

#line default
#line hidden
            BeginContext(97, 24, true);
            WriteLiteral("<! DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(121, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77463e728e7bee42ec288150ec58a3ed6e743c3b5401", async() => {
                BeginContext(127, 90, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>MailBox</title>\n    ");
                EndContext();
                BeginContext(217, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "77463e728e7bee42ec288150ec58a3ed6e743c3b5876", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(288, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(296, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(297, 1042, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77463e728e7bee42ec288150ec58a3ed6e743c3b8001", async() => {
                BeginContext(303, 430, true);
                WriteLiteral(@"
    <div class=""panel-body"">
    <h2>Mailbox</h2>
        <table class=""table table-lg table-striped table-bordered"">
            <thead>
                <tr>
                    <th>Recipient</th>
                    <th>Message Content</th>
                    <th>Message Priority</th>
                    <th>Sender</th>
                    <th>Date & Time</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 27 "C:\Users\Merokemeh\Documents\CS295N\ESBCommunitySiteLab8A\ESBCommunitySite\Views\Contact\GetMail.cshtml"
                 foreach (MessageInfo mI in Model)
                {

#line default
#line hidden
                BeginContext(802, 66, true);
                WriteLiteral("                    <tr>\n                        <td class=\"info\">");
                EndContext();
                BeginContext(869, 12, false);
#line 30 "C:\Users\Merokemeh\Documents\CS295N\ESBCommunitySiteLab8A\ESBCommunitySite\Views\Contact\GetMail.cshtml"
                                    Write(mI.Recipient);

#line default
#line hidden
                EndContext();
                BeginContext(881, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(916, 14, false);
#line 31 "C:\Users\Merokemeh\Documents\CS295N\ESBCommunitySiteLab8A\ESBCommunitySite\Views\Contact\GetMail.cshtml"
                       Write(mI.MessageText);

#line default
#line hidden
                EndContext();
                BeginContext(930, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(965, 18, false);
#line 32 "C:\Users\Merokemeh\Documents\CS295N\ESBCommunitySiteLab8A\ESBCommunitySite\Views\Contact\GetMail.cshtml"
                       Write(mI.MessagePriority);

#line default
#line hidden
                EndContext();
                BeginContext(983, 47, true);
                WriteLiteral("</td>\n                        <td class=\"info\">");
                EndContext();
                BeginContext(1031, 9, false);
#line 33 "C:\Users\Merokemeh\Documents\CS295N\ESBCommunitySiteLab8A\ESBCommunitySite\Views\Contact\GetMail.cshtml"
                                    Write(mI.Sender);

#line default
#line hidden
                EndContext();
                BeginContext(1040, 34, true);
                WriteLiteral("</td>\n                        <td>");
                EndContext();
                BeginContext(1075, 25, false);
#line 34 "C:\Users\Merokemeh\Documents\CS295N\ESBCommunitySiteLab8A\ESBCommunitySite\Views\Contact\GetMail.cshtml"
                       Write(mI.MessageDate.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1100, 32, true);
                WriteLiteral("</td>\n                    </tr>\n");
                EndContext();
#line 36 "C:\Users\Merokemeh\Documents\CS295N\ESBCommunitySiteLab8A\ESBCommunitySite\Views\Contact\GetMail.cshtml"
                }

#line default
#line hidden
                BeginContext(1150, 67, true);
                WriteLiteral("            </tbody>\n        </table>\n    </div>\n    <div>\n        ");
                EndContext();
                BeginContext(1217, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77463e728e7bee42ec288150ec58a3ed6e743c3b11708", async() => {
                    BeginContext(1249, 17, true);
                    WriteLiteral("Order By Priority");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1270, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1279, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77463e728e7bee42ec288150ec58a3ed6e743c3b13187", async() => {
                    BeginContext(1303, 13, true);
                    WriteLiteral("Order By Date");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1320, 12, true);
                WriteLiteral("\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1339, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ESBCommunitySite.Models.MessageInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
