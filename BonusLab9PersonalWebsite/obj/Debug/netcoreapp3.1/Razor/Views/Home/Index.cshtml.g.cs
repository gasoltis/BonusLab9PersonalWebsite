#pragma checksum "C:\Users\Gsoltis\source\repos\BonusLab9PersonalWebsite\BonusLab9PersonalWebsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "096eb09ac20c46e89c408cfd5749bd50ddf620bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Gsoltis\source\repos\BonusLab9PersonalWebsite\BonusLab9PersonalWebsite\Views\_ViewImports.cshtml"
using BonusLab9PersonalWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gsoltis\source\repos\BonusLab9PersonalWebsite\BonusLab9PersonalWebsite\Views\_ViewImports.cshtml"
using BonusLab9PersonalWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"096eb09ac20c46e89c408cfd5749bd50ddf620bc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e09efc8f2e4334445a10b343d110fef43d28bbf4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/IndexStyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Gsoltis\source\repos\BonusLab9PersonalWebsite\BonusLab9PersonalWebsite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- link to CSS file, so DOM knows where to look-->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "096eb09ac20c46e89c408cfd5749bd50ddf620bc4471", async() => {
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
            WriteLiteral("\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "096eb09ac20c46e89c408cfd5749bd50ddf620bc5599", async() => {
                WriteLiteral("\r\n    <title>Page Title</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "096eb09ac20c46e89c408cfd5749bd50ddf620bc6598", async() => {
                WriteLiteral(@"
    <style>
        body {
            background-color: #93B874;
        }

        p {
            background-color: #93B874;
        }
    </style>


    <div id=""maindiv"">
        <p>
            <h1 style=""color:darkslateblue"">Blogger</h1>
            <h5 style=""color:darkslateblue""> <i>Start before you're ready. — Steven Pressfield </i></h5>
            A dead man. The subject of the very first article I was assigned as a new reporter.
            When I say 'new' I mean I didn't have a degree in journalism; I was not trained in journalism; I had never written an article
            for a newspaper before and just to clarify - I did not have experience in the mortuary sciences.
        </p>

        <p>
            I am a developer. Once I was a reporter. This is the reporter story. I moved to a small town in northern Michigan to try a new adventure with no job
            nor prospects, my first day to town I went to
            the local grocery store to pick up a few provisio");
                WriteLiteral(@"ns. The cashier, Russ, noticed the out of town address on my check
            (yes -- a bank check!) and asked what brought me to town. (Russ worked mostly the early
            morning shift stocking shelves at the grocery and as a local pastor in a modest single-story, vinyl-sided, house-turned-church with
            a dirt parking lot on the main thoroughfare out of town.) I told him I was not here on vacation (this was a gritty little tourist town
            back then), but hastily summed up my quest for sunrises, sunsets, nature and what was for sure to be
            the grandest adventure of my life as ""I just moved to town today."" He asked where I was working. ""I am looking.""
            Without so much as a pause, Russ directed me to the local newspaper where the editor was looking for a reporter - my three word
            resume of ""I am looking,"" evidently indicating experience and aptitude for newspaper work.
        </p>

        <p>
            I interviewed with the editor two da");
                WriteLiteral(@"ys later and began working the following week. Here is the article I wrote about a dead man:
            <i>Link to a soon to be active website.</i>
        </p>
    </div>

    <div>
        <p>
            >
            <h2 style=""color:darkslateblue"">Developer</h2>
            <h5 style=""color:darkslateblue"">
                <i>
                    “If you can write ""hello world"" you can change the world.”
                    ― Raghu Venkatesh
                </i>
            </h5>
        </p>

        <p>
            I am a C#/.NET Software Developer. Much like my foray into journalism, so wended the path that took me into development.
            In short, I declared a 'career bankruptcy' leaving the world of corporate events management in the rearview mirror to write code.
        </p>
    </div>

    <div>
        <p>
            <a href=""https://www.romi.gov/"">
                <h2 style=""color:darkslateblue"">Hometown</h2>
            </a>
            <h5 style=""color:darks");
                WriteLiteral(@"lateblue"">
                <i>
                    “Home is where my habits have a habitat” ― Fiona Apple
                </i>
            </h5>
        </p>
        
        <p>
            <ul>
                <li>Royal Oak</li>
                <li>Michigan</li>
                <li>USA</li>
            </ul>
        </p>
    </div>

");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
