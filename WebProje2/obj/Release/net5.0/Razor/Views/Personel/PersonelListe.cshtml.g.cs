#pragma checksum "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Personel\PersonelListe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81a0158b2d50d75ef20d02488a4e49f975402949"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_PersonelListe), @"mvc.1.0.view", @"/Views/Personel/PersonelListe.cshtml")]
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
#line 1 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\_ViewImports.cshtml"
using WebProje2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\_ViewImports.cshtml"
using WebProje2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Personel\PersonelListe.cshtml"
using WebProje2.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81a0158b2d50d75ef20d02488a4e49f975402949", @"/Views/Personel/PersonelListe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfcda52b9d8b9a8ea934f78be13e53636c84d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Personel_PersonelListe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE-3.0.4/plugins/fontawesome-free/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminLTE-3.0.4/dist/css/adminlte.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Personel\PersonelListe.cshtml"
  
    ViewData["Title"] = "PersonelListe";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81a0158b2d50d75ef20d02488a4e49f9754029495365", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>AdminLTE 3 | Contacts</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!-- Font Awesome -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "81a0158b2d50d75ef20d02488a4e49f9754029495932", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- Ionicons -->\r\n    <link rel=\"stylesheet\" href=\"https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css\">\r\n    <!-- overlayScrollbars -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "81a0158b2d50d75ef20d02488a4e49f9754029497280", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <!-- Google Font: Source Sans Pro -->\r\n    <link href=\"https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700\" rel=\"stylesheet\">\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81a0158b2d50d75ef20d02488a4e49f9754029499323", async() => {
                WriteLiteral(@"
    <!-- Site wrapper -->
    <div class=""wrapper"">
        <!-- Navbar -->
        <!-- /.navbar -->
        <!-- Main Sidebar Container -->
        <!-- Content Wrapper. Contains page content -->
        <!-- Content Header (Page header) -->
        <section class=""content-header"">
            <div class=""container-fluid"">
                <div class=""row mb-2"">
                    <div class=""col-sm-6"">
                        <h1>Personel Listesi</h1>
                    </div>
                </div>
            </div><!-- /.container-fluid -->
        </section>

        <!-- Main content -->
        <section class=""content"">

            <!-- Default box -->
            <div class=""card card-solid"">
                <div class=""card-body pb-0"">
                    <div class=""row d-flex align-items-stretch"">
");
#nullable restore
#line 51 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Personel\PersonelListe.cshtml"
                         foreach (var x in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""col-12 col-sm-6 col-md-4 d-flex align-items-stretch"">
                                <div class=""card bg-light"">
                                    <div class=""card-header text-muted border-bottom-0"">
                                        ");
#nullable restore
#line 56 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Personel\PersonelListe.cshtml"
                                   Write(x.Departman.DepartmanAd);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </div>
                                    <div class=""card-body pt-0""> 
                                        <div class=""row"">
                                            <div class=""col-7"">
                                                <h2 class=""lead""><b>");
#nullable restore
#line 61 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Personel\PersonelListe.cshtml"
                                                               Write(x.PersonelAd);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 61 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Personel\PersonelListe.cshtml"
                                                                             Write(x.PersonelSoyad);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b></h2>
                                                <p class=""text-muted text-sm""><b>About: </b> Web Designer / UX / Graphic Artist / Coffee Lover </p>
                                                <ul class=""ml-4 mb-0 fa-ul text-muted"">
                                                    <li class=""small""><span class=""fa-li""><i class=""fas fa-lg fa-building""></i></span> Address: Demo Street 123, Demo City 04312, NJ</li>
                                                    <li class=""small""><span class=""fa-li""><i class=""fas fa-lg fa-phone""></i></span> Phone #: + 800 - 12 12 23 52</li>
                                                </ul>
                                            </div>
                                            <div class=""col-5 text-center"">
                                                <img");
                BeginWriteAttribute("src", " src=\"", 3436, "\"", 3459, 1);
#nullable restore
#line 69 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Personel\PersonelListe.cshtml"
WriteAttributeValue("", 3442, x.PersonelGorsel, 3442, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3460, "\"", 3466, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-circle img-fluid"">
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""card-footer"">
                                        <div class=""text-right"">
                                            <a");
                BeginWriteAttribute("href", " href=\"", 3818, "\"", 3862, 2);
                WriteAttributeValue("", 3825, "/Personel/PersonelGetir/", 3825, 24, true);
#nullable restore
#line 75 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Personel\PersonelListe.cshtml"
WriteAttributeValue("", 3849, x.PersonelID, 3849, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm bg-teal\">\r\n                                                <i class=\"fas fa-edit\"></i>\r\n                                            </a>\r\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 4066, "\"", 4120, 2);
                WriteAttributeValue("", 4073, "/Departman/DepartmanPersonelSatis/", 4073, 34, true);
#nullable restore
#line 78 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Personel\PersonelListe.cshtml"
WriteAttributeValue("", 4107, x.PersonelID, 4107, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-sm btn-primary"">
                                                <i class=""fas fa-user""></i> Satış Geçmişi
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 85 "D:\pc2\WebProgramlama\WebProje2\WebProje2\Views\Personel\PersonelListe.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>
                <!-- /.card-body -->
                <!-- /.card-footer -->
            </div>
            <!-- /.card -->

        </section>
        <!-- /.content -->
        <!-- /.content-wrapper -->
        <!-- Control Sidebar -->
        <aside class=""control-sidebar control-sidebar-dark"">
            <!-- Control sidebar content goes here -->
        </aside>
        <!-- /.control-sidebar -->
    </div>
    <!-- ./wrapper -->
    <!-- jQuery -->
    <script src=""../../plugins/jquery/jquery.min.js""></script>
    <!-- Bootstrap 4 -->
    <script src=""../../plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- AdminLTE App -->
    <script src=""../../dist/js/adminlte.min.js""></script>
    <!-- AdminLTE for demo purposes -->
    <script src=""../../dist/js/demo.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
