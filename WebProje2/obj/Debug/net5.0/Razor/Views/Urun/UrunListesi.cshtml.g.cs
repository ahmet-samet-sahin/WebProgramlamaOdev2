#pragma checksum "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\UrunListesi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f975f2a133329becfa2a36789eab490aab549646"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Urun_UrunListesi), @"mvc.1.0.view", @"/Views/Urun/UrunListesi.cshtml")]
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
#line 1 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\UrunListesi.cshtml"
using WebProje2.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f975f2a133329becfa2a36789eab490aab549646", @"/Views/Urun/UrunListesi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfcda52b9d8b9a8ea934f78be13e53636c84d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Urun_UrunListesi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Urun>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\UrunListesi.cshtml"
  

    Layout = null;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<!DOCTYPE html>\r\n\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f975f2a133329becfa2a36789eab490aab5496463753", async() => {
                WriteLiteral(@"

    <meta charset=""UTF-8"">

    <title>PDF Dönüşüm İşlemleri</title>

    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.1/css/bootstrap.css"">

    <link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.19/css/dataTables.bootstrap4.min.css"">

    <link rel=""stylesheet"" href=""https://cdn.datatables.net/buttons/1.5.2/css/buttons.bootstrap4.min.css"">

    <link rel=""stylesheet"" href=""https://cdn.datatables.net/responsive/2.2.3/css/responsive.bootstrap4.min.css"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f975f2a133329becfa2a36789eab490aab5496465268", async() => {
                WriteLiteral(@"

    <table id=""example"" class=""table table-striped table-bordered dt-responsive nowrap"" style=""width:100%"">

        <thead>

            <tr>

                <th>Adı</th>

                <th>Marka</th>

                <th>Stok</th>

                <th>Alış Fiyat</th>

                <th>Satış Fiyat</th>

                <th>Kategori</th>

            </tr>

        </thead>

        <tbody>

");
#nullable restore
#line 59 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\UrunListesi.cshtml"
             foreach (var x in Model)

            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 65 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\UrunListesi.cshtml"
                   Write(x.UrunAd);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 67 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\UrunListesi.cshtml"
                   Write(x.Marka);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 69 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\UrunListesi.cshtml"
                   Write(x.Stok);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 71 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\UrunListesi.cshtml"
                   Write(x.AlisFiyat);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 73 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\UrunListesi.cshtml"
                   Write(x.SatisFiyat);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 75 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\UrunListesi.cshtml"
                   Write(x.Kategori.KategoriAd);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 78 "D:\Ders Notları\Deneme\WebProgramlamaOdev\WebProje2\Views\Urun\UrunListesi.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


        </tbody>

    </table>

    <script src=""https://code.jquery.com/jquery-3.3.1.js""></script>

    <script src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>

    <script src=""https://cdn.datatables.net/1.10.19/js/dataTables.bootstrap4.min.js""></script>

    <script src=""https://cdn.datatables.net/buttons/1.5.2/js/dataTables.buttons.min.js""></script>

    <script src=""https://cdn.datatables.net/buttons/1.5.2/js/buttons.bootstrap4.min.js""></script>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js""></script>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.36/pdfmake.min.js""></script>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.36/vfs_fonts.js""></script>

    <script src=""https://cdn.datatables.net/buttons/1.5.2/js/buttons.html5.min.js""></script>

    <script src=""https://cdn.datatables.net/buttons/1.5.2/js/buttons.print.min.js""></script>

    <script src=""https://cdn.dat");
                WriteLiteral(@"atables.net/buttons/1.5.2/js/buttons.colVis.min.js""></script>

    <script src=""https://cdn.datatables.net/responsive/2.2.3/js/dataTables.responsive.min.js""></script>

    <script src=""https://cdn.datatables.net/responsive/2.2.3/js/responsive.bootstrap4.min.js""></script>

    <script>

$(document).ready(function() {

    var table = $('#example').DataTable( {

        lengthChange: false,

        buttons: [ 'copy', 'excel', 'csv', 'pdf', 'colvis' ]

    } );



    table.buttons().container()

        .appendTo( '#example_wrapper .col-md-6:eq(0)' );

} );

    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Urun>> Html { get; private set; }
    }
}
#pragma warning restore 1591
