#pragma checksum "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_TinTuc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57014d0df1c60a648c7e198fd0ed88162f925a45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BH_Views_BH_TinTuc_Index), @"mvc.1.0.view", @"/Areas/BH/Views/BH_TinTuc/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57014d0df1c60a648c7e198fd0ed88162f925a45", @"/Areas/BH/Views/BH_TinTuc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ac08b6395ba83e3e81f8ac123db1ca5d7d26c3", @"/Areas/BH/Views/_ViewImports.cshtml")]
    public class Areas_BH_Views_BH_TinTuc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_projectframeword_admin.Models.TinTuc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""content-wrapper"" style=""min-height: 639px;"">
        <section class=""content-header"">
            <h1>
                <i class=""glyphicon glyphicon-book""></i>Danh sách bài viết
            </h1>
            <div class=""breadcrumb"">
                <div class=""searchbox"">
                    <input type=""text"" placeholder=""Search here"">
                    <a><i class=""fas fa-search-location""></i></a>
                </div>
                <a class=""btn btn-primary btn-sm"" href=""/BH/BH_TinTuc/ThemTinTuc"" role=""button"">
                    <span class=""glyphicon glyphicon-plus""></span>Thêm mới
                </a>
            </div>
        </section>
        <section class=""content"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""box"" id=""view"">
                        <div class=""box-header with-border"">
                            <div class=""box-body"">
                                <div class=""row"" style=""paddin");
            WriteLiteral(@"g:0px; margin:0px;"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-hover table-bordered"">
                                            <thead>
                                                <tr>
                                                    <th class=""text-center"">ID</th>
                                                    <th class=""text-center"" style=""width:100px;"">Hình</th>
                                                    <th class=""text-center"">Tiêu đề bài viết</th>
");
            WriteLiteral(@"                                                    <th class=""text-center"">Trạng thái</th>
                                                    <th class=""text-center"" colspan=""2"">Thao tác</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 39 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_TinTuc\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td class=\"text-center\">");
#nullable restore
#line 42 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_TinTuc\Index.cshtml"
                                                                           Write(item.matintuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                            <img");
            BeginWriteAttribute("src", " src=\"", 2637, "\"", 2656, 1);
#nullable restore
#line 44 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_TinTuc\Index.cshtml"
WriteAttributeValue("", 2643, item.hinhbia, 2643, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2657, "\"", 2663, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        </td>\r\n                                                        <td> ");
#nullable restore
#line 46 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_TinTuc\Index.cshtml"
                                                        Write(item.tieude);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 49 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_TinTuc\Index.cshtml"
                                                         if(@item.trangthai == 1) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td class=\"text-center\">\r\n                                                                <a");
            BeginWriteAttribute("href", " href=\"", 3212, "\"", 3219, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                    <span class=""glyphicon glyphicon-ok-circle mauxanh18""></span>
                                                                </a>
                                                            </td>
");
#nullable restore
#line 55 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_TinTuc\Index.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td class=\"text-center\">\r\n                                                                <a");
            BeginWriteAttribute("href", " href=\"", 3823, "\"", 3830, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                    <span class=""glyphicon glyphicon-remove-circle maudau""></span>
                                                                </a>
                                                            </td>
");
#nullable restore
#line 63 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_TinTuc\Index.cshtml"
                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td class=\"text-center\">\r\n                                                            <a class=\"btn btn-success btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 4338, "\"", 4386, 2);
            WriteAttributeValue("", 4345, "/BH/BH_TinTuc/SuaTinTuc?id=", 4345, 27, true);
#nullable restore
#line 65 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_TinTuc\Index.cshtml"
WriteAttributeValue("", 4372, item.matintuc, 4372, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"">
                                                                <span class=""glyphicon glyphicon-edit""></span>Sửa
                                                            </a>
                                                        </td>
                                                        <td class=""text-center"">
                                                            <a class=""btn btn-danger btn-xs""");
            BeginWriteAttribute("href", " href=\"", 4822, "\"", 4866, 2);
            WriteAttributeValue("", 4829, "/BH/BH_TinTuc/Index?id=", 4829, 23, true);
#nullable restore
#line 70 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_TinTuc\Index.cshtml"
WriteAttributeValue("", 4852, item.matintuc, 4852, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Xác nhận xóa bài này ?')"" role=""button"">
                                                                <span class=""glyphicon glyphicon-trash""></span>Xóa
                                                            </a>
                                                        </td>
                                                    </tr>
");
#nullable restore
#line 75 "D:\C#\ASP\Đồ Án\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_TinTuc\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_projectframeword_admin.Models.TinTuc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
