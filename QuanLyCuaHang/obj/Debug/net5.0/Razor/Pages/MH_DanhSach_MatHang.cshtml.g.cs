#pragma checksum "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c188a9d2c5beaeb5a2a4867895f1ab37c58e21b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyCuaHang.Pages.Pages_MH_DanhSach_MatHang), @"mvc.1.0.razor-page", @"/Pages/MH_DanhSach_MatHang.cshtml")]
namespace QuanLyCuaHang.Pages
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
#line 1 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\_ViewImports.cshtml"
using QuanLyCuaHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
using QuanLyCuaHang.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c188a9d2c5beaeb5a2a4867895f1ab37c58e21b", @"/Pages/MH_DanhSach_MatHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19eb323fe5fcc16b6d2fe1de9864a53f95a6caf4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_DanhSach_MatHang : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Quản lý Mặt Hàng</h1>\r\n<br />\r\n<div>\r\n    <h6>\r\n        <a href=\"/MH_TaoMoi_MatHang\" style=\"text-decoration: none;\">Thêm Mặt Hàng mới</a>\r\n    </h6>\r\n</div>\r\n<br />\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c188a9d2c5beaeb5a2a4867895f1ab37c58e21b3766", async() => {
                WriteLiteral(@"
        <div class=""input-group"">
            <input type=""text"" name=""TuKhoa"" class=""form-control"" placeholder=""nhập từ khóa"">
            <div class=""input-group-append"">
                <button class=""btn btn-info"" type=""submit"">Tìm kiếm</button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<br />
<div>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>STT</th>
                <th>Mã Mặt Hàng</th>
                <th>Tên Mặt Hàng</th>
                <th>Cty Sản Xuất</th>
                <th>Hạn Sử Dụng</th>
                <th>Ngày Sản Xuất</th>
                <th>Tên Loại Hàng</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 41 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
             foreach (MatHang mh in Model.dsMH)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>#");
#nullable restore
#line 44 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
                     Write(Model.dsMH.IndexOf(mh) + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
                   Write(mh.MaMatHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
                   Write(mh.TenMatHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
                   Write(mh.CtySanXuat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
                   Write(mh.HanSuDung.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
                   Write(mh.NgaySanXuat.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 51 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
                         foreach (LoaiHang item in Model.dsLH)
                        {
                            if (item.MaLoaiHang == mh.MaLoaiHang)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
                           Write(item.TenLoaiHang);

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
                                                 
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1871, "\"", 1912, 2);
            WriteAttributeValue("", 1878, "/MH_Sua_MatHang?MaMH=", 1878, 21, true);
#nullable restore
#line 60 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
WriteAttributeValue("", 1899, mh.MaMatHang, 1899, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\r\n                        |\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1976, "\"", 2017, 2);
            WriteAttributeValue("", 1983, "/MH_Xoa_MatHang?MaMH=", 1983, 21, true);
#nullable restore
#line 62 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
WriteAttributeValue("", 2004, mh.MaMatHang, 2004, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 65 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_DanhSach_MatHang.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCuaHang.Pages.MH_DanhSach_MatHangModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.MH_DanhSach_MatHangModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.MH_DanhSach_MatHangModel>)PageContext?.ViewData;
        public QuanLyCuaHang.Pages.MH_DanhSach_MatHangModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
