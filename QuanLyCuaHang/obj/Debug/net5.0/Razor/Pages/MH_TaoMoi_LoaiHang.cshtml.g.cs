#pragma checksum "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_TaoMoi_LoaiHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95e8450cb3080f9a769a285b8b506a1902526620"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyCuaHang.Pages.Pages_MH_TaoMoi_LoaiHang), @"mvc.1.0.razor-page", @"/Pages/MH_TaoMoi_LoaiHang.cshtml")]
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
#line 3 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_TaoMoi_LoaiHang.cshtml"
using QuanLyCuaHang.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95e8450cb3080f9a769a285b8b506a1902526620", @"/Pages/MH_TaoMoi_LoaiHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19eb323fe5fcc16b6d2fe1de9864a53f95a6caf4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_TaoMoi_LoaiHang : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<h1>Tạo mới Loại Hàng</h1>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95e8450cb3080f9a769a285b8b506a19025266203593", async() => {
                WriteLiteral(@"
    <h5>Nhập thông tin Loại Hàng</h5>
    <div class=""row my-3"">
        <div class=""col-4"">
            <label for=""MaLH"">Mã loại hàng</label> <br />
            <input type=""text"" name=""MaLH"" id=""MaLH"" class=""form-control""/>
        </div>
    </div>
    <div class=""row my-3"">
        <div class=""col-4"">
            <label for=""TenLH"">Tên loại hàng</label> <br />
            <input type=""text"" name=""TenLH"" id=""TenLH"" class=""form-control"" />
        </div>
    </div>
    <br />

    <button type=""submit"" class=""btn btn-success"">Tạo mới</button>
    <a href=""/MH_DanhSach_LoaiHang"" class=""btn btn-secondary"" style=""text-decoration: none;"">Hủy</a>
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
            WriteLiteral("\r\n<br />\r\n<div style=\"color: red;\">\r\n    ");
#nullable restore
#line 29 "G:\DoAnKTLT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_TaoMoi_LoaiHang.cshtml"
Write(Model.Chuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCuaHang.Pages.MH_TaoMoi_LoaiHangModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.MH_TaoMoi_LoaiHangModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.MH_TaoMoi_LoaiHangModel>)PageContext?.ViewData;
        public QuanLyCuaHang.Pages.MH_TaoMoi_LoaiHangModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
