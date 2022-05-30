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
    public class MH_DanhSach_MatHangModel : PageModel
    {
        public List<MatHang> dsMH = new();
        public List<LoaiHang> dsLH = XuLyLoaiHang.TimKiem(string.Empty);

        [BindProperty]
        public string TuKhoa { get; set; }

        public void OnGet()
        {
            dsMH = XuLyMatHang.TimKiem(string.Empty);
        }

        public void OnPost()
        {
            dsMH = XuLyMatHang.TimKiem(TuKhoa);
        }
    }
}
