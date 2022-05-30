using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyCuaHang.Entities;
using QuanLyCuaHang.DAL;

namespace QuanLyCuaHang.Services
{
    public class XuLyMatHang
    {
        public static bool TaoMoi(string maMH, string tenMH, string cty, 
            DateTime hsd, DateTime nsx, string LH, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(maMH) ||
                string.IsNullOrWhiteSpace(tenMH) ||
                string.IsNullOrWhiteSpace(cty) ||
                string.IsNullOrWhiteSpace(LH))
            {
                errorMessage = "Dữ liệu nhập vào bị trống";
                return false;
            }

            // kiem tra trung ten mat hang or ma mat hang
            else if (KiemTraMaDaCo(maMH) ||
                KiemTraTenDaCo(maMH, tenMH))
            {
                errorMessage = "Trùng Tên Mặt Hàng hay Mã Mặt Hàng";
                return false;
            }

            // kiem tra HSD & NSX hop le
            int checkDate = DateTime.Compare(hsd, nsx);
            if(checkDate <= 0)
            {
                errorMessage = "HSD và NSX nhập vào không hợp lệ";
                return false;
            }

            MatHang newMH = new();
            newMH.MaMatHang = maMH.ToUpper();
            newMH.TenMatHang = tenMH.ToUpper();
            newMH.CtySanXuat = cty.ToUpper();
            newMH.HanSuDung = hsd;
            newMH.NgaySanXuat = nsx;
            newMH.MaLoaiHang = LH;
            LuuTruMatHang.TaoMoiMatHang(newMH);

            errorMessage = string.Empty;
            return true;
        }

        public static List<MatHang> TimKiem(string tuKhoa)
        {
            if (tuKhoa == null)
            {
                tuKhoa = string.Empty;
            }

            List<MatHang> dsMH = LuuTruMatHang.DocDSMatHang();
            List<MatHang> dsKQ = new List<MatHang>();
            foreach (MatHang mh in dsMH)
            {
                if (mh.TenMatHang.Contains(tuKhoa.ToUpper()))
                {
                    dsKQ.Add(mh);
                }
            }

            return dsKQ;
        }

        public static List<MatHang> TimKiemLoaiHang(string tuKhoa)
        {
            List<MatHang> dsMH = LuuTruMatHang.DocDSMatHang();
            List<MatHang> dsKQ = new();
            foreach (MatHang mh in dsMH)
            {
                if (mh.MaLoaiHang.Contains(tuKhoa.ToUpper()))
                {
                    dsKQ.Add(mh);
                }
            }

            return dsKQ;
        }

        public static bool KiemTraMaDaCo(string maMatHang)
        {
            List<MatHang> dsMH = LuuTruMatHang.DocDSMatHang();
            foreach(MatHang checkMH in dsMH)
            {
                if (checkMH.MaMatHang == maMatHang.ToUpper())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool KiemTraTenDaCo(string maMatHang, string tenMatHang)
        {
            List<MatHang> dsMH = LuuTruMatHang.DocDSMatHang();
            foreach (MatHang checkMH in dsMH)
            {
                if (checkMH.TenMatHang == tenMatHang.ToUpper() && 
                    checkMH.MaMatHang != maMatHang.ToUpper())
                {
                    return true;
                }
            }

            return false;
        }

        public static MatHang? DocSanPham(string maMH)
        {
            List<MatHang> dsMH = LuuTruMatHang.DocDSMatHang();
            for(int i = 0; i < dsMH.Count; i++)
            {
                if (dsMH[i].MaMatHang == maMH)
                {
                    return dsMH[i];
                }
            }

            return null;
        }

        public static void Xoa(string maLH)
        {
            LuuTruMatHang.XoaMatHang(maLH);
        }

        public static bool Sua(string maMH, string tenMH, string cty,
            DateTime hsd, DateTime nsx, string LH, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(tenMH) ||
                string.IsNullOrWhiteSpace(cty) ||
                string.IsNullOrWhiteSpace(LH))
            {
                errorMessage = "Dữ liệu nhập vào không thể để trống";
                return false;
            }
            else if (KiemTraTenDaCo(maMH, tenMH))
            {
                errorMessage = "Trùng Tên Mặt Hàng";
                return false;
            }

            int checkDate = DateTime.Compare(hsd, nsx);
            if (checkDate <= 0)
            {
                errorMessage = "HSD và NSX không hợp lệ";
                return false;
            }
            
            MatHang editMH = new();
            editMH.MaMatHang = maMH.ToUpper();
            editMH.TenMatHang = tenMH.ToUpper();
            editMH.CtySanXuat = cty.ToUpper();
            editMH.HanSuDung = hsd;
            editMH.NgaySanXuat = nsx;
            editMH.MaLoaiHang = LH;

            errorMessage = string.Empty;
            return LuuTruMatHang.SuaMatHang(editMH);
        }
    }
}
