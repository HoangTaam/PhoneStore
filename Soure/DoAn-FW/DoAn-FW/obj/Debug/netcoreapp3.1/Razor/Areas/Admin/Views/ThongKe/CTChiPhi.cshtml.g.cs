#pragma checksum "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\ThongKe\CTChiPhi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "471c23177409f509c525cc3f3bd2091a0c5229df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ThongKe_CTChiPhi), @"mvc.1.0.view", @"/Areas/Admin/Views/ThongKe/CTChiPhi.cshtml")]
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
#line 1 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\_ViewImports.cshtml"
using Web_projectframeword_admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\_ViewImports.cshtml"
using Web_projectframeword_admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"471c23177409f509c525cc3f3bd2091a0c5229df", @"/Areas/Admin/Views/ThongKe/CTChiPhi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ac08b6395ba83e3e81f8ac123db1ca5d7d26c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ThongKe_CTChiPhi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_projectframeword_admin.Models.NhapHang>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"content-wrapper\" style=\"min-height: 639px;\">\r\n        <section class=\"content-header\">\r\n            <h1>\r\n                <i class=\"glyphicon glyphicon-ok-sign\"></i>Danh sách phiếu nhập tháng ");
#nullable restore
#line 6 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\ThongKe\CTChiPhi.cshtml"
                                                                                 Write(ViewBag.Thang);

#line default
#line hidden
#nullable disable
            WriteLiteral(" năm ");
#nullable restore
#line 6 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\ThongKe\CTChiPhi.cshtml"
                                                                                                    Write(ViewBag.Nam);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </h1>
            <div class=""breadcrumb"">
                <div class=""searchbox"">
                    <input type=""text"" placeholder=""Search here"">
                    <a><i class=""fas fa-search-location""></i></a>
                </div>
            </div>
        </section>
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
                                                    <th class=""text-center"">Mã PN</th>
                   ");
            WriteLiteral(@"                                 <th>Nhà cung cấp</th>
                                                    <th>Tổng tiền</th>
                                                    <th>Ngày lập PN</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 33 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\ThongKe\CTChiPhi.cshtml"
                                              if (Model.Count() > 0)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\ThongKe\CTChiPhi.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td class=\"text-center\">");
#nullable restore
#line 38 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\ThongKe\CTChiPhi.cshtml"
                                                                           Write(item.MAPN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 39 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\ThongKe\CTChiPhi.cshtml"
                                                       Write(item.TENNCC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 40 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\ThongKe\CTChiPhi.cshtml"
                                                       Write(string.Format("{0:0,0}", @item.TONGTIENTT));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n                                                        <td>");
#nullable restore
#line 41 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\ThongKe\CTChiPhi.cshtml"
                                                       Write(item.NGAYLAPPN.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 43 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\ThongKe\CTChiPhi.cshtml"

                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\ThongKe\CTChiPhi.cshtml"
                                                 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_projectframeword_admin.Models.NhapHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
