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
    public class MH_TaoMoi_HoaDonNhapHangModel : PageModel
    {
        public string Chuoi = string.Empty;
        public List<MatHang> dsMH = XuLyMatHang.TimKiem(string.Empty);

        [BindProperty]
        public string MaHD { get; set; }
        [BindProperty]
        public DateTime NgayTao { get; set; }
        [BindProperty]
        public string TenMH { get; set; }
        [BindProperty]
        public int SoLuong { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            bool kq = XuLyHoaDon.TaoMoiHDNhapHang
                (MaHD, NgayTao, TenMH, SoLuong, out string errorMessage);
            if (kq)
            {
                Response.Redirect("MH_DanhSach_HoaDonNhapHang");
            }
            else
            {
                Chuoi = errorMessage;
            }
        }
    }
}
