#pragma checksum "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Manager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9a62b65c09ec83f0ef4855001b11a8c04bcec8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Index), @"mvc.1.0.view", @"/Views/Manager/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9a62b65c09ec83f0ef4855001b11a8c04bcec8a", @"/Views/Manager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"901d0e8f8f89db67f2923048cda5aa5d3d54bcde", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Manager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Manager>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Manager\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- banner start -->\r\n<div class=\"container-fluid p-0\">\r\n    <div class=\"banner\">\r\n        <div class=\"banner-image\">\r\n            <img src=\"/assets/image/banners/manager.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 241, "\"", 247, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""container"">
                <h3>RƏHBƏRLİK</h3>
            </div>

        </div>
    </div>
</div>
<!-- banner end -->
<!-- manager start -->

<div class=""managers"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 24 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Manager\Index.cshtml"
             foreach (var manager in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-6 col-sm-12 mb-2\" data-aos=\"zoom-in\">\r\n                <div class=\"manager\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 702, "\"", 744, 2);
            WriteAttributeValue("", 708, "/assets/image/banners/", 708, 22, true);
#nullable restore
#line 28 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Manager\Index.cshtml"
WriteAttributeValue("", 730, manager.Image, 730, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 745, "\"", 751, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <ul class=\"manager-info\">\r\n                        <li>");
#nullable restore
#line 30 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Manager\Index.cshtml"
                       Write(manager.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 31 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Manager\Index.cshtml"
                       Write(manager.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 32 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Manager\Index.cshtml"
                       Write(manager.Post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                    </ul>\r\n\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 39 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Manager\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<!-- manager end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Manager>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
