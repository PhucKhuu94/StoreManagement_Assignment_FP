#pragma checksum "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Sua_LoaiHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "648c4028774ab2692d9f11a6c0e1e354c36355d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyCuaHang.Pages.Pages_MH_Sua_LoaiHang), @"mvc.1.0.razor-page", @"/Pages/MH_Sua_LoaiHang.cshtml")]
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
#line 3 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Sua_LoaiHang.cshtml"
using QuanLyCuaHang.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"648c4028774ab2692d9f11a6c0e1e354c36355d9", @"/Pages/MH_Sua_LoaiHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19eb323fe5fcc16b6d2fe1de9864a53f95a6caf4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_Sua_LoaiHang : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("\r\n<h1>Sửa thông tin Loại Hàng</h1>\r\n<br />\r\n\r\n");
#nullable restore
#line 10 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Sua_LoaiHang.cshtml"
 if (Model.coDuLieu)
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "648c4028774ab2692d9f11a6c0e1e354c36355d93772", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            <label>Tên Loại Hàng</label> <br />\r\n            <input type=\"text\" name=\"TenLH\" class=\"form-control\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 360, "\"", 415, 1);
#nullable restore
#line 17 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Sua_LoaiHang.cshtml"
WriteAttributeValue("", 388, Model.LoaiHang.TenLoaiHang, 388, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <br />\r\n\r\n    <button class=\"btn btn-success\" type=\"submit\">Xác nhận</button>\r\n    <a href=\"/MH_DanhSach_LoaiHang\" class=\"btn btn-secondary\" style=\"text-decoration: none;\">Hủy</a>\r\n");
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
#line 25 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Sua_LoaiHang.cshtml"
}
else 
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"color: red;\">");
#nullable restore
#line 28 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Sua_LoaiHang.cshtml"
                        Write(Model.Chuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 29 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_Sua_LoaiHang.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCuaHang.Pages.Shared.MH_Sua_LoaiHangModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.Shared.MH_Sua_LoaiHangModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.Shared.MH_Sua_LoaiHangModel>)PageContext?.ViewData;
        public QuanLyCuaHang.Pages.Shared.MH_Sua_LoaiHangModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
