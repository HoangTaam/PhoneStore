#pragma checksum "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\InsertHD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f5b3062dea0e12e8ad09a3eb8dee92c720e0f87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDon_InsertHD), @"mvc.1.0.view", @"/Views/HoaDon/InsertHD.cshtml")]
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
#line 1 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\_ViewImports.cshtml"
using DoAn_FW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\_ViewImports.cshtml"
using DoAn_FW.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f5b3062dea0e12e8ad09a3eb8dee92c720e0f87", @"/Views/HoaDon/InsertHD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3faed0a872865f7b5063ed88e6ca22051c9f0aa3", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDon_InsertHD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""mainmenu-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""navbar-header"">
                    <button type=""button""
                            class=""navbar-toggle""
                            data-toggle=""collapse""
                            data-target="".navbar-collapse"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>
                </div>
                <div class=""navbar-collapse collapse"">
                    <ul class=""nav navbar-nav"">
                        <li class=""active""><a href=""/Home/Index"">Trang chủ</a></li>
                        <li>
                            <a href=""/SanPham/DTDD"">Điện thoại</a>
                        </li>
                        <li><a href=""/SanPham/MayTinhBang"">Má");
            WriteLiteral(@"y tính bảng</a></li>
                        <li><a href=""/TinTuc/DanhSachTinTuc"">Tin tức</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class=""single-product-area"">
        <div class=""zigzag-bottom""></div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""single-sidebar"">
");
#nullable restore
#line 35 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\InsertHD.cshtml"
                         if (ViewBag.Count == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2 class=\"alert alert-success\">Tạo hóa đơn thành công!! Xin cám ơn quý khách</h2>\r\n");
#nullable restore
#line 38 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\InsertHD.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2 class=\"alert alert-danger\">Tạo hóa đơn thất bại!! Vui lòng thử lại</h2>\r\n");
#nullable restore
#line 42 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\InsertHD.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n");
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
