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
    internal class KhachHang_BUS
    {
        KhachHang_DAO kh_DAO = new KhachHang_DAO(); 
        public DataTable select_KH()
        {
            return kh_DAO.select_KhachHang();
        }
        public bool insert_KH(KhachHang_DTO kh_DTO)
        {
            return kh_DAO.insert_KhachHang(kh_DTO);
        }
        public bool update_KH(KhachHang_DTO kh_DTO)
        {
            return kh_DAO.update_KhachHang(kh_DTO);
        }
        public bool delete_KH(KhachHang_DTO kh_DTO)
        {
            return kh_DAO.delete_KhachHang(kh_DTO);
        }
    }
}
