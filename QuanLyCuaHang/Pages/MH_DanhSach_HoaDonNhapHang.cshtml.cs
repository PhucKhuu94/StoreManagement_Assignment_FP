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
    public class MH_DanhSach_HoaDonNhapHangModel : PageModel
    {
        public string Chuoi = string.Empty;
        public List<HoaDon> dsHD;

        [BindProperty]
        public string TuKhoa { get; set; }

        public void OnGet()
        {
            dsHD = XuLyHoaDon.TimKiemHDNhapHang(string.Empty);
        }

        public void OnPost()
        {
            dsHD = XuLyHoaDon.TimKiemHDNhapHang(TuKhoa);
        }
    }
}
