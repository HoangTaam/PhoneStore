#pragma checksum "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\ChiTietTinTuc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2419f0ce41533eed148e91f94b0227ac5704005c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TinTuc_ChiTietTinTuc), @"mvc.1.0.view", @"/Views/TinTuc/ChiTietTinTuc.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2419f0ce41533eed148e91f94b0227ac5704005c", @"/Views/TinTuc/ChiTietTinTuc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3faed0a872865f7b5063ed88e6ca22051c9f0aa3", @"/Views/_ViewImports.cshtml")]
    public class Views_TinTuc_ChiTietTinTuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DoAn_FW.Models.TinTuc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\ChiTietTinTuc.cshtml"
  
    ViewData["Title"] = "Tin tức";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""mainmenu-area"">
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
                    <li><a href=""/Home/Index"">Trang chủ</a></li>
                    <li>
                        <a href=""/SanPham/DTDD"">Điện thoại</a>
                    </li>
                    <li><a href=""/SanPham/MayTinhBang"">Máy tính bảng</a></li>
                    <li class=""active"">
                        <a href=""/Ti");
            WriteLiteral(@"nTuc/DanhSachTinTuc"">Tin tức</a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- End mainmenu area -->

<div class=""product-big-title-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""product-bit-title text-center"">
                    <h2>Tiêu đề bài viết</h2>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- End Page title area -->

<div class=""single-product-area"">
    <div class=""zigzag-bottom""></div>
    <div class=""container"">
");
#nullable restore
#line 52 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\ChiTietTinTuc.cshtml"
         foreach (var tintuc in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                ");
#nullable restore
#line 55 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\ChiTietTinTuc.cshtml"
           Write(tintuc.NoiDung);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <a");
            BeginWriteAttribute("href", " href =\"", 1860, "\"", 1880, 1);
#nullable restore
#line 57 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\ChiTietTinTuc.cshtml"
WriteAttributeValue("", 1868, tintuc.Link, 1868, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Nguồn nội dung</a>\r\n");
#nullable restore
#line 58 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\ChiTietTinTuc.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DoAn_FW.Models.TinTuc>> Html { get; private set; }
    }
}
#pragma warning restore 1591