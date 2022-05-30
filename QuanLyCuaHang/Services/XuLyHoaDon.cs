using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyCuaHang.Entities;
using QuanLyCuaHang.DAL;

namespace QuanLyCuaHang.Services
{
    public class XuLyHoaDon
    {
        // --------------------- NHAP HANG --------------------
        public static bool TaoMoiHDNhapHang(string maHoaDon, DateTime ngayTao,
            string tenMatHang, int soLuong, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(maHoaDon) ||
                string.IsNullOrWhiteSpace(tenMatHang))
            {
                errorMessage = "Dữ liệu nhập vào không thể để trống";
                return false;
            }
            else if (soLuong <= 0)
            {
                errorMessage = "Số lượng nhập vào không hợp lệ";
                return false;
            }
            else if (KiemTraMaDaCo_NhapHang(maHoaDon))
            {
                errorMessage = "Trùng Mã Hóa Đơn";
                return false;
            }
            // kiểm tra ngày tạo hóa đơn so với ngày hiện tại
            int checkDate = DateTime.Compare(ngayTao, DateTime.Today);
            if (checkDate > 0)
            {
                errorMessage = "Ngày Tạo hóa đơn vượt quá ngày hiện tại";
                return false;
            }

            HoaDon hoaDon;
            hoaDon.MaHoaDon = maHoaDon.ToUpper();
            hoaDon.NgayTao = ngayTao;
            hoaDon.TenMatHang = tenMatHang.ToUpper();
            hoaDon.SoLuong = soLuong;

            LuuTruHoaDon.TaoMoiHoaDonNhapHang(hoaDon);

            errorMessage = string.Empty;
            return true;
        }

        public static List<HoaDon> TimKiemHDNhapHang(string tuKhoa)
        {
            if (tuKhoa == null)
            {
                tuKhoa = string.Empty;
            }

            List<HoaDon> dsHD = LuuTruHoaDon.DocDSHoaDonNhapHang();
            List<HoaDon> dsKQ = new List<HoaDon>();
            foreach (HoaDon hoaDon in dsHD)
            {
                if (hoaDon.TenMatHang.Contains(tuKhoa.ToUpper()))
                {
                    dsKQ.Add(hoaDon);
                }
            }

            return dsKQ;
        }

        public static bool KiemTraMaDaCo_NhapHang(string maHoaDon)
        {
            List<HoaDon> dsHD = LuuTruHoaDon.DocDSHoaDonNhapHang();
            foreach (HoaDon checkHD in dsHD)
            {
                if (checkHD.MaHoaDon == maHoaDon.ToUpper())
                {
                    return true;
                }
            }

            return false;
        }

        public static HoaDon? DocHoaDonNhapHang(string maHD)
        {
            List<HoaDon> dsHD = LuuTruHoaDon.DocDSHoaDonNhapHang();
            for (int i = 0; i < dsHD.Count; i++)
            {
                if (dsHD[i].MaHoaDon == maHD)
                {
                    return dsHD[i];
                }
            }

            return null;
        }

        public static void XoaHoaDonNhapHang(string maHD)
        {
            LuuTruHoaDon.XoaHoaDonNhapHang(maHD);
        }

        public static bool SuaHoaDonNhapHang(string maHD,
            string tenMH, int soLuong, DateTime ngayTao, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(tenMH))
            {
                errorMessage = "Tên Mặt Hàng không thể để trống";
                return false;
            }
            else if(soLuong <= 0)
            {
                errorMessage = "Số lượng nhập vào không hợp lệ";
                return false;
            }

            HoaDon newHD;
            newHD.MaHoaDon = maHD.ToUpper();
            newHD.TenMatHang = tenMH.ToUpper();
            newHD.NgayTao = ngayTao;
            newHD.SoLuong = soLuong;

