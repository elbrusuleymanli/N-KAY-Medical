#pragma checksum "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\News\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42d4763d93cbe1d864919a75cf9d1705fa7e8580"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Details), @"mvc.1.0.view", @"/Views/News/Details.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\_ViewImports.cshtml"
using NKAYM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\_ViewImports.cshtml"
using NKAYM.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\_ViewImports.cshtml"
using NKAYM.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42d4763d93cbe1d864919a75cf9d1705fa7e8580", @"/Views/News/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"901d0e8f8f89db67f2923048cda5aa5d3d54bcde", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_News_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsWall>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/image/banners/news-banner.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\News\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- banner start -->\r\n<div class=\"container-fluid p-0\">\r\n    <div class=\"banner\">\r\n        <div class=\"banner-image\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "42d4763d93cbe1d864919a75cf9d1705fa7e85804298", async() => {
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
            WriteLiteral("\r\n            <div class=\"container\">\r\n                <h3>XƏBƏRLƏR</h3>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<!-- banner end -->\r\n<!-- news detail start -->\r\n<div class=\"container\">\r\n    <div class=\"news-detail\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "42d4763d93cbe1d864919a75cf9d1705fa7e85805691", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 510, "~/assets/image/", 510, 15, true);
#nullable restore
#line 24 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\News\Details.cshtml"
AddHtmlAttributeValue("", 525, Model.Image, 525, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"news-text\">\r\n            <article>\r\n                <h2>");
#nullable restore
#line 27 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\News\Details.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <span class=\"news-date\">");
#nullable restore
#line 28 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\News\Details.cshtml"
                                   Write(Model.ReleaseDate.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\News\Details.cshtml"
                                                                     Write(Model.ReleaseDate.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\News\Details.cshtml"
                                                                                                         Write(Model.ReleaseDate.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <p>\r\n                  ");
#nullable restore
#line 30 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\News\Details.cshtml"
             Write(Model.Descr1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    ");
#nullable restore
#line 33 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\News\Details.cshtml"
               Write(Model.Descr2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                   ");
#nullable restore
#line 36 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\News\Details.cshtml"
              Write(Model.Descr3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </article>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n<!-- news detail end -->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWall> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
