using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DTO
{
    internal class KhachHang_DTO
    {
        public string MaKH {  get; set; }   
        public string HoTenKH { get; set; }
        public string NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public KhachHang_DTO() { 
            MaKH = string.Empty;
            HoTenKH = string.Empty;
            NamSinh = string.Empty;
            GioiTinh = string.Empty;
            DiaChi = string.Empty;
            DienThoai = string.Empty;
            Email = string.Empty;
        }
    }
}
