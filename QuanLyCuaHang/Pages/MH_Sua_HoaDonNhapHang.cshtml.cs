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
    public class MH_Sua_HoaDonNhapHangModel : PageModel
    {
        public string Chuoi = string.Empty;
        public bool coDuLieu;
        public HoaDon hoaDon;
        public List<string> dsTenMH = new();

        [BindProperty(SupportsGet = true)]
        public string MaHD { get; set; }
        [BindProperty]
        public string TenMH { get; set; }
        [BindProperty]
        public int SoLuong { get; set; }
        [BindProperty]
        public DateTime NgayTao { get; set; }

        public void OnGet()
        {
            HoaDon? editHD = XuLyHoaDon.DocHoaDonNhapHang(MaHD);
            if (editHD != null)
            {
                hoaDon = editHD.Value;
                coDuLieu = true;
            }
            else
            {
                coDuLieu = false;
                Chuoi = "Không tìm thấy dữ liệu";
            }

            List<MatHang> dsMH = XuLyMatHang.TimKiem(string.Empty);
            foreach(MatHang eachItem in dsMH)
            {
                if(eachItem.TenMatHang != hoaDon.TenMatHang)
                {
                    dsTenMH.Add(eachItem.TenMatHang);
                }
            }
        }

        public void OnPost()
        {
            bool kq = XuLyHoaDon.SuaHoaDonNhapHang
                (MaHD, TenMH, SoLuong, NgayTao, out string errorMessage);
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
