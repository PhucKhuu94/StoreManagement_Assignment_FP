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
    public class MH_DanhSach_LoaiHangModel : PageModel
    {
        public List<LoaiHang> dsLH;

        [BindProperty]
        public string TuKhoa { get; set; }

        public void OnGet()
        {
            dsLH = XuLyLoaiHang.TimKiem(string.Empty);
        }

        public void OnPost()
        {
            dsLH = XuLyLoaiHang.TimKiem(TuKhoa);
        }
    }
}
