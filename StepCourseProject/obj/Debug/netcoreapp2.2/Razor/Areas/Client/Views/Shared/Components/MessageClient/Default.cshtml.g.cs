#pragma checksum "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74e2de7673db5821c770ef78bbb09a042ba1eedb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Shared_Components_MessageClient_Default), @"mvc.1.0.view", @"/Areas/Client/Views/Shared/Components/MessageClient/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Client/Views/Shared/Components/MessageClient/Default.cshtml", typeof(AspNetCore.Areas_Client_Views_Shared_Components_MessageClient_Default))]
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
#line 1 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\_ViewImports.cshtml"
using StepCourseProject;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\_ViewImports.cshtml"
using StepCourseProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74e2de7673db5821c770ef78bbb09a042ba1eedb", @"/Areas/Client/Views/Shared/Components/MessageClient/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"738b64eb8913d01cc083d047dd8cebf859d2aed5", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_Shared_Components_MessageClient_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StepCourseProject.Entites.Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Client/images/icon7.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Client/images/resources/ny-img1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(175, 74, true);
            WriteLiteral("\r\n\r\n\r\n<li>\r\n    <a href=\"#\" title=\"\" class=\"not-box-open\">\r\n        <span>");
            EndContext();
            BeginContext(249, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "74e2de7673db5821c770ef78bbb09a042ba1eedb4764", async() => {
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
            BeginContext(293, 27, true);
            WriteLiteral("</span>\r\n        Messages\r\n");
            EndContext();
#line 11 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
         if (ViewBag.Count != 0)
        {


#line default
#line hidden
            BeginContext(367, 44, true);
            WriteLiteral("            <span class=\"badge badge-light\">");
            EndContext();
            BeginContext(412, 13, false);
#line 14 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
                                       Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(425, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 15 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(445, 229, true);
            WriteLiteral("    </a>\r\n    <div class=\"notification-box noti\" id=\"notification\">\r\n        <div class=\"nt-title\">\r\n            <h4>Settings</h4>\r\n            <a href=\"#\" title=\"\">Clear all</a>\r\n        </div>\r\n        <div class=\"nott-list\">\r\n");
            EndContext();
#line 23 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
             if (ViewBag.Count != 0)
            {

                

#line default
#line hidden
#line 26 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(794, 108, true);
            WriteLiteral("                    <div class=\"notfication-details\">\r\n                        <div class=\"noty-user-img\">\r\n");
            EndContext();
#line 30 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
                             if (item.SenderUser.ImageUrl != null)
                            {


#line default
#line hidden
            BeginContext(1003, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1035, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "74e2de7673db5821c770ef78bbb09a042ba1eedb8456", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1045, "~/img/", 1045, 6, true);
#line 33 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
AddHtmlAttributeValue("", 1051, item.SenderUser.ImageUrl, 1051, 25, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1085, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1183, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1215, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "74e2de7673db5821c770ef78bbb09a042ba1eedb10578", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1271, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(1304, 142, true);
            WriteLiteral("                        </div>\r\n                        <div class=\"notification-info\">\r\n                            <h3><a href=\"#\" title=\"\">");
            EndContext();
            BeginContext(1447, 24, false);
#line 41 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
                                                Write(item.SenderUser.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1471, 7, true);
            WriteLiteral("</a>   ");
            EndContext();
            BeginContext(1479, 16, false);
#line 41 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
                                                                                Write(item.MessageText);

#line default
#line hidden
            EndContext();
            BeginContext(1495, 104, true);
            WriteLiteral("</h3>\r\n                        <span> \r\n                            <br />\r\n                            ");
            EndContext();
            BeginContext(1600, 35, false);
#line 44 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
                       Write(item.MessageDate.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1635, 95, true);
            WriteLiteral(" </span>\r\n                        </div><!--notification-info -->\r\n                    </div>\r\n");
            EndContext();
#line 47 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1749, 133, true);
            WriteLiteral("                <div class=\"view-all-nots\">\r\n                    <a href=\"#\" title=\"\">View All Messages</a>\r\n                </div>\r\n");
            EndContext();
#line 51 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"

            }
            else
            {

#line default
#line hidden
            BeginContext(1932, 127, true);
            WriteLiteral("                <div class=\"view-all-nots\">\r\n                    <a href=\"#\" title=\"\">No messages</a>\r\n                </div>\r\n");
            EndContext();
#line 58 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\MessageClient\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(2074, 84, true);
            WriteLiteral("\r\n\r\n        </div><!--nott-list end-->\r\n    </div><!--notification-box end-->\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StepCourseProject.Entites.Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
