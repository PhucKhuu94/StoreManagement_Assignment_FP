using System.Collections.Generic;
using QuanLyCuaHang.Entities;
using System.IO;
using Newtonsoft.Json;

namespace QuanLyCuaHang.DAL
{
    public class LuuTruMatHang
    {
        public static bool LuuDSMatHang(List<MatHang> dsMH)
        {
            StreamWriter writer = 
                new StreamWriter("./DAL/MatHang.json");
            string jsonString = JsonConvert.SerializeObject(dsMH);
            writer.Write(jsonString);
            writer.Close();

            return true;
        }

        public static List<MatHang> DocDSMatHang()
        {
            StreamReader reader = 
                new StreamReader("./DAL/MatHang.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();

            List<MatHang> dsMH = JsonConvert.
                DeserializeObject<List<MatHang>>(jsonString);

            return dsMH;
        }

        public static bool TaoMoiMatHang(MatHang mh)
        {
            List<MatHang> dsMH = DocDSMatHang();
            dsMH.Add(mh);

            return LuuDSMatHang(dsMH);
        }

        public static void XoaMatHang(string maLH)
        {
            List<MatHang> dsMH = DocDSMatHang();
            for (int i = 0; i < dsMH.Count; i++)
            {
                if (dsMH[i].MaMatHang == maLH)
                {
                    dsMH.RemoveAt(i);
                    break;
                }
            }
            LuuDSMatHang(dsMH);
        }

        public static bool SuaMatHang(MatHang editMH)
        {
            List<MatHang> dsMH = DocDSMatHang();
            for (int i = 0; i < dsMH.Count; i++)
            {
                if (dsMH[i].MaMatHang == editMH.MaMatHang)
                {
                    dsMH[i] = editMH;
                    LuuDSMatHang(dsMH);
                    return true;
                }
            }

            return false;
        }
    }
}
