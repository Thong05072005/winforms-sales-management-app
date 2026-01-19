using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnTheoMoHinh3Lop.DAO;
using DoAnTheoMoHinh3Lop.DTO;


namespace DoAnTheoMoHinh3Lop.BUS
{
    internal class NhaCungCap_BUS
    {
        NhaCungCap_DAO NhaCungCap_DAO = new NhaCungCap_DAO();
        public DataTable select_NhaCungCap()
        {
            return NhaCungCap_DAO.Select_NhaCungCap();
        }
        public bool insert_NhaCungCap(NhaCungCap_DTO NhaCungCap_DTO)
        {
            return NhaCungCap_DAO.insert_NhaCungCap(NhaCungCap_DTO);
        }
        public bool update_NhaCungCap(NhaCungCap_DTO NhaCungCap_DTO)
        {
            return NhaCungCap_DAO.update_NhaCungCap(NhaCungCap_DTO);
        }
        public bool delete_NhaCungCap(NhaCungCap_DTO NhaCungCap_DTO)
        {
            return NhaCungCap_DAO.delete_NhaCungCap(NhaCungCap_DTO);
        }
        public DataTable search_NhaCungCap(NhaCungCap_DTO NhaCungCap_DTO)
        {
            return NhaCungCap_DAO.search_NhaCungCap(NhaCungCap_DTO);
        }
    }
}
