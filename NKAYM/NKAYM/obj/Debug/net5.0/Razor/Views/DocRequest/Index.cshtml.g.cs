#pragma checksum "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\DocRequest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34417ae3eab53f64179bd6f36314768e19a80634"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocRequest_Index), @"mvc.1.0.view", @"/Views/DocRequest/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34417ae3eab53f64179bd6f36314768e19a80634", @"/Views/DocRequest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"901d0e8f8f89db67f2923048cda5aa5d3d54bcde", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DocRequest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DocRequest>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\DocRequest\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"docRequest\">\r\n\r\n    <div class=\"topic\">\r\n        <h1>HƏKİM QƏBULU</h1>\r\n\r\n        <p>ONLİNE QEYDİYYAT</p>\r\n    </div>\r\n    <div class=\"request-form\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34417ae3eab53f64179bd6f36314768e19a806344537", async() => {
                WriteLiteral("\r\n            <label for=\"fname\">Ad Soyad,Ata adı: </label>\r\n            <input type=\"text\" id=\"fname\" name=\"fname\"");
                BeginWriteAttribute("value", " value=\"", 376, "\"", 384, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"fullname\" required>\r\n            <label for=\"gender\">Cins: </label>\r\n            <select name=\"gender\" id=\"gender\" value=\"none\" class=\"gender\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34417ae3eab53f64179bd6f36314768e19a806345257", async() => {
                    WriteLiteral("KİŞİ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34417ae3eab53f64179bd6f36314768e19a806346494", async() => {
                    WriteLiteral("QADIN");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </select>\r\n            <label for=\"bday\">Doğum günü: </label>\r\n            <input type=\"date\" id=\"bday\" name=\"bday\"");
                BeginWriteAttribute("value", " value=\"", 762, "\"", 770, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"birhtday\">\r\n            <label for=\"addr\">Ünvan: </label>\r\n            <input type=\"text\" id=\"addr\" name=\"addr\"");
                BeginWriteAttribute("value", " value=\"", 890, "\"", 898, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"address\"><br />\r\n            <label for=\"contact\">Əlaqə nömrəsi: </label>\r\n            <input type=\"text\" id=\"contact\" name=\"contact\"");
                BeginWriteAttribute("value", " value=\"", 1040, "\"", 1048, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"phone\" placeholder=\"(+994--) --- -- --\"><br />\r\n            <label for=\"reques\">Şikayət(qısa izah): </label>\r\n            <textarea style=\"width:450px;margin-top:40px;padding-left:5px\" type=\"text\" id=\"reques\" name=\"reques\"");
                BeginWriteAttribute("value", " value=\"", 1279, "\"", 1287, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"aboutSick\"></textarea> <br />\r\n            <label for=\"unit\">Bölmə: </label>\r\n            <input type=\"text\" id=\"unit\" name=\"unit\"");
                BeginWriteAttribute("value", " value=\"", 1426, "\"", 1434, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"unit\" placeholder=\"Məs: USM\">\r\n            <label for=\"doc\">Həkim: </label>\r\n            <input type=\"text\" id=\"doc\" name=\"doc\"");
                BeginWriteAttribute("value", " value=\"", 1570, "\"", 1578, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"doctorsFullname\" placeholder=\"Məs: Dr.Mütəllimov\">\r\n            <label for=\"day\">Müayinə günü: </label>\r\n            <input type=\"date\" id=\"day\" name=\"day\" class=\"requestDay\"");
                BeginWriteAttribute("value", " value=\"", 1761, "\"", 1769, 0);
                EndWriteAttribute();
                WriteLiteral("><br /><br />\r\n            <label for=\"time\">Müayinə saatı: </label>\r\n            <input type=\"time\" id=\"time\" name=\"time\" class=\"requestTime\"");
                BeginWriteAttribute("value", " value=\"", 1912, "\"", 1920, 0);
                EndWriteAttribute();
                WriteLiteral("><br /><br />\r\n\r\n\r\n\r\n            <button class=\"btn btn-primary mt-4\" type=\"submit\" data-text=\"send\" id=\"reply\">Müraciət et </button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DocRequest>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
