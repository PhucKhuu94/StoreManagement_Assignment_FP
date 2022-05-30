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
    public class MH_ThongKeKhoModel : PageModel
    {
        public List<MatHang> dsMH;
        public List<HoaDon> hoaDonNhap;
        public List<HoaDon> hoaDonBan;
        public List<int> soLuongHang = new();

        public void OnGet()
        {
            dsMH = XuLyMatHang.TimKiem(string.Empty);
            hoaDonNhap = XuLyHoaDon.TimKiemHDNhapHang(string.Empty);
            hoaDonBan = XuLyHoaDon.TimKiemHDBanHang(string.Empty);
            for (int i = 0; i < dsMH.Count; i++)
            {
                int soLuongNhap = XuLyHoaDon.LaySoLuongHang(dsMH[i].TenMatHang, hoaDonNhap);
                int soLuongBan = XuLyHoaDon.LaySoLuongHang(dsMH[i].TenMatHang, hoaDonBan);
                soLuongHang.Add(soLuongNhap - soLuongBan);
            }

        }
    }
}
