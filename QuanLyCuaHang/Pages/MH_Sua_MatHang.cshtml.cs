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
    public class MH_Sua_MatHangModel : PageModel
    {
        public string Chuoi = string.Empty;
        public bool coDuLieu;
        public MatHang thongTinMH;
        public string TenLH;
        public List<LoaiHang> dsLH = XuLyLoaiHang.TimKiem(string.Empty);

        [BindProperty(SupportsGet = true)]
        public string MaMH { get; set; }
        [BindProperty]
        public string TenMH { get; set; }
        [BindProperty]
        public string Cty { get; set; }
        [BindProperty]
        public DateTime NSX { get; set; }
        [BindProperty]
        public DateTime HSD { get; set; }
        [BindProperty]
        public string LH { get; set; }

        public void OnGet()
        {
            //xu ly method: get voi MaMH
            MatHang? truyXuatMH = XuLyMatHang.DocSanPham(MaMH);
            if (truyXuatMH != null)
            {
                thongTinMH = truyXuatMH.Value;
                coDuLieu = true;
            }
            else
            {
                coDuLieu = false;
                Chuoi = "Không tìm thấy dữ liệu";
            }
            
            //load du lieu danh sach loai hang cho dropdown menu
            for (int i = 0; i < dsLH.Count; i++)
            {
                if (thongTinMH.MaLoaiHang == dsLH[i].MaLoaiHang)
                {
                    TenLH = dsLH[i].TenLoaiHang;
                    dsLH.RemoveAt(i);
                }
            }
        }

        public void OnPost()
        {
            bool kq = XuLyMatHang.Sua(MaMH, TenMH, Cty, HSD, NSX, LH, out string errorMessage);
            if (kq)
            {
                Response.Redirect("/MH_DanhSach_MatHang");
            }
            else
            {
                Chuoi = errorMessage;
            }
        }
    }
}
