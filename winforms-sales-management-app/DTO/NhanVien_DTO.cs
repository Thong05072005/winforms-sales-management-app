using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DTO
{
    internal class NhanVien_DTO
    {
        public string MaNV { get; set; }
        public string HoTenNV { get; set; }
        public string NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string GhiChu { get; set; }
        public int LoaiNV { get; set; }
        public string Email { get; set; }
        public int TrangThai { get; set; }
        public string tenTK { get; set; }
        public string matKhau { get; set; } 
        public NhanVien_DTO()
        {
            MaNV = string.Empty;
            HoTenNV = string.Empty;
            NamSinh = string.Empty;
            GioiTinh = string.Empty;
            DiaChi = string.Empty;
            DienThoai = string.Empty;
            GhiChu = string.Empty;
            LoaiNV = 0;
            Email = string.Empty;
            TrangThai = 0;
            this.tenTK = string.Empty;
            this.matKhau = string.Empty;
        }
    }
}
    
