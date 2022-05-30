using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuanLyCuaHang.Entities;
using QuanLyCuaHang.Services;

namespace QuanLyCuaHang.Pages
{
    public class MH_TaoMoi_MatHangModel : PageModel
    {
        public string Chuoi = string.Empty;
        public List<LoaiHang> dsLH = XuLyLoaiHang.TimKiem(string.Empty);

        [BindProperty]
        public string MaMH { get; set; }
        [BindProperty]
        public string TenMH { get; set; }
        [BindProperty]
        public string Cty { get; set; }
        [BindProperty]
        public DateTime HSD { get; set; }
        [BindProperty]
        public DateTime NSX { get; set; }
        [BindProperty]
        public string LH { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            bool kq = XuLyMatHang.TaoMoi(MaMH, TenMH, Cty, HSD, NSX, LH, out string errorMessage);
            if (kq)
            {
                Response.Redirect("/MH_DanhSach_MatHang");
            }
            else
            {
                Chuoi = errorMessage;
            }
        }
    }
}
