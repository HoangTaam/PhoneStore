#pragma checksum "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b165860abaf74cb0d3b9a29701e9c6ad16a3b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TinTuc_DanhSachTinTuc), @"mvc.1.0.view", @"/Views/TinTuc/DanhSachTinTuc.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b165860abaf74cb0d3b9a29701e9c6ad16a3b9", @"/Views/TinTuc/DanhSachTinTuc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3faed0a872865f7b5063ed88e6ca22051c9f0aa3", @"/Views/_ViewImports.cshtml")]
    public class Views_TinTuc_DanhSachTinTuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAn_FW.Models.TinTuc>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TinTuc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DanhSachTinTuc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
  
    ViewData["Title"] = "Tin tức";

    Pager pager = new Pager();

    int pageNo = 0;
    if(ViewBag.Pager != null)
    {
        pager = ViewBag.Pager;
        pageNo = pager.CurrentPage; 
    }

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
        <div class=""row"">
");
#nullable restore
#line 62 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
             foreach (var tintuc in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
                 if (@tintuc.TrangThai == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-sm-6 col-md-4\">\r\n                        <div class=\"thumbnail\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2191, "\"", 2212, 1);
#nullable restore
#line 68 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
WriteAttributeValue("", 2197, tintuc.HinhBia, 2197, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 2213, "\"", 2268, 1);
#nullable restore
#line 69 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
WriteAttributeValue("", 2253, tintuc.HinhBia, 2253, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <div class=\"caption\">\r\n                                <h3>");
#nullable restore
#line 71 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
                               Write(tintuc.TieuDe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 73 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
                               Write(tintuc.TieuDe);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2b165860abaf74cb0d3b9a29701e9c6ad16a3b99096", async() => {
                WriteLiteral("Xem ngay");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2591, "~/TinTuc/ChiTietTinTuc?Id=", 2591, 26, true);
#nullable restore
#line 76 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
AddHtmlAttributeValue(" ", 2617, tintuc.MaTinTuc, 2618, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 83 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div class=\"product-pagination text-center\">\r\n");
#nullable restore
#line 89 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
                     if(pager.TotalPages > 0)
                     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul class=\"pagination\">\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3254, "\"", 3309, 2);
            WriteAttributeValue("", 3261, "/TinTuc/DanhSachTinTuc?pg=", 3261, 26, true);
#nullable restore
#line 93 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
WriteAttributeValue("", 3287, pager.CurrentPage-1, 3287, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                <span aria-hidden=\"true\">&laquo;</span>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 97 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
                         for (var pge = pager.StartPage; pge <= pager.EndPage; pge++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 3618, "\"", 3679, 2);
            WriteAttributeValue("", 3626, "page-item", 3626, 9, true);
#nullable restore
#line 99 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
WriteAttributeValue(" ", 3635, pge == pager.CurrentPage ? "active" : "", 3636, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2b165860abaf74cb0d3b9a29701e9c6ad16a3b913277", async() => {
#nullable restore
#line 100 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
                                                                                                                        Write(pge);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pg", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
                                                                                                           WriteLiteral(pge);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pg"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pg", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pg"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 102 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3940, "\"", 3995, 2);
            WriteAttributeValue("", 3947, "/TinTuc/DanhSachTinTuc?pg=", 3947, 26, true);
#nullable restore
#line 104 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
WriteAttributeValue("", 3973, pager.CurrentPage+1, 3973, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                                <span aria-hidden=\"true\">&raquo;</span>\r\n                            </a>\r\n                        </li>\r\n                    </ul>\r\n");
#nullable restore
#line 109 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\TinTuc\DanhSachTinTuc.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAn_FW.Models.TinTuc>> Html { get; private set; }
    }
}
#pragma warning restore 1591