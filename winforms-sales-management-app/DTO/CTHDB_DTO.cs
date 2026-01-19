using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DTO
{
    internal class CTHDB_DTO
    {
        public string MaSP { get; set; }
        public int MaHDB { get; set; }
        public int SoLuongBan { get; set; }
        public float TongDonGiaBan { get; set; }
        public CTHDB_DTO() { 
            MaSP = string.Empty;
            MaHDB = 0;
            SoLuongBan = 0;
            TongDonGiaBan = 0;
        }
    }
}
