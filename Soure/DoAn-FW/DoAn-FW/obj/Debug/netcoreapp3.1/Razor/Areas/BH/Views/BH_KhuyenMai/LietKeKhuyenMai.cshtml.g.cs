#pragma checksum "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_KhuyenMai\LietKeKhuyenMai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5ace41242758cd5cf05bea2c95f5b581e528d84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BH_Views_BH_KhuyenMai_LietKeKhuyenMai), @"mvc.1.0.view", @"/Areas/BH/Views/BH_KhuyenMai/LietKeKhuyenMai.cshtml")]
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
#line 1 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\_ViewImports.cshtml"
using Web_projectframeword_admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\_ViewImports.cshtml"
using Web_projectframeword_admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5ace41242758cd5cf05bea2c95f5b581e528d84", @"/Areas/BH/Views/BH_KhuyenMai/LietKeKhuyenMai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ac08b6395ba83e3e81f8ac123db1ca5d7d26c3", @"/Areas/BH/Views/_ViewImports.cshtml")]
    public class Areas_BH_Views_BH_KhuyenMai_LietKeKhuyenMai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    <div class=\"content-wrapper\" style=\"min-height: 639px;\">\r\n        <section class=\"content-header\">\r\n            <h1>\r\n                <i class=\"glyphicon glyphicon-leaf\"></i>Danh sách khuyến mãi\r\n            </h1>\r\n");
            WriteLiteral(@"        </section>
        <section class=""content"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""box"" id=""view"">
                        <div class=""box-header with-border"">
                            <div class=""box-body"">
                                <div class=""row"" style=""padding:0px; margin:0px;"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-hover table-bordered"">
                                            <thead>
                                                <tr>
                                                    <th class=""text-center"">Mã KM</th>
                                                    <th class=""text-center"">Số % KM</th>
                                                    <th class=""text-center"">Ngày bắt đầu</th>
                                                    <th class=""text-center"">Ngày kết thúc</th>
                ");
            WriteLiteral("                                    <th class=\"text-center\">Tiền tối thiểu</th>\r\n");
            WriteLiteral("                                                </tr>\r\n                                            </thead>\r\n                                            <tbody>\r\n");
#nullable restore
#line 34 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_KhuyenMai\LietKeKhuyenMai.cshtml"
                                                 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                 <tr>\r\n                                                    <td class=\"text-center\">");
#nullable restore
#line 36 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_KhuyenMai\LietKeKhuyenMai.cshtml"
                                                                       Write(item.MaKM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"text-center\">");
#nullable restore
#line 37 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_KhuyenMai\LietKeKhuyenMai.cshtml"
                                                                       Write(item.SoPTKM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"text-center\">");
#nullable restore
#line 38 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_KhuyenMai\LietKeKhuyenMai.cshtml"
                                                                       Write(item.TuNgay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"text-center\">");
#nullable restore
#line 39 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_KhuyenMai\LietKeKhuyenMai.cshtml"
                                                                       Write(item.DenNgay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"text-center\">");
#nullable restore
#line 40 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_KhuyenMai\LietKeKhuyenMai.cshtml"
                                                                       Write(item.TTienToiThieu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"text-center\">\r\n                                                        <a class=\"btn btn-success btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 2647, "\"", 2698, 2);
            WriteAttributeValue("", 2654, "/BH/BH_KhuyenMai/ViewKhuyenMai?Id=", 2654, 34, true);
#nullable restore
#line 42 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_KhuyenMai\LietKeKhuyenMai.cshtml"
WriteAttributeValue("", 2688, item.MaKM, 2688, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">\r\n                                                            <span class=\"glyphicon glyphicon-edit\"></span>Xem\r\n                                                        </a>\r\n                                                    </td>\r\n");
            WriteLiteral("                                                </tr>\r\n");
#nullable restore
#line 52 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_KhuyenMai\LietKeKhuyenMai.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
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
                    </div>
                </div>
            </div>
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
