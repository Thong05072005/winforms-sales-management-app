using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DTO
{
    internal class SanPham_DTO
    {
       public string MaSP {  get; set; }
        public string TenSP { get; set; }
        public float GiaSP { get; set; }
        public int SoLuongCon {  get; set; }
        public string Anh {  get; set; }
        public SanPham_DTO() { 
            MaSP = string.Empty;
            TenSP = string.Empty;
            GiaSP = 0;
            SoLuongCon = 0;
            Anh = string.Empty;
        }
    }

}
