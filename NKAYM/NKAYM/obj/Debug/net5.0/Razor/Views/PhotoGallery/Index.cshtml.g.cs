#pragma checksum "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\PhotoGallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd17af9406852d209c1b52f3410be13a774a4add"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhotoGallery_Index), @"mvc.1.0.view", @"/Views/PhotoGallery/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd17af9406852d209c1b52f3410be13a774a4add", @"/Views/PhotoGallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"901d0e8f8f89db67f2923048cda5aa5d3d54bcde", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PhotoGallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PhotoGallery>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\PhotoGallery\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- banner start -->\r\n<div class=\"container-fluid p-0\">\r\n    <div class=\"banner\">\r\n        <div class=\"banner-image\">\r\n            <img src=\"/assets/images/banners/gallery.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 281, "\"", 287, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"container\">\r\n                <h3>");
#nullable restore
#line 13 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\PhotoGallery\Index.cshtml"
               Write(language.Getkey("ŞƏKİLLƏR"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- banner end -->\r\n<div class=\"container  gallery-container\">\r\n    <div class=\"title\">\r\n        <h2>");
#nullable restore
#line 22 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\PhotoGallery\Index.cshtml"
       Write(language.Getkey("ŞƏKİLLƏR QALEREYASI"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"tz-gallery\">\r\n\r\n        <div class=\"row \" data-aos=\"fade-up\">\r\n");
#nullable restore
#line 27 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\PhotoGallery\Index.cshtml"
             foreach (var photo in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3\">\r\n                    <a class=\"lightbox\"");
            BeginWriteAttribute("href", " href=\"", 817, "\"", 851, 2);
            WriteAttributeValue("", 824, "/assets/images/", 824, 15, true);
#nullable restore
#line 30 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\PhotoGallery\Index.cshtml"
WriteAttributeValue("", 839, photo.Image, 839, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 883, "\"", 916, 2);
            WriteAttributeValue("", 889, "/assets/images/", 889, 15, true);
#nullable restore
#line 31 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\PhotoGallery\Index.cshtml"
WriteAttributeValue("", 904, photo.Image, 904, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"şəkil\">\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\PhotoGallery\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LanguageService language { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PhotoGallery>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
