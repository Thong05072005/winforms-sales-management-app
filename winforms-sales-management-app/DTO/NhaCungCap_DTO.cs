using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DTO
{
    internal class NhaCungCap_DTO
    {
        public string MaNCC { get; set; }
        public string DiaChi { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TenSP { get; set; }
        public NhaCungCap_DTO()
        {
            MaNCC = "";
            DiaChi = "";
            Phone = "";
            Email = "";
            TenSP = "";
        }
    }
}
