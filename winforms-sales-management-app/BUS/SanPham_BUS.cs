using DoAnTheoMoHinh3Lop.DAO;
using DoAnTheoMoHinh3Lop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.BUS
{
    internal class SanPham_BUS
    {
        SanPham_DAO sp_DAO = new SanPham_DAO();
        public DataTable hienTTSP()
        {
            return sp_DAO.getData_SanPham();
        }
        public bool insert_SP(SanPham_DTO sp_DTO)
        {
            return sp_DAO.insert_SanPham(sp_DTO);
        }
        public bool update_SP(SanPham_DTO sp_DTO)
        {
            return sp_DAO.update_SanPham(sp_DTO);
        }
        public bool delete_SP(SanPham_DTO sp_DTO)
        {
            return sp_DAO.delete_SanPham(sp_DTO);
        }
        public int kiemTraSP(string ten)
        {
            return sp_DAO.kiemTraTonTai(ten);
        }
    }
}
