#pragma checksum "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc1503fa6e3d382681fb5423f191ccf41c67b6ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyCuaHang.Pages.Pages_MH_Xoa_LoaiHang), @"mvc.1.0.razor-page", @"/Pages/MH_Xoa_LoaiHang.cshtml")]
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
#line 3 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc1503fa6e3d382681fb5423f191ccf41c67b6ee", @"/Pages/MH_Xoa_LoaiHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19eb323fe5fcc16b6d2fe1de9864a53f95a6caf4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_Xoa_LoaiHang : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
 if (@Model.coDuLieu)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Xóa Loại Hàng</h1>\r\n    <br />\r\n    <h5>Bạn có muốn xóa Loại Hàng ");
#nullable restore
#line 11 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
                             Write(Model.infoLH.TenLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ?</h5>
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Mã Loại Hàng</th>
                <th>Tên Loại Hàng</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 21 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
               Write(Model.infoLH.MaLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
               Write(Model.infoLH.TenLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 29 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
     if (Model.dsMHLienQuan.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div> Xóa <b>Loại Hàng</b> sẽ <b>xóa luôn</b> các Mặt Hàng liên quan gồm:</div>
        <br />
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Mã Mặt Hàng</th>
                    <th>Tên Mặt Hàng</th>
                    <th>Tên Loại Hàng</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 42 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
                 foreach (MatHang mh in Model.dsMHLienQuan)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 45 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
                       Write(mh.MaMatHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
                       Write(mh.TenMatHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 48 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
                             foreach (var item in Model.dsLH)
                            {
                                if (item.MaLoaiHang == mh.MaLoaiHang)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
                               Write(item.TenLoaiHang);

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
                                                     
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 60 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc1503fa6e3d382681fb5423f191ccf41c67b6ee7891", async() => {
                WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-danger\">Xác nhận</button>\r\n        <a href=\"/MH_DanhSach_LoaiHang\" class=\"btn btn-secondary\"\r\n           style=\"text-decoration: none;\">Hủy</a>\r\n    ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 68 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"color: red;\">");
#nullable restore
#line 71 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
                        Write(Model.Chuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 72 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Xoa_LoaiHang.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCuaHang.Pages.MH_Xoa_LoaiHangModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.MH_Xoa_LoaiHangModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.MH_Xoa_LoaiHangModel>)PageContext?.ViewData;
        public QuanLyCuaHang.Pages.MH_Xoa_LoaiHangModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591