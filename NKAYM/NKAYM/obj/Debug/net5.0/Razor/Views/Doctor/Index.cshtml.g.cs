#pragma checksum "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "993c5da9aed74aac93b66dad81ccbe6cf330b212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Index), @"mvc.1.0.view", @"/Views/Doctor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"993c5da9aed74aac93b66dad81ccbe6cf330b212", @"/Views/Doctor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"901d0e8f8f89db67f2923048cda5aa5d3d54bcde", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Doctor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Doctor>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Doctor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- banner start -->\r\n<div class=\"container-fluid p-0\">\r\n    <div class=\"banner\">\r\n        <div class=\"banner-image\">\r\n            <img src=\"/assets/image/banners/doctor.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 239, "\"", 245, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""container"">
                <h3>HƏKİMLƏR</h3>
            </div>

        </div>
    </div>
</div>
<!-- banner end -->
<!-- doctors list start -->
<div class=""container"">
    <div class=""portfolio-menu"">
        <ul>
            <li class=""active"" data-filter=""*"">HAMISI</li>
            <li data-filter="".ginekologiya"">GİNEKOLOGİYA</li>
            <li data-filter="".lor"">LOR</li>
            <li data-filter="".stomatologiya"">STOMATOLOGİYA</li>
            <li data-filter="".laboratoriya"">LABORATORİYA</li>
            <li data-filter="".cərrahiyyə"">CƏRRAHİYYƏ</li>
            <li data-filter="".kardiologiya"">KARDİOLOGİYA</li>
            <li data-filter="".fizioterapiya"">FİZİOTERAPİYA</li>
            <li data-filter="".pediatriya"">PEDİATRİYA</li>
            <li data-filter="".usm"">USM</li>
        </ul>
    </div>
</div>
<div class=""container"">
    <div class=""doctor-item"">
        <div class=""row"">
");
#nullable restore
#line 39 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Index.cshtml"
             foreach (var doctor in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\" col-lg-3 col-md-6 col-sm-12 item cərrahiyyə\">\r\n                <div class=\"person \">\r\n\r\n                    <div class=\"main-image\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "993c5da9aed74aac93b66dad81ccbe6cf330b2125776", async() => {
                WriteLiteral("\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 1557, "\"", 1598, 2);
                WriteAttributeValue("", 1563, "/assets/image/doctors/", 1563, 22, true);
#nullable restore
#line 46 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 1585, doctor.Image, 1585, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1599, "\"", 1605, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <span>\r\n                                <div class=\"name\">\r\n                                    <h5>");
#nullable restore
#line 49 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Index.cshtml"
                                   Write(doctor.Fullname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n                                    <h6>");
#nullable restore
#line 51 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Index.cshtml"
                                   Write(doctor.Position);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                </div>\r\n\r\n                            </span>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Index.cshtml"
                                                                          WriteLiteral(doctor.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 59 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- doctors list end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Doctor>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
