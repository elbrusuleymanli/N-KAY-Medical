#pragma checksum "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb1a6020a9566ebf615db9ad703d8576524ee7f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Details), @"mvc.1.0.view", @"/Views/Doctor/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1a6020a9566ebf615db9ad703d8576524ee7f4", @"/Views/Doctor/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80541f3555d90d4b6b271307a3813cd53b96070a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Doctor_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Doctor>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("appoint d-flex justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DocRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return alert(\'Müracət üçün qeydiyyatdan keçin\')  ;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- banner start -->\r\n<div class=\"container-fluid p-0\">\r\n    <div class=\"banner\">\r\n        <div class=\"banner-image\">\r\n            <img src=\"/assets/images/banners/doctor.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 270, "\"", 276, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"container\">\r\n                <h3>");
#nullable restore
#line 13 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
               Write(language.Getkey("HƏKİMLƏR"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>

        </div>
    </div>
</div>
<!-- banner end -->
<!-- doctor-info start -->

<div class=""information"">
    <div class=""container"">
        <div class=""doctor-info"">
            <div class=""row"">
                <div class=""col-lg-4"">
                    <div class=""doctor-image"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 719, "\"", 760, 2);
            WriteAttributeValue("", 725, "/assets/images/doctors/", 725, 23, true);
#nullable restore
#line 28 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
WriteAttributeValue("", 748, Model.Image, 748, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 761, "\"", 767, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                        <div class=\"info\">\r\n\r\n                            <strong>");
#nullable restore
#line 33 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                               Write(language.Getkey("İş günləri"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            <span>");
#nullable restore
#line 34 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                             Write(Model.WorkDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <strong>");
#nullable restore
#line 35 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                               Write(language.Getkey("Telefon"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            <span>");
#nullable restore
#line 36 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                             Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 37 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb1a6020a9566ebf615db9ad703d8576524ee7f48445", async() => {
#nullable restore
#line 39 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                                                                                                           Write(language.Getkey("HƏKİM QƏBULU"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb1a6020a9566ebf615db9ad703d8576524ee7f410425", async() => {
#nullable restore
#line 43 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                                                                                                                                                                Write(language.Getkey("HƏKİM QƏBULU"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-8\">\r\n                    <div class=\"experience\">\r\n                        <span class=\"name\">");
#nullable restore
#line 50 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                      Write(language.Getkey(Model.Fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span>");
#nullable restore
#line 51 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                         Write(language.Getkey(Model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"line\"></span>\r\n                        <h6 class=\"title\">");
#nullable restore
#line 53 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                     Write(language.Getkey("Təhsil"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <table>\r\n                            <tr>\r\n                                <th>");
#nullable restore
#line 56 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                               Write(language.Getkey("TİP"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 57 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                               Write(language.Getkey("AD"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 58 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                               Write(language.Getkey("FAKULTƏ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 59 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                               Write(language.Getkey("MÜDDƏT"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 60 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                               Write(language.Getkey("ÖLKƏ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                             foreach (var dr in Model.Educations.OrderBy(d => d.StartUniver))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n                                    <td>");
#nullable restore
#line 66 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                   Write(language.Getkey(dr.TypeOfUniver));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 67 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                   Write(language.Getkey(dr.NameOfUniver));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 68 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                   Write(language.Getkey(dr.Specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 70 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                   Write(dr.StartUniver.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 70 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                                                    Write(dr.EndUniver.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 72 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                   Write(language.Getkey(dr.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 74 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </table>\r\n                        <h6 class=\"title\">");
#nullable restore
#line 77 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                     Write(language.Getkey("İş təcrübəsi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <table>\r\n                            <tr>\r\n                                <th>");
#nullable restore
#line 80 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                               Write(language.Getkey("İŞ YERİ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 81 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                               Write(language.Getkey("BÖLÜM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 82 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                               Write(language.Getkey("İXTİSAS"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 83 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                               Write(language.Getkey("MÜDDƏT"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 84 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                               Write(language.Getkey("ÖLKƏ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            </tr>\r\n");
#nullable restore
#line 86 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                             foreach (var dr in Model.Experiences.OrderBy(d => d.StartWork))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 89 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                   Write(language.Getkey(dr.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 90 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                   Write(language.Getkey(dr.Section));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 91 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                   Write(language.Getkey(dr.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 92 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                   Write(dr.StartWork.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 92 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                                                  Write(dr.EndWork.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 93 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                                   Write(language.Getkey(dr.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 95 "C:\Users\HP\Desktop\NKAYM\NKAYM\NKAYM\Views\Doctor\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<!-- doctor-info end-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Doctor> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
