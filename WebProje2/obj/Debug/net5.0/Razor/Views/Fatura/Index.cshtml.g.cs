#pragma checksum "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "779fe4990685607a95c650007d4780e9ffbb216c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fatura_Index), @"mvc.1.0.view", @"/Views/Fatura/Index.cshtml")]
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
#line 1 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
using WebProje2.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"779fe4990685607a95c650007d4780e9ffbb216c", @"/Views/Fatura/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfcda52b9d8b9a8ea934f78be13e53636c84d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Fatura_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Faturalar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<h2>Faturalar</h2>
<br />
<table class=""table table-bordered"" style=""margin-top:20px"">
    <tr>
        <th>Fatura Seri-Sıra No</th>
        <th>Vergi Dairesi</th>
        <th>Fatura Tarihi</th>
        <th>İşlem Saati</th>
        <th>Teslim Eden</th>
        <th>Teslim Alan</th>
        <th>Toplam Tutar</th>
        <th>Güncelle</th>
        <th>Detaylar</th>
    </tr>
");
#nullable restore
#line 24 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
     foreach (var k in Model)
    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
           Write(k.FaturaSeriNo);

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
                          Write(k.FaturaSiraNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
           Write(k.VergiDairesi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
           Write(Convert.ToDateTime(k.Tarih).ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
           Write(k.Saat);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
           Write(k.TeslimEden);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
           Write(k.TeslimAlan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
           Write(k.ToplamTutar);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1148, "\"", 1189, 2);
            WriteAttributeValue("", 1155, "/Fatura/FaturaGetir/", 1155, 20, true);
#nullable restore
#line 48 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
WriteAttributeValue("", 1175, k.Faturalarid, 1175, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1252, "\"", 1293, 2);
            WriteAttributeValue("", 1259, "/Fatura/FaturaDetay/", 1259, 20, true);
#nullable restore
#line 49 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
WriteAttributeValue("", 1279, k.Faturalarid, 1279, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Fatura\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Fatura/FaturaEkle\" class=\"btn btn-info\">Yeni Fatura Ekle</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Faturalar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
