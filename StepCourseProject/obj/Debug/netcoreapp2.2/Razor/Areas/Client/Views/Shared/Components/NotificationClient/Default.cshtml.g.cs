#pragma checksum "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34560ca746dc18971902e5d33090c0bba95bf0f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Shared_Components_NotificationClient_Default), @"mvc.1.0.view", @"/Areas/Client/Views/Shared/Components/NotificationClient/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Client/Views/Shared/Components/NotificationClient/Default.cshtml", typeof(AspNetCore.Areas_Client_Views_Shared_Components_NotificationClient_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34560ca746dc18971902e5d33090c0bba95bf0f5", @"/Areas/Client/Views/Shared/Components/NotificationClient/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"738b64eb8913d01cc083d047dd8cebf859d2aed5", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_Shared_Components_NotificationClient_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StepCourseProject.Entites.Notification>>
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
            BeginContext(118, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(178, 66, true);
            WriteLiteral("<li>\n    <a href=\"#\" title=\"\" class=\"not-box-open\">\n        <span>");
            EndContext();
            BeginContext(244, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34560ca746dc18971902e5d33090c0bba95bf0f54889", async() => {
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
            BeginContext(288, 30, true);
            WriteLiteral("</span>\n        Notification \n");
            EndContext();
#line 9 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
         if (ViewBag.Count != 0)
        {


#line default
#line hidden
            BeginContext(362, 40, true);
            WriteLiteral("        <span class=\"badge badge-light\">");
            EndContext();
            BeginContext(403, 13, false);
#line 12 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                                   Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(416, 8, true);
            WriteLiteral("</span>\n");
            EndContext();
#line 13 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(434, 229, true);
            WriteLiteral("      \n    </a>\n    <div class=\"notification-box noti\" id=\"notification\">\n        <div class=\"nt-title\">\n            <h4>Settings</h4>\n            <a href=\"#\" title=\"\">Clear all</a>\n        </div>\n        <div class=\"nott-list\">\n");
            EndContext();
#line 22 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
             if (ViewBag.Count != 0)
            {

                

#line default
#line hidden
#line 25 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                 foreach (var item in Model)
                {


#line default
#line hidden
            BeginContext(779, 106, true);
            WriteLiteral("                    <div class=\"notfication-details\">\n                        <div class=\"noty-user-img\">\n");
            EndContext();
#line 30 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                             if (item.AppUser.ImageUrl != null)
                            {


#line default
#line hidden
            BeginContext(980, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1012, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34560ca746dc18971902e5d33090c0bba95bf0f58576", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1022, "~/img/", 1022, 6, true);
#line 33 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
AddHtmlAttributeValue("", 1028, item.AppUser.ImageUrl, 1028, 22, false);

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
            BeginContext(1059, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 34 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1153, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1185, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34560ca746dc18971902e5d33090c0bba95bf0f510700", async() => {
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
            BeginContext(1241, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 38 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(1272, 140, true);
            WriteLiteral("                        </div>\n                        <div class=\"notification-info\">\n                            <h3><a href=\"#\" title=\"\">");
            EndContext();
            BeginContext(1413, 21, false);
#line 41 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                                                Write(item.AppUser.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1434, 7, true);
            WriteLiteral("</a>   ");
            EndContext();
            BeginContext(1442, 21, false);
#line 41 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                                                                             Write(item.NotificationText);

#line default
#line hidden
            EndContext();
            BeginContext(1463, 90, true);
            WriteLiteral("</h3>\n\n                        </div><!--notification-info -->\n                    </div>\n");
            EndContext();
#line 45 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1571, 134, true);
            WriteLiteral("                <div class=\"view-all-nots\">\n                    <a href=\"#\" title=\"\">View All Notification</a>\n                </div>\n");
            EndContext();
#line 49 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"

            }
            else
            {

#line default
#line hidden
            BeginContext(1751, 129, true);
            WriteLiteral("                <div class=\"view-all-nots\">\n                    <a href=\"#\" title=\"\">No notifications</a>\n                </div>\n");
            EndContext();
#line 56 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Areas\Client\Views\Shared\Components\NotificationClient\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(1894, 80, true);
            WriteLiteral("\n\n        </div><!--nott-list end-->\n    </div><!--notification-box end-->\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StepCourseProject.Entites.Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
