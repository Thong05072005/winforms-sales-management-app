using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DTO
{
    internal class HoaDonBan_DTO
    {
        public int MaHDB {  get; set; }
        public string MaKH {  get; set; }
        public string NgayLapHD { get; set; }
        public float TongTienBan {  get; set; }
        public string GhiChu { get; set; }
        public string MaNVB { get; set; }
        public HoaDonBan_DTO() { 
            MaHDB = 0;
            MaKH = string.Empty;
            NgayLapHD = string.Empty;
            TongTienBan = 0;
            GhiChu = string.Empty;
            MaNVB = string.Empty;
        }
    }
}
