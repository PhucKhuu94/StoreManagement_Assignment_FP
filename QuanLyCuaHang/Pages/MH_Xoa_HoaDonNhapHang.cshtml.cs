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
    public class MH_Xoa_HoaDonNhapHangModel : PageModel
    {
        public string Chuoi = string.Empty;
        public bool coDuLieu;
        public HoaDon hoaDon;

        [BindProperty(SupportsGet = true)]
        public string MaHD { get; set; }

        public void OnGet()
        {
            HoaDon? xoaHD = XuLyHoaDon.DocHoaDonNhapHang(MaHD);
            if(xoaHD != null)
            {
                hoaDon = xoaHD.Value;
                coDuLieu = true;
            }
            else
            {
                coDuLieu = false;
                Chuoi = "Không tìm thấy dữ liệu";
            }
        }

        public void OnPost()
        {
            XuLyHoaDon.XoaHoaDonNhapHang(MaHD);
            Response.Redirect("/MH_DanhSach_HoaDonNhapHang");
        }
    }
}
