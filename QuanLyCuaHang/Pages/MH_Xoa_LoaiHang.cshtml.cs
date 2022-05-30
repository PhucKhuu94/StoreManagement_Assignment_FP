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
    public class MH_Xoa_LoaiHangModel : PageModel
    {
        public LoaiHang infoLH;
        public List<MatHang> dsMHLienQuan;
        public List<LoaiHang> dsLH = XuLyLoaiHang.TimKiem(string.Empty);
        public bool coDuLieu;
        public string Chuoi = string.Empty;

        [BindProperty (SupportsGet = true)]
        public string MaLH { get; set; }

        public void OnGet()
        {
            LoaiHang? truyxuatLH = XuLyLoaiHang.DocSanPham(MaLH);
            if (truyxuatLH != null)
            {
                coDuLieu = true;
                infoLH = truyxuatLH.Value;
                dsMHLienQuan = XuLyMatHang.TimKiemLoaiHang(infoLH.MaLoaiHang);
            }
            else
            {
                coDuLieu = false;
                Chuoi = "Không tìm thấy dữ liệu";
            }
        }

        public void OnPost()
        {
            XuLyLoaiHang.Xoa(MaLH);
            Response.Redirect("/MH_DanhSach_LoaiHang");
        }
    }
}
