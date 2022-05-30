using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuanLyCuaHang.Entities;
using QuanLyCuaHang.Services;

namespace QuanLyCuaHang.Pages.Shared
{
    public class MH_Sua_LoaiHangModel : PageModel
    {
        public string Chuoi = string.Empty;
        public bool coDuLieu;
        public LoaiHang LoaiHang;

        [BindProperty(SupportsGet = true)]
        public string MaLH { get; set; }
        [BindProperty]
        public string TenLH { get; set; }
        
        public void OnGet()
        {
            LoaiHang? loaiHang = XuLyLoaiHang.DocSanPham(MaLH);
            if (loaiHang != null)
            {
                coDuLieu = true;
                LoaiHang = loaiHang.Value;
            }
            else
            {
                coDuLieu = false;
                Chuoi = "Không tìm thấy dữ liệu";
            }
        }

        public void OnPost()
        {
            bool kq = XuLyLoaiHang.Sua(MaLH, TenLH, out string errorMessage);
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
