using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyCuaHang.Entities;
using QuanLyCuaHang.DAL;

namespace QuanLyCuaHang.Services
{
    public class XuLyLoaiHang
    {
        public static bool TaoMoi(string maLoaiHang, 
            string tenLoaiHang, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(maLoaiHang) ||
                string.IsNullOrWhiteSpace(tenLoaiHang))
            {
                errorMessage = "Dữ liệu nhập vào bị trống";
                return false;
            }
            else if (KiemTraMaDaCo(maLoaiHang) ||
                KiemTraTenDaCo(maLoaiHang, tenLoaiHang))
            {
                errorMessage = "Trùng Mã Loại Hàng hoặc Tên Loại Hàng";
                return false;
            }

            LoaiHang lh;
            lh.MaLoaiHang = maLoaiHang.ToUpper();
            lh.TenLoaiHang = tenLoaiHang.ToUpper();
            LuuTruLoaiHang.TaoMoiLoaiHang(lh);

            errorMessage = string.Empty;
            return true;
        }

        public static List<LoaiHang> TimKiem(string tuKhoa)
        {
            if (tuKhoa == null)
            {
                tuKhoa = string.Empty;
            }

            List<LoaiHang> dsLH = LuuTruLoaiHang.DocDSLoaiHang();
            List<LoaiHang> dsKQ = new List<LoaiHang>();
            foreach (LoaiHang lh in dsLH)
            {
                if (lh.TenLoaiHang.Contains(tuKhoa.ToUpper()))
                {
                    dsKQ.Add(lh);
                }
            }

            return dsKQ;
        }

        public static bool KiemTraMaDaCo(string maLoaiHang)
        {
            List<LoaiHang> dsLH = LuuTruLoaiHang.DocDSLoaiHang();
            foreach(LoaiHang checkLH in dsLH)
            {
                if (checkLH.MaLoaiHang == maLoaiHang.ToUpper())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool KiemTraTenDaCo(string maLoaiHang, string tenLoaiHang)
        {
            List<LoaiHang> dsLH = LuuTruLoaiHang.DocDSLoaiHang();
            foreach (LoaiHang checkLH in dsLH)
            {
                if (checkLH.TenLoaiHang == tenLoaiHang.ToUpper() && 
                    checkLH.MaLoaiHang != maLoaiHang.ToUpper())
                {
                    return true;
                }
            }

            return false;
        }

        public static LoaiHang? DocSanPham(string maLH)
        {
            List<LoaiHang> dsLH = LuuTruLoaiHang.DocDSLoaiHang();
            for(int i = 0; i < dsLH.Count; i++)
            {
                if (dsLH[i].MaLoaiHang == maLH)
                {
                    return dsLH[i];
                }
            }

            return null;
        }

        public static void Xoa(string maLH)
        {
            LuuTruLoaiHang.XoaLoaiHang(maLH);
        }

        public static bool Sua(string maLH, 
            string tenLH, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(tenLH))
            {
                errorMessage = "Tên Loại Hàng không thể để trống";
                return false;
            }
            else if (KiemTraTenDaCo(maLH, tenLH))
            {
                errorMessage = "Trùng Tên Loại Hàng";
                return false;
            }

            LoaiHang editLH;
            editLH.MaLoaiHang = maLH.ToUpper();
            editLH.TenLoaiHang = tenLH.ToUpper();

            errorMessage = string.Empty;
            return LuuTruLoaiHang.SuaLoaiHang(editLH);
        }
    }
}