            errorMessage = string.Empty;
            return LuuTruHoaDon.SuaHoaDonNhapHang(newHD);
        }

        // --------------------- BAN HANG --------------------
        public static bool TaoMoiHDBanHang(string maHoaDon, DateTime ngayTao,
            string tenMatHang, int soLuong, out string errorMessage)
        {
            int soLuongHangTrongKho = CapNhatSoLuongTonKho(tenMatHang, ngayTao);
            if (string.IsNullOrWhiteSpace(maHoaDon) ||
                string.IsNullOrWhiteSpace(tenMatHang))
            {
                errorMessage = "Dữ liệu nhập vào không thể để trống";
                return false;
            }
            else if (soLuong <= 0)
            {
                errorMessage = "Số lượng nhập vào không hợp lệ";
                return false;
            }
            else if (KiemTraMaDaCo_NhapHang(maHoaDon))
            {
                errorMessage = "Trùng Mã Hóa Đơn";
                return false;
            }
            else if (soLuong > soLuongHangTrongKho)
            {
                errorMessage = "Số lượng hàng tồn kho không đủ";
                return false;
            }

            HoaDon hoaDon;
            hoaDon.MaHoaDon = maHoaDon.ToUpper();
            hoaDon.NgayTao = ngayTao;
            hoaDon.TenMatHang = tenMatHang.ToUpper();
            hoaDon.SoLuong = soLuong;

            LuuTruHoaDon.TaoMoiHoaDonBanHang(hoaDon);

            errorMessage = string.Empty;
            return true;
        }
        public static int CapNhatSoLuongTonKho(string tenMH, DateTime ngayBanHang)
        {
            List<HoaDon> dsHDNhap = TimKiemHDNhapHang(string.Empty);
            List<HoaDon> dsHDBan = TimKiemHDBanHang(string.Empty);
            int soLuongNhap = 0, soLuongBan = 0;
            // tim tong so luong Nhap den ngay tao hoa don Ban hang
            foreach (HoaDon eachItem in dsHDNhap)
            {
                int checkDate = DateTime.Compare(ngayBanHang, eachItem.NgayTao);
                if (eachItem.TenMatHang == tenMH && checkDate >= 0)
                {
                    soLuongNhap += eachItem.SoLuong;
                }
            }
            // tim tong so luong Ban den ngay tao hoa don Ban hang
            foreach (HoaDon eachItem in dsHDBan)
            {
                int checkDate = DateTime.Compare(ngayBanHang, eachItem.NgayTao);
                if (eachItem.TenMatHang == tenMH && checkDate >= 0)
                {
                    soLuongBan += eachItem.SoLuong;
                }
            }
            // tra ve gia tri ton kho
            return soLuongNhap - soLuongBan;
        }

        public static List<HoaDon> TimKiemHDBanHang(string tuKhoa)
        {
            if (tuKhoa == null)
            {
                tuKhoa = string.Empty;
            }

            List<HoaDon> dsHD = LuuTruHoaDon.DocDSHoaDonBanHang();
            List<HoaDon> dsKQ = new List<HoaDon>();
            foreach (HoaDon hoaDon in dsHD)
            {
                if (hoaDon.TenMatHang.Contains(tuKhoa.ToUpper()))
                {
                    dsKQ.Add(hoaDon);
                }
            }

            return dsKQ;
        }

        public static HoaDon? DocHoaDonBanHang(string maHD)
        {
            List<HoaDon> dsHD = LuuTruHoaDon.DocDSHoaDonBanHang();
            for (int i = 0; i < dsHD.Count; i++)
            {
                if (dsHD[i].MaHoaDon == maHD)
                {
                    return dsHD[i];
                }
            }

            return null;
        }

        public static void XoaHoaDonBanHang(string maHD)
        {
            LuuTruHoaDon.XoaHoaDonBanHang(maHD);
        }

        public static bool SuaHoaDonBanHang(string maHD,
            string tenMatHang, int soLuong, DateTime ngayTao, out string errorMessage)
        {
            int soLuongHangTrongKho = CapNhatSoLuongTonKho(tenMatHang, ngayTao);
            if (string.IsNullOrWhiteSpace(tenMatHang))
            {
                errorMessage = "Tên Mặt Hàng không thể để trống ";
                return false;
            }
            else if (soLuong <= 0)
            {
                errorMessage = "Số lượng nhập vào không hợp lệ";
                return false;
            }
            else if (soLuong > soLuongHangTrongKho)
            {
                errorMessage = "Số lượng hàng tồn kho không đủ";
                return false;
            }

            HoaDon newHD;
            newHD.MaHoaDon = maHD.ToUpper();
            newHD.TenMatHang = tenMatHang.ToUpper();
            newHD.NgayTao = ngayTao;
            newHD.SoLuong = soLuong;

            errorMessage = string.Empty;
            return LuuTruHoaDon.SuaHoaDonBanHang(newHD);
        }

        public static bool KiemTraMaDaCo_BanHang(string maHoaDon)
        {
            List<HoaDon> dsHD = LuuTruHoaDon.DocDSHoaDonBanHang();
            foreach (HoaDon checkHD in dsHD)
            {
                if (checkHD.MaHoaDon == maHoaDon.ToUpper())
                {
                    return true;
                }
            }

            return false;
        }

        public static HoaDon? DocMatHangNhapHang(string tenMatHang)
        {
            List<HoaDon> dsHD = LuuTruHoaDon.DocDSHoaDonNhapHang();
            for (int i = 0; i < dsHD.Count; i++)
            {
                if (dsHD[i].TenMatHang == tenMatHang)
                {
                    return dsHD[i];
                }
            }

            return null;
        }

        // ------------------ THONG KE ------------------------
        public static int LaySoLuongHang(string tenMH, List<HoaDon> dsHD)
        {
            int soLuong = 0;
            foreach (HoaDon eachHD in dsHD)
            {
                if(eachHD.TenMatHang == tenMH)
                {
                    soLuong += eachHD.SoLuong;
                }
            }

            return soLuong;
        }

        public static bool DaHetHSD(DateTime Today, DateTime HSD)
        {
            int checkDate = DateTime.Compare(Today, HSD);
            // Today sau HSD => la con HSD
            if(checkDate <= 0)
            {
                return false;
            }

            return true;
        }

    }
}
