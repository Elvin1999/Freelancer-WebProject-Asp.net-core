#pragma checksum "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Views\Project\My.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dafca5b0e785cec25c98a82da28a20e17790748f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_My), @"mvc.1.0.view", @"/Views/Project/My.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/My.cshtml", typeof(AspNetCore.Views_Project_My))]
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
#line 1 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Views\_ViewImports.cshtml"
using StepCourseProject;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Views\_ViewImports.cshtml"
using StepCourseProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dafca5b0e785cec25c98a82da28a20e17790748f", @"/Views/Project/My.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"738b64eb8913d01cc083d047dd8cebf859d2aed5", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_My : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FreelancerOwnPostVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ClientView/images/resources/us-pic.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(161, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Views\Project\My.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
            BeginContext(198, 113, true);
            WriteLiteral("    <div class=\"post-bar\">\r\n        <div class=\"post_topbar\">\r\n            <div class=\"usy-dt\">\r\n                ");
            EndContext();
            BeginContext(311, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dafca5b0e785cec25c98a82da28a20e17790748f4358", async() => {
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
            BeginContext(370, 66, true);
            WriteLiteral("\r\n                <div class=\"usy-name\">\r\n                    <h3>");
            EndContext();
            BeginContext(437, 13, false);
#line 13 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Views\Project\My.cshtml"
                   Write(item.PostName);

#line default
#line hidden
            EndContext();
            BeginContext(450, 208, true);
            WriteLiteral("</h3>\r\n                    <span><img src=\"images/clock.png\" alt=\"\">3 min ago</span>\r\n                </div>\r\n            </div>     \r\n        </div>        \r\n        <div class=\"job_descp\">\r\n            <h3>");
            EndContext();
            BeginContext(659, 13, false);
#line 19 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Views\Project\My.cshtml"
           Write(item.PostName);

#line default
#line hidden
            EndContext();
            BeginContext(672, 67, true);
            WriteLiteral("</h3>\r\n            <ul class=\"job-dt\">\r\n                <li><span>$");
            EndContext();
            BeginContext(740, 14, false);
#line 21 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Views\Project\My.cshtml"
                      Write(item.PostPrice);

#line default
#line hidden
            EndContext();
            BeginContext(754, 48, true);
            WriteLiteral("</span></li>\r\n            </ul>\r\n            <p>");
            EndContext();
            BeginContext(803, 20, false);
#line 23 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Views\Project\My.cshtml"
          Write(item.PostDescription);

#line default
#line hidden
            EndContext();
            BeginContext(823, 119, true);
            WriteLiteral(" <a href=\"#\" title=\"\">view more</a></p>\r\n            <ul class=\"skill-tags\">\r\n                <li><a href=\"#\" title=\"\">");
            EndContext();
            BeginContext(943, 36, false);
#line 25 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Views\Project\My.cshtml"
                                    Write(item.PostDeadLine.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(979, 557, true);
            WriteLiteral(@"</a></li>

            </ul>
        </div>
        <div class=""job-status-bar"">
            <ul class=""like-com"">
                <li>
                    <a href=""#"" class=""active""><i class=""fas fa-heart""></i> Like</a>
                    <img src=""images/liked-img.png"" alt="""">
                    <span>25</span>
                </li>
                <li><a href=""#"" class=""com""><i class=""fas fa-comment-alt""></i> Bids 2</a></li>
            </ul>
            <a href=""#""><i class=""fas fa-eye""></i>Views 50</a>
        </div>
    </div>
");
            EndContext();
#line 41 "C:\Users\User\Desktop\Project1Level-master\StepCourseProject\Views\Project\My.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FreelancerOwnPostVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591