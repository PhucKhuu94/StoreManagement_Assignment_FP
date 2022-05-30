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
    public class MH_TaoMoi_LoaiHangModel : PageModel
    {
        [BindProperty]
        public string MaLH { get; set; }
        [BindProperty]
        public string TenLH { get; set; }

        public string Chuoi = string.Empty;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            bool kq = XuLyLoaiHang.TaoMoi(MaLH, TenLH, out string errorMessage);
            if (kq)
            {
                Response.Redirect("/MH_DanhSach_LoaiHang");
            }
            else
            {
                Chuoi = errorMessage;
            }
            
        }
    }
}
