#pragma checksum "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_HoTro\LietKeHoTro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c32c3c0becc91ee4b2630e568a7d577d7256a19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TT_Views_TT_HoTro_LietKeHoTro), @"mvc.1.0.view", @"/Areas/TT/Views/TT_HoTro/LietKeHoTro.cshtml")]
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
#line 1 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\TT\Views\_ViewImports.cshtml"
using Web_projectframeword_admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\TT\Views\_ViewImports.cshtml"
using Web_projectframeword_admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c32c3c0becc91ee4b2630e568a7d577d7256a19", @"/Areas/TT/Views/TT_HoTro/LietKeHoTro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ac08b6395ba83e3e81f8ac123db1ca5d7d26c3", @"/Areas/TT/Views/_ViewImports.cshtml")]
    public class Areas_TT_Views_TT_HoTro_LietKeHoTro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"    <div class=""content-wrapper"" style=""min-height: 639px;"">
        <section class=""content-header"">
            <h1><i class=""glyphicon glyphicon-time""></i> Hổ trợ</h1>
        </section>
        <!-- Main content -->
        <section class=""content"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""box"" id=""view"">
                        <div class=""box-body"">
                            <div class=""row"" style=""padding:0px; margin:0px;"">
                                <div class=""table-responsive"">
                                    <table class=""table table-hover table-bordered"">
                                        <thead>
                                            <tr>
                                                <th class=""text-center"">Mã bình luận</th>
                                                <th class=""text-center"">Sản phẩm</th>
                                                <th class=""text-center"">Khách hàng</th>");
            WriteLiteral(@"
                                                <th class=""text-center"">Nội dung</th>
                                                <th class=""text-center"" colspan=""1"">Thao tác</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 26 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_HoTro\LietKeHoTro.cshtml"
                                             foreach (var item in Model)
                                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <tr>\r\n                                                <td class=\"text-center\">");
#nullable restore
#line 29 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_HoTro\LietKeHoTro.cshtml"
                                                                   Write(item.MABL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
#nullable restore
#line 30 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_HoTro\LietKeHoTro.cshtml"
                                                                   Write(item.TENSP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
#nullable restore
#line 31 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_HoTro\LietKeHoTro.cshtml"
                                                                   Write(item.TENKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
#nullable restore
#line 32 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_HoTro\LietKeHoTro.cshtml"
                                                                   Write(item.NOIDUNG);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>             \r\n                                                <td class=\"text-center\">\r\n                                                    <a class=\"btn btn-danger btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 2072, "\"", 2117, 2);
            WriteAttributeValue("", 2079, "/TT/TT_HoTro/DeleteHoTro?Id=", 2079, 28, true);
#nullable restore
#line 34 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_HoTro\LietKeHoTro.cshtml"
WriteAttributeValue("", 2107, item.MABL, 2107, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Xác nhận xóa bình luận này ?')"" role=""button"">
                                                        <span class=""glyphicon glyphicon-trash""></span>Xóa
                                                    </a>
                                                </td>
                                             </tr>
");
#nullable restore
#line 39 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_HoTro\LietKeHoTro.cshtml"
                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-12 text-center"">
                                        <ul class=""pagination"">
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div><!-- /.box -->
            </div>
            <!-- /.col -->
        </section>
    </div>
");
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
