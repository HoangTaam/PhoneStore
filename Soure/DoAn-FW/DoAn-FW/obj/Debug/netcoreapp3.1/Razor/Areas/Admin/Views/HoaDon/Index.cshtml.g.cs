#pragma checksum "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8ec8c3fcf94cf56204a2ffa5b92579e4e31c4f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HoaDon_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HoaDon/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8ec8c3fcf94cf56204a2ffa5b92579e4e31c4f4", @"/Areas/Admin/Views/HoaDon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ac08b6395ba83e3e81f8ac123db1ca5d7d26c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HoaDon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_projectframeword_admin.Models.HoaDonViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/HoaDon/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Hoadon/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
   int pages = Convert.ToInt32(ViewData["pages"]); int p = Convert.ToInt32(ViewData["page"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content-wrapper\" style=\"min-height: 639px;\">\r\n    <section class=\"content-header\">\r\n        <h1>\r\n            <i class=\"glyphicon glyphicon-ok-sign\"></i>Danh sách hóa đơn\r\n        </h1>\r\n        <div class=\"breadcrumb\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8ec8c3fcf94cf56204a2ffa5b92579e4e31c4f45209", async() => {
                WriteLiteral(@"
                <input type=""text"" placeholder=""Search here"" name=""SearchString"">
                <button type=""submit"" style=""width: 50px; height: 25px; background-color: darkcyan; border-radius: 10px; color: white; border-color: white; ""><i class=""fas fa-search-location""></i></button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <a class=\"btn btn-primary btn-sm\" href=\"/Admin/HoaDon/ThemHD\" role=\"button\">\r\n                <span class=\"glyphicon glyphicon-plus\"></span>Thêm mới\r\n            </a>\r\n        </div>\r\n    </section>\r\n    <section class=\"content\">\r\n");
#nullable restore
#line 19 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
         if (Convert.ToString(ViewData["tb"]) == "Thêm hóa đơn thành công")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"alert alert-success\">\r\n                    ");
#nullable restore
#line 23 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
               Write(ViewData["tb"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 27 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
          
            if (Convert.ToString(ViewData["trangthai"]) == "Xóa không thành công")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"alert alert-error\">\r\n                        ");
#nullable restore
#line 33 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                   Write(ViewData["trangthai"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 37 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
            }
            if (Convert.ToString(ViewData["trangthai"]) == "Xóa thành công")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"alert alert-success\">\r\n                        ");
#nullable restore
#line 42 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                   Write(ViewData["trangthai"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 46 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""box"" id=""view"">
                    <div class=""box-header with-border"">
                        <div class=""box-body"">
                            <div class=""row"" style=""padding:0px; margin:0px;"">
                                <div class=""table-responsive"">
                                    <table class=""table table-hover table-bordered"">
                                        <thead>
                                            <tr>
                                                <th class=""text-center"">Mã HĐ</th>
                                                <th>Khách hàng</th>
                                                <th>Tổng tiền</th>
                                                <th>Ngày lập HD</th>
                                                <th>Tình trạng</th>
                                                <th class=""text-center"">Duyệt</th>
                                    ");
            WriteLiteral(@"            <th>Địa chỉ</th>
                                                <th class=""text-center"" colspan=""3"">Thao tác</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 69 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                              
                                                int a = Convert.ToInt32(ViewData["ThongBao"]);
                                                if (a == 1)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr><td class=\"text-center\" colspan=\"9\">Không tìm thấy hóa đơn nào!</td></tr>\r\n");
#nullable restore
#line 74 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                }
                                                else
                                                    foreach (var hd in Model)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                            <td class=\"text-center\">");
#nullable restore
#line 79 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                               Write(hd.MaHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 80 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                           Write(hd.TenKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 81 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                           Write(hd.TongTienTT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 82 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                           Write(hd.NgayLapHD.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>\r\n");
#nullable restore
#line 84 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                  
                                                                    if (hd.TinhTrangTT == 0)
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <span>Chưa thanh toán</span>\r\n");
#nullable restore
#line 88 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                    }
                                                                    else
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <span>Đã thanh toán</span>\r\n");
#nullable restore
#line 92 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                    }
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            </td>\r\n                                                            <td style=\"text-align: center;\">\r\n");
#nullable restore
#line 96 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                  
                                                                    if (hd.TinhTrangHD == 0)
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <a class=\"btn btn-default btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 5972, "\"", 6016, 2);
            WriteAttributeValue("", 5979, "/Admin/GiaoHang/DuyetHD?MAHD=", 5979, 29, true);
