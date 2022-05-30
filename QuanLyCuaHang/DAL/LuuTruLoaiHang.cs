using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuanLyCuaHang.Entities;
using System.IO;
using Newtonsoft.Json;

namespace QuanLyCuaHang.DAL
{
    public class LuuTruLoaiHang
    {
        public static bool LuuDSLoaiHang(List<LoaiHang> dsLH)
        {
            StreamWriter writer = 
                new StreamWriter("./DAL/LoaiHang.json");
            string jsonString = JsonConvert.SerializeObject(dsLH);
            writer.Write(jsonString);
            writer.Close();

            return true;
        }

        public static List<LoaiHang> DocDSLoaiHang()
        {
            StreamReader reader = 
                new StreamReader("./DAL/LoaiHang.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<LoaiHang> dsLH = JsonConvert.
                DeserializeObject<List<LoaiHang>>(jsonString);

            return dsLH;
        }

        public static bool TaoMoiLoaiHang(LoaiHang lh)
        {
            List<LoaiHang> dsLH = DocDSLoaiHang();
            dsLH.Add(lh);

            return LuuDSLoaiHang(dsLH);
        }

        public static void XoaLoaiHang(string maLH)
        {
            List<LoaiHang> dsLH = DocDSLoaiHang();
            List<MatHang> dsMH = LuuTruMatHang.DocDSMatHang();
            for (int i = 0; i < dsLH.Count; i++)
            {
                if (dsLH[i].MaLoaiHang == maLH)
                {
                    string maLHXoa = dsLH[i].MaLoaiHang;
                    for (int j = 0; j < dsMH.Count; j++)
                    {
                        if(dsMH[j].MaLoaiHang == maLHXoa)
                        {
                            dsMH.RemoveAt(j);
                        }
                    }
                    LuuTruMatHang.LuuDSMatHang(dsMH);
                    dsLH.RemoveAt(i);
                    break;
                }
            }
            LuuDSLoaiHang(dsLH);
        }

        public static bool SuaLoaiHang(LoaiHang loaiHang)
        {
            List<LoaiHang> dsLH = DocDSLoaiHang();
            for (int i = 0; i < dsLH.Count; i++)
            {
                if (dsLH[i].MaLoaiHang == loaiHang.MaLoaiHang)
                {
                    dsLH[i] = loaiHang;
                    LuuDSLoaiHang(dsLH);
                    return true;
                }
            }

            return false;
        }
    }
}
