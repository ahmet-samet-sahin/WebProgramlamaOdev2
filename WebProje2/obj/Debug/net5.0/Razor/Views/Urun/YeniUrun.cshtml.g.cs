#pragma checksum "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52870f86f17a3ecff91cefcc3086e70078ad8413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Urun_YeniUrun), @"mvc.1.0.view", @"/Views/Urun/YeniUrun.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52870f86f17a3ecff91cefcc3086e70078ad8413", @"/Views/Urun/YeniUrun.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfcda52b9d8b9a8ea934f78be13e53636c84d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Urun_YeniUrun : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProje2.Models.Siniflar.Urun>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
  
    ViewBag.Title = "YeniUrun";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2>Yeni Ürün Ekleme İşlemleri</h2>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52870f86f17a3ecff91cefcc3086e70078ad84134227", async() => {
                WriteLiteral("\r\n    <p>Ürün Adı</p>\r\n    ");
#nullable restore
#line 13 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
Write(Html.TextBoxFor(x => x.UrunAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 14 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
Write(Html.ValidationMessageFor(x => x.UrunAd, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <br />\r\n    <p>Ürün Markası</p>\r\n    ");
#nullable restore
#line 18 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
Write(Html.TextBoxFor(x => x.Marka, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 19 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
Write(Html.ValidationMessageFor(x => x.Marka, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <br />\r\n    <p>Ürün Stok Sayısı</p>\r\n    ");
#nullable restore
#line 23 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
Write(Html.TextBoxFor(x => x.Stok, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 24 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
Write(Html.ValidationMessageFor(x => x.Stok, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <br />\r\n    <p>Alış Fiyatı</p>\r\n    ");
#nullable restore
#line 28 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
Write(Html.TextBoxFor(x => x.AlisFiyat, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 29 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
Write(Html.ValidationMessageFor(x => x.AlisFiyat, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <br />\r\n    <p>Satış Fiyatı</p>\r\n    ");
#nullable restore
#line 33 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
Write(Html.TextBoxFor(x => x.SatisFiyat, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 34 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
Write(Html.ValidationMessageFor(x => x.SatisFiyat, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <br />\r\n    <p>Kategori</p>\r\n    ");
#nullable restore
#line 38 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
Write(Html.DropDownListFor(x => x.Kategoriid, (List<SelectListItem>)ViewBag.ktg1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("    <br />\r\n    <p>Ürün Görseli</p>\r\n    ");
#nullable restore
#line 42 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\YeniUrun.cshtml"
Write(Html.TextBoxFor(x => x.UrunGorsel, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <button class=\"btn btn-primary\">Ürünü Kaydet</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProje2.Models.Siniflar.Urun> Html { get; private set; }
    }
}
#pragma warning restore 1591
