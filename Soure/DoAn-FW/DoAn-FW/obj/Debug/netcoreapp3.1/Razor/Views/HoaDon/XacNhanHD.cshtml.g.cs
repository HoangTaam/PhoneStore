#pragma checksum "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b66b29440a63c0da748ebbc678d91701b850399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDon_XacNhanHD), @"mvc.1.0.view", @"/Views/HoaDon/XacNhanHD.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b66b29440a63c0da748ebbc678d91701b850399", @"/Views/HoaDon/XacNhanHD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3faed0a872865f7b5063ed88e6ca22051c9f0aa3", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDon_XacNhanHD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/HoaDon/InsertHD"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
   
    List<CTHD> listcthd = ViewBag.listcthd;
    KhuyenMai KM = new KhuyenMai();
    KM = ViewBag.KM;
    long ThanhTien = 0;
    long TongTien = 0;
    long TTPhaiTra = 0;
    long TienGiam = 0;
    KhachHang KH = ViewBag.KH;

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
                    <li>
                        <a href=""/TinTuc/DanhSachTinTuc"">Tin tức</a>
    ");
            WriteLiteral("                </li>\n                </ul>\n            </div>\n        </div>\n    </div>\n</div>\n<!-- End mainmenu area -->\n\n");
            WriteLiteral(@"<!-- End Page title area -->


<div style=""display: none; font-size: 1px; color: #fefefe; line-height: 1px; font-family: Open Sans, Helvetica, Arial, sans-serif; max-height: 0px; max-width: 0px; opacity: 0; overflow: hidden;"">
    For what reason would it be advisable for me to think about business content? That might be little bit risky to have crew member like them.
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b66b29440a63c0da748ebbc678d91701b8503995825", async() => {
                WriteLiteral(@"
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
        <tr>
            <td align=""center"" style=""background-color: #eeeeee;"" bgcolor=""#eeeeee"">
                <table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width:800px;"">
                    <tr>
                        <td align=""center"" valign=""top"" style=""font-size:0; padding: 35px;"" bgcolor=""#F44336"">
                            <div style=""display:inline-block; max-width:50%; min-width:100px; vertical-align:top; width:100%;"">
                                <table align=""left"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width:300px;"">
                                    <tr>
                                        <td align=""left"" valign=""top"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 36px; font-weight: 800; line-height: 48px;"" class=""mobile-center"">
                                            <h1 style=""font-size: 36px; font-weight: 800;");
                WriteLiteral(@" margin: 0; color: #ffffff;"">MU STORE</h1>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div style=""display:inline-block; max-width:50%; min-width:100px; vertical-align:top; width:100%;"" class=""mobile-hide"">
                                <table align=""left"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width:300px;"">
                                    <tr>
                                        <td align=""right"" valign=""top"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 48px; font-weight: 400; line-height: 48px;"">
                                            <table cellspacing=""0"" cellpadding=""0"" border=""0"" align=""right"">
                                                <tr>
                                                    <td style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 18px; font-weigh");
                WriteLiteral(@"t: 400;"">
                                                        <p style=""font-size: 18px; font-weight: 400; margin: 0; color: #ffffff;""><a href=""#"" target=""_blank"" style=""color: #ffffff; text-decoration: none;"">Shop &nbsp;</a></p>
                                                    </td>
                                                    <td style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 24px;""> <a href=""#"" target=""_blank"" style=""color: #ffffff; text-decoration: none;""><img src=""https://img.icons8.com/color/48/000000/small-business.png"" width=""27"" height=""23"" style=""display: block; border: 0px;"" /></a> </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
               ");
                WriteLiteral(@"     <tr>
                        <td align=""center"" style=""padding: 35px 35px 20px 35px; background-color: #ffffff;"" bgcolor=""#ffffff"">
                            <table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width:800px;"">
                                <tr>
                                    <td align=""center"" style=""font-family: 'Times New Roman', Times, serif; font-size: 16px; font-weight: 400; line-height: 24px; padding-top: 25px;"">
                                        <img src=""https://img.icons8.com/carbon-copy/100/000000/checked-checkbox.png"" width=""125"" height=""120"" style=""display: block; border: 0px;"" /><br>
                                        <h2 style=""font-size: 30px; font-weight: 800; line-height: 36px; color: #333333; margin: 0;""> Vui lòng kiểm tra lại thông tin! </h2>
                                    </td>
                                </tr>
                                <tr>
                                    <td align=""left"" style");
                WriteLiteral(@"=""padding-top: 20px;"">
                                        <table cellspacing=""0"" cellpadding=""0"" border=""0"" width=""100%"">
                                            <tr>
                                                <td width=""60%"" align=""left"" bgcolor=""#eeeeee"" style=""font-family: 'Times New Roman', Times, serif; font-size: 18px; font-weight: 800; line-height: 24px; padding: 10px;""> Tên sản phẩm</td>
                                                <td width=""15%"" align=""left"" bgcolor=""#eeeeee"" style=""font-family: 'Times New Roman', Times, serif; font-size: 18px; font-weight: 800; line-height: 24px; padding: 10px;""> Số lượng </td>
                                                <td width=""25%"" align=""left"" bgcolor=""#eeeeee"" style=""font-family: 'Times New Roman', Times, serif; font-size: 18px; font-weight: 800; line-height: 24px; padding: 10px;""> Thành Tiền</td>
                                            </tr>
");
#nullable restore
#line 110 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
                                             foreach (var item in listcthd)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <tr>
                                            <td width=""60%"" align=""left"" style=""font-family: 'Times New Roman', Times, serif; font-size: 16px; font-weight: 400; line-height: 24px; padding: 15px 10px 5px 10px;"">
                                                <input name=""MaTTSP[]"" style=""display : none""");
                BeginWriteAttribute("value", " value=\"", 7610, "\"", 7630, 1);
#nullable restore
#line 114 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
WriteAttributeValue("", 7618, item.MaTTSP, 7618, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                                <input name=\"MaKM\" style=\"display : none\"");
                BeginWriteAttribute("value", " value=\"", 7724, "\"", 7740, 1);
#nullable restore
#line 115 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
WriteAttributeValue("", 7732, KM.MaKM, 7732, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                                ");
#nullable restore
#line 116 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
                                           Write(item.TenSP);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </td>
                                            <td width=""15%"" align=""left"" style=""font-family: 'Times New Roman', Times, serif; font-size: 16px; font-weight: 400; line-height: 24px; padding: 15px 10px 5px 10px;"">
                                                ");
#nullable restore
#line 119 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
                                           Write(item.SoLuong);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                                <input name=\"SoLuong[]\" style=\"display : none\"");
                BeginWriteAttribute("value", " value=\"", 8222, "\"", 8243, 1);
#nullable restore
#line 120 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
WriteAttributeValue("", 8230, item.SoLuong, 8230, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                            </td>\n");
#nullable restore
#line 122 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
                                              ThanhTien = item.Gia * item.SoLuong; TongTien += ThanhTien;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <td width=""25%"" align=""left"" style=""font-family: 'Times New Roman', Times, serif; font-size: 16px; font-weight: 400; line-height: 24px; padding: 15px 10px 5px 10px;"">
                                                ");
#nullable restore
#line 124 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
                                           Write(string.Format("{0:0,0 đ}", ThanhTien));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                            </td>\n                                        </tr>");
#nullable restore
#line 126 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
                                             }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </table>
                                    </td>
                                </tr>

                                <tr>
                                    <td align=""left"" style=""padding-top: 20px;"">
                                        <table cellspacing=""0"" cellpadding=""0"" border=""0"" width=""100%"">
                                            <tr>
                                                <td width=""75%"" align=""left"" style=""font-family: 'Times New Roman', Times, serif; font-size: 18px; font-weight: 800; line-height: 24px; padding: 10px; border-top: 3px solid #eeeeee;"">
                                                    Tổng tiền sản phẩm
                                                </td>
                                                <td width=""25%"" align=""left"" style=""font-family: 'Times New Roman', Times, serif; font-size: 18px; font-weight: 800; line-height: 24px; padding: 10px; border-top: 3px solid #eeeeee;"">
                                  ");
                WriteLiteral("                  ");
#nullable restore
#line 139 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
                                               Write(string.Format("{0:0,0 đ}", TongTien));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                                </td>\n                                            </tr>\n                                            <tr>\n");
#nullable restore
#line 143 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
                                                   if (KM.TTienToiThieu <= TongTien)
                                                    {
                                                        TienGiam = (TongTien * KM.SoPTKM) / 100;
                                                        TTPhaiTra = TongTien - TienGiam;
                                                    }
                                                    else
                                                    {
                                                        TTPhaiTra = TongTien;
                                                    }
                                                

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <td width=""75%"" align=""left"" style=""font-family: 'Times New Roman', Times, serif; font-size: 18px; font-weight: 800; line-height: 24px; padding: 10px; "">
                                                    Giảm
                                                </td>
                                                <td width=""25%"" align=""left"" style=""font-family: 'Times New Roman', Times, serif; font-size: 18px; font-weight: 800; line-height: 24px; padding: 10px;"">
                                                    ");
#nullable restore
#line 157 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
                                               Write(string.Format("{0:0,0 đ}", TienGiam));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>

                                <tr>
                                    <td align=""left"" style=""padding-top: 0px;"">
                                        <table cellspacing=""0"" cellpadding=""0"" border=""0"" width=""100%"">
                                            <tr style=""color: #ff7361;"">
                                                <td width=""75%"" align=""left"" style=""font-family: 'Times New Roman', Times, serif; font-size: 18px; font-weight: 800; line-height: 24px; padding: 10px; border-top: 3px solid #eeeeee; border-bottom: 3px solid #eeeeee;"">
                                                    Tổng tiền phải thanh toán
                                                </td>
                                                <td width=""25%"" align=""left"" style=""font-family: ");
                WriteLiteral("\'Times New Roman\', Times, serif; font-size: 16px; font-weight: 800; line-height: 24px; padding: 10px; border-top: 3px solid #eeeeee; border-bottom: 3px solid #eeeeee;\"> ");
#nullable restore
#line 171 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
                                                                                                                                                                                                                                                                     Write(string.Format("{0:0,0 đ}", TTPhaiTra));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align=""left"" height=""100%"" valign=""top"" width=""100%"" style=""padding: 0 35px 0px 35px; background-color: #ffffff;"" bgcolor=""#ffffff"">
                            <div style=""display:inline-block; max-width:100%; min-width:240px; vertical-align:top; width:100%;"">
                                <table align=""left"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width:530px;"">
                                    <tr>
                                        <td align=""left"" valign=""top"" style=""font-family: 'Times New Roman', Times, serif; font-size: 16px; font-weight: 400; line-height: 24px; "">
                                            <p style=""font-weight: 800; fon");
                WriteLiteral(@"t-size: 18px;"">Địa chỉ giao hàng</p>
                                            <input type=""text"" name=""DiaChi"" />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td align=""left"" height=""100%"" valign=""top"" width=""100%"" style=""padding: 0 35px 35px 35px; background-color: #ffffff;"" bgcolor=""#ffffff"">
                            <div style=""display:inline-block; max-width:100%; min-width:240px; vertical-align:top; width:100%;"">
                                <table align=""left"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width:300px;"">
                                    <tr>
                                        <td align=""left"" valign=""top"" style=""font-family: 'Times New Roman', Times, serif; font-size: 16px; font-weight: 400; line-height: 24px; "">
                ");
                WriteLiteral("                            <p style=\"font-weight: 800; font-size: 18px;\">Ngày lập hóa đơn:</p>\n                                            <p>");
#nullable restore
#line 200 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Views\HoaDon\XacNhanHD.cshtml"
                                          Write(DateTime.Now.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td align=""center"" style=""border-radius: 5px;"" bgcolor=""white"">
                            <input type=""submit"" value=""Xác nhận"" style=""font-size: 18px; font-family: 'Times New Roman', Times, serif; color: #ffffff; text-decoration: none; border-radius: 5px; background-color: #01b500; padding: 15px 30px; border: 0px solid #F44336; display: block;"">
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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