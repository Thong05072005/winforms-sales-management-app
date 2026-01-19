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
    internal class HoaDonNhap_BUS
    {
        HoaDonNhap_DAO HoaDonNhap_DAO = new HoaDonNhap_DAO();
        public DataTable select_HoaDonNhap()
        {
            return HoaDonNhap_DAO.select_HoaDonNhap();
        }
        public bool insert_HoaDonNhap(HoaDonNhap_DTO HoaDonNhap_DTO)
        {
            return HoaDonNhap_DAO.insert_HoaDonNhap(HoaDonNhap_DTO);
        }
        public bool delete_HoaDonNhap(HoaDonNhap_DTO HoaDonNhap_DTO)
        {
            return HoaDonNhap_DAO.delete_HoaDonNhap(HoaDonNhap_DTO);
        }
        public DataTable search_HoaDonNhap(HoaDonNhap_DTO HoaDonNhap_DTO)
        {
            return HoaDonNhap_DAO.search_HoaDonNhap(HoaDonNhap_DTO);
        }
    }
}
