#pragma checksum "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Kargo\KargoDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97520b5358073a5e3e9ac6724053f1467758349b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kargo_KargoDetay), @"mvc.1.0.view", @"/Views/Kargo/KargoDetay.cshtml")]
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
#nullable restore
#line 1 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Kargo\KargoDetay.cshtml"
using WebProje2.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97520b5358073a5e3e9ac6724053f1467758349b", @"/Views/Kargo/KargoDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfcda52b9d8b9a8ea934f78be13e53636c84d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Kargo_KargoDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<KargoDetay>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Kargo\KargoDetay.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2 style=\"color:darkred\">Kargo Detayları</h2>\r\n<br />\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Açıklama</th>\r\n        <th>Tarih</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 19 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Kargo\KargoDetay.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Kargo\KargoDetay.cshtml"
           Write(x.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Kargo\KargoDetay.cshtml"
           Write(x.Tarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Kargo\KargoDetay.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<KargoDetay>> Html { get; private set; }
    }
}
#pragma warning restore 1591
