using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DTO
{
    internal class TaiKhoan
    {
        public string tenTk {  get; set; }
        public string matkhau {  get; set; }
        public TaiKhoan()
        {
            this.tenTk= string.Empty;
            this.matkhau= string.Empty;
        }
    }
}
