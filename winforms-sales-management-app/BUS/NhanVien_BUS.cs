using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnTheoMoHinh3Lop.DTO;
using DoAnTheoMoHinh3Lop.DAO;
using System.Data;
namespace DoAnTheoMoHinh3Lop.BUS
{
    internal class NhanVien_BUS
    {
        NhanVien_DAO nv_DAO = new NhanVien_DAO();
        public DataTable HienTTNV()
        {
            return nv_DAO.GetData_NV();
        }
        public DataTable HienTTNVHD()
        {
            return nv_DAO.GetData_NVHD();
        }
        public bool Insert_NV(NhanVien_DTO nv_DTO)
        {
            return nv_DAO.Insert_NV(nv_DTO);
        }
        public bool Update_NV(NhanVien_DTO nv_DTO)
        {
            return nv_DAO.update_NhanVien(nv_DTO);
        }
        public bool Delete_NV(NhanVien_DTO nv_DTO)
        {
            return nv_DAO.delete_NhanVien(nv_DTO);
        }
    }
}
