#pragma checksum "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Login\KayitOl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "255fb35ade505d416fb049aef5f6de4af7f1df04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_KayitOl), @"mvc.1.0.view", @"/Views/Login/KayitOl.cshtml")]
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
#line 1 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\_ViewImports.cshtml"
using WebProje2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\_ViewImports.cshtml"
using WebProje2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"255fb35ade505d416fb049aef5f6de4af7f1df04", @"/Views/Login/KayitOl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfcda52b9d8b9a8ea934f78be13e53636c84d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_KayitOl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 0.25rem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Login\KayitOl.cshtml"
  
    ViewData["Title"] = "KayitOl";
    Layout = "~/Views/Shared/SeceneklerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"login-form login-form-left\">\r\n    <div class=\"agile-row\"");
            BeginWriteAttribute("style", " style=\"", 171, "\"", 179, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <br />\r\n        <br />\r\n        <h3 style=\"color: white; margin-top: 0rem; margin-left:8rem; text-align: center; display:flex; justify-content: center\">Cari Kayıt Formu</h3>\r\n        <div class=\"login-agileits-top\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "255fb35ade505d416fb049aef5f6de4af7f1df044631", async() => {
                WriteLiteral("\r\n                <input type=\"text\" class=\"name\" name=\"CariAd\" Placeholder=\"Adınız\"");
                BeginWriteAttribute("required", " required=\"", 553, "\"", 564, 0);
                EndWriteAttribute();
                BeginWriteAttribute("style", " style=\"", 565, "\"", 573, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"text\" class=\"name\" name=\"CariSoyad\" Placeholder=\"Soyadınız\"");
                BeginWriteAttribute("required", " required=\"", 667, "\"", 678, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"text\" class=\"name\" name=\"CariSehir\" Placeholder=\"Şehir\"");
                BeginWriteAttribute("required", " required=\"", 768, "\"", 779, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"email\" class=\"name\" name=\"CariMail\" Placeholder=\"Mail Adresiniz\"");
                BeginWriteAttribute("required", " required=\"", 878, "\"", 889, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"password\" class=\"password\" name=\"Sifre\" Placeholder=\"Şifre\"");
                BeginWriteAttribute("required", " required=\"", 983, "\"", 994, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <div class=\"login-check\">\r\n                    <label class=\"checkbox\" style=\"color:white\"><input type=\"checkbox\" name=\"checkbox\"");
                BeginWriteAttribute("checked", " checked=\"", 1145, "\"", 1155, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i> </i> Kuralları Okudum <a href=""#"" style=""color:white"">&amp; Kabul Ediyorum.</a></label>
                </div>
                <input type=""submit"" value=""Geri Dön"" style=""margin-bottom:10px"" onclick=""window.location.href = '/Login';"">
                <input type=""submit"" value=""Kayıt Ol"">
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
