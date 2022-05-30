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
    public class MH_Xoa_MatHangModel : PageModel
    {
        public string Chuoi = string.Empty;
        public bool coDuLieu;
        public MatHang mh;
        public string tenLH;
        List<LoaiHang> dsLH = XuLyLoaiHang.TimKiem(string.Empty);

        [BindProperty(SupportsGet = true)]
        public string MaMH { get; set; }

        public void OnGet()
        {
            MatHang? truyXuatMH = XuLyMatHang.DocSanPham(MaMH);
            if (truyXuatMH != null)
            {
                mh = truyXuatMH.Value;
                coDuLieu = true;
                foreach (var item in dsLH)
                {
                    if (item.MaLoaiHang == truyXuatMH.Value.MaLoaiHang)
                        tenLH = item.TenLoaiHang;
                }
            }
            else
            {
                coDuLieu = false;
                Chuoi = "Không tìm thấy dữ liệu";
            }

            
        }

        public void OnPost()
        {
            XuLyMatHang.Xoa(MaMH);
            Response.Redirect("/MH_DanhSach_MatHang");
        }
    }
}
