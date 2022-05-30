using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyCuaHang.Entities;
using System.IO;
using Newtonsoft.Json;

namespace QuanLyCuaHang.DAL
{
    public class LuuTruHoaDon
    {
        // ------------ NHAP HANG-------------------
        public static bool LuuDSHoaDonNhapHang(List<HoaDon> dsLH)
        {
            StreamWriter writer =
                new StreamWriter("./DAL/HoaDonNhapHang.json");
            string jsonString = JsonConvert.SerializeObject(dsLH);
            writer.Write(jsonString);
            writer.Close();

            return true;

        }

        public static List<HoaDon> DocDSHoaDonNhapHang()
        {
            StreamReader reader =
                new StreamReader("./DAL/HoaDonNhapHang.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<HoaDon> dsLH = JsonConvert.
                DeserializeObject<List<HoaDon>>(jsonString);

            return dsLH;
        }

        public static bool TaoMoiHoaDonNhapHang(HoaDon hoaDon)
        {
            List<HoaDon> dsHD = DocDSHoaDonNhapHang();
            dsHD.Add(hoaDon);

            return LuuDSHoaDonNhapHang(dsHD);
        }

        public static void XoaHoaDonNhapHang(string maHD)
        {
            List<HoaDon> dsHD = DocDSHoaDonNhapHang();
            for (int i = 0; i < dsHD.Count; i++)
            {
                if (dsHD[i].MaHoaDon == maHD)
                {
                    dsHD.RemoveAt(i);
                    break;
                }
            }
            LuuDSHoaDonNhapHang(dsHD);
        }

        public static bool SuaHoaDonNhapHang(HoaDon editHD)
        {
            List<HoaDon> dsHD = DocDSHoaDonNhapHang();
            for (int i = 0; i < dsHD.Count; i++)
            {
                if (dsHD[i].MaHoaDon == editHD.MaHoaDon)
                {
                    dsHD[i] = editHD;
                    LuuDSHoaDonNhapHang(dsHD);
                    return true;
                }
            }

            return false;
        }
        // -----------------BAN HANG-----------------
        public static bool LuuDSHoaDonBanHang(List<HoaDon> dsLH)
        {
            StreamWriter writer = 
                new StreamWriter("./DAL/HoaDonBanHang.json");
            string jsonString = JsonConvert.SerializeObject(dsLH);
            writer.Write(jsonString);
            writer.Close();

            return true;
            
        }

        public static List<HoaDon> DocDSHoaDonBanHang()
        {
            StreamReader reader =
                new StreamReader("./DAL/HoaDonBanHang.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<HoaDon> dsLH = JsonConvert.
                DeserializeObject<List<HoaDon>>(jsonString);

            return dsLH;
        }

        public static bool TaoMoiHoaDonBanHang(HoaDon lh)
        {
            List<HoaDon> dsLH = DocDSHoaDonBanHang();
            dsLH.Add(lh);

            return LuuDSHoaDonBanHang(dsLH);
        }

        public static void XoaHoaDonBanHang(string maLH)
        {
            List<HoaDon> dsLH = DocDSHoaDonBanHang();
            for (int i = 0; i < dsLH.Count; i++)
            {
                if (dsLH[i].MaHoaDon == maLH)
                {
                    dsLH.RemoveAt(i);
                    break;
                }
            }
            LuuDSHoaDonBanHang(dsLH);
        }

        public static bool SuaHoaDonBanHang(HoaDon HoaDonBanHang)
        {
            List<HoaDon> dsLH = DocDSHoaDonBanHang();
            for (int i = 0; i < dsLH.Count; i++)
            {
                if (dsLH[i].MaHoaDon == HoaDonBanHang.MaHoaDon)
                {
                    dsLH[i] = HoaDonBanHang;
                    LuuDSHoaDonBanHang(dsLH);
                    return true;
                }
            }

            return false;
        }



        
    }
}
