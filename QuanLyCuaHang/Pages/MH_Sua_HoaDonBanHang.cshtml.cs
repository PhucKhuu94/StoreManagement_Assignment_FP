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
    public class MH_Sua_HoaDonBanHangModel : PageModel
    {
        public string Chuoi = string.Empty;
        public List<string> dsTenMH = new();
        public bool coDuLieu;
        public HoaDon hoaDon;

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
            HoaDon? editHD = XuLyHoaDon.DocHoaDonBanHang(MaHD);
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
            // tao list string chua ten Mat Hang
            foreach (MatHang eachItem in dsMH)
            {
                if (eachItem.TenMatHang != hoaDon.TenMatHang)
                {
                    dsTenMH.Add(eachItem.TenMatHang);
                }
            }
        }

        public void OnPost()
        {
            bool kq = XuLyHoaDon.SuaHoaDonBanHang
                (MaHD, TenMH, SoLuong, NgayTao, out string errorMessage);
            if (kq)
            {
                Response.Redirect("MH_DanhSach_HoaDonBanHang");
            }
            else
            {
                Chuoi = errorMessage;
            }
        }
    }
}
