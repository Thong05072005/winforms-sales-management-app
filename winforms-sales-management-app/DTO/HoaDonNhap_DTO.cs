using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DTO
{
    internal class HoaDonNhap_DTO
    {
        public int MaHDN { get; set; }
        public string MaNCC { get; set; }
        public string MaNVN { get; set; }
        public string NgayLapHD { get; set; }
        public float TongTienNhap { get; set; }
        public string GhiChu { get; set; }
        public HoaDonNhap_DTO()
        {
            MaHDN = 0;
            MaNCC = "";
            MaNVN = "";
            NgayLapHD = "";
            TongTienNhap = 0;
            GhiChu = "";
        }
    }
}
