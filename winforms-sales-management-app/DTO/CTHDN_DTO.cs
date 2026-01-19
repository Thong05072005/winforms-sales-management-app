using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DTO
{
    internal class CTHDN_DTO
    {
        public string MaSP { get; set; }
        public int MaHDN { get; set; }
        public float GiaNhap { get; set; }
        public float TongTienNhap { get; set; }
        public int SoLuongNhap { get; set; }
        public CTHDN_DTO()
        {
            MaSP = string.Empty;
            MaHDN = 0;
            GiaNhap = 0;
            TongTienNhap = 0;
            SoLuongNhap = 0;

        }
    }
}