#nullable restore
#line 99 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 6008, hd.MaHD, 6008, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Xác nhận đơn hàng và chuẩn bị giao hàng ?')"" role=""button"">
                                                                            <i class=""fa fa-check-square""></i> Duyệt đơn
                                                                        </a>
                                                                        <a class=""btn btn-default btn-xs""");
            BeginWriteAttribute("href", " href=\"", 6409, "\"", 6457, 4);
            WriteAttributeValue("", 6416, "/Admin/HoaDon/HuyHD?MAHD=", 6416, 25, true);
#nullable restore
#line 102 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 6441, hd.MaHD, 6441, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6449, "&page=", 6449, 6, true);
#nullable restore
#line 102 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 6455, p, 6455, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Xác nhận hủy đơn hàng ?')"" role=""button"">
                                                                            <i class=""fa fa-window-close""></i> Hủy
                                                                        </a>
");
#nullable restore
#line 105 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                    }
                                                                    else if (hd.TinhTrangHD == -1)
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <span>Đã hủy</span>\r\n");
#nullable restore
#line 109 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                    }
                                                                    else
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <span>Đã duyệt</span>\r\n");
#nullable restore
#line 113 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                    }
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            </td>\r\n                                                            <td>");
#nullable restore
#line 116 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                           Write(hd.DiaChiGH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td class=\"text-center\">\r\n                                                                <a class=\"btn btn-info btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 7835, "\"", 7873, 2);
            WriteAttributeValue("", 7842, "/Admin/HoaDon/XemHD?ID=", 7842, 23, true);
#nullable restore
#line 118 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 7865, hd.MaHD, 7865, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"">
                                                                    <span class=""glyphicon glyphicon-eye-open""></span>Xem
                                                                </a>
                                                            </td>
                                                            <td class=""text-center"">
                                                                <a class=""btn btn-info btn-xs""");
            BeginWriteAttribute("href", " href=\"", 8331, "\"", 8371, 2);
            WriteAttributeValue("", 8338, "/Admin/HoaDon/XemCTHD?ID=", 8338, 25, true);
#nullable restore
#line 123 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 8363, hd.MaHD, 8363, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"">
                                                                    <span class=""glyphicon glyphicon-eye-open""></span>CTHD
                                                                </a>
                                                            </td>
                                                            <td class=""text-center"">
");
#nullable restore
#line 128 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                  var t = (Model.Count() == 1) ? (p - 1) : p;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <a class=\"btn btn-danger btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 8944, "\"", 8993, 4);
            WriteAttributeValue("", 8951, "/Admin/HoaDon/Delete?MAHD=", 8951, 26, true);
#nullable restore
#line 129 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 8977, hd.MaHD, 8977, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8985, "&page=", 8985, 6, true);
#nullable restore
#line 129 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 8991, t, 8991, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Xác nhận xóa hóa đơn này ?')"" role=""button"">
                                                                    <span class=""glyphicon glyphicon-trash""></span>Xóa
                                                                </a>
                                                            </td>
                                                        </tr>
");
#nullable restore
#line 134 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                    }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12 text-center"">
                <div class=""pull-right pagination"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8ec8c3fcf94cf56204a2ffa5b92579e4e31c4f423798", async() => {
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"Go to\" /> page <input type=\"number\"");
                BeginWriteAttribute("max", " max=\"", 10068, "\"", 10080, 1);
#nullable restore
#line 150 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 10074, pages, 10074, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" name=\"page\"");
                BeginWriteAttribute("value", " value=\"", 10101, "\"", 10111, 1);
#nullable restore
#line 150 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 10109, p, 10109, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> of ");
#nullable restore
#line 150 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                                                                                     Write(pages);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_projectframeword_admin.Models.HoaDonViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
