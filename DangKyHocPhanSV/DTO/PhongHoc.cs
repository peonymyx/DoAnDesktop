using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangKyHocPhanSV.DTO
{
    public class PhongHoc
    {
        public string MaLopHoc { get; set; }
        public string TenLopHoc { get; set;}
        public string MaMHDT { get; set; }
        public string MaGV { get; set; }
        public int GioiHan { get; set; }
        public string TenPhong { get; set; }
        public string Thu { get; set; }
        public int TietBatDau { get; set; }
        public int TietKetThuc { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public string HocKy { get; set; }
        public int Nam { get; set; }
    }
}
