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
    public class MH_ThongKe_HetHanSuDungModel : PageModel
    {
        public List<MatHang> dsMH;
        public DateTime toDay = DateTime.Today;
        public bool[] tinhTrangMH;

        public void OnGet()
        {
            dsMH = XuLyMatHang.TimKiem(string.Empty);
            tinhTrangMH = new bool[dsMH.Count];

            for (int i = 0; i < dsMH.Count; i++)
            {
                if(XuLyHoaDon.DaHetHSD(toDay, dsMH[i].HanSuDung))
                {
                    tinhTrangMH[i] = true;
                }
                else { tinhTrangMH[i] = false; }
            }
        }
    }
}
