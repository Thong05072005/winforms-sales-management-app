using DoAnTheoMoHinh3Lop.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoAnTheoMoHinh3Lop.BUS
{
    internal class TaiKhoan_BUS
    {
        TaiKhoan_DAO tk_dao=new TaiKhoan_DAO();
        public int KiemTraTK(string tentk, string matkhau, int loai)
        {
            return tk_dao.KiemTraTaiKhoan(tentk, matkhau, loai);
        }
    }
}
