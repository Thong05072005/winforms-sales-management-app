using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DoAnTheoMoHinh3Lop.DTO;
namespace DoAnTheoMoHinh3Lop.DAO
{
    internal class NhanVien_DAO:Database
    {
        public DataTable GetData_NV()
        {
            DataTable dt = new DataTable();
            string strQuery = "select*from nhanvien";
            this.dataAdapter=new SqlDataAdapter(strQuery, conn);
            dataAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetData_NVHD()
        {
            DataTable dt = new DataTable();
            string strQuery = "select*from nhanvien where trangthai=1";
            this.dataAdapter = new SqlDataAdapter(strQuery, conn);
            dataAdapter.Fill(dt);
            return dt;
        }
        public bool Insert_NV(NhanVien_DTO nv_DTO)
        {
            string strQuery = string.Format("exec dbo.proc_Them_nv '{0}',N'{1}','{2}',N'{3}',N'{4}','{5}',N'{6}',{7},'{8}',{9}",       
            nv_DTO.MaNV,nv_DTO.HoTenNV,nv_DTO.NamSinh,nv_DTO.GioiTinh,nv_DTO.DiaChi,nv_DTO.DienThoai,nv_DTO.GhiChu,nv_DTO.LoaiNV,nv_DTO.Email,nv_DTO.TrangThai);
            conn.Close();
            conn.Open();
            this.cmd = new SqlCommand(strQuery, conn);
            int n = cmd.ExecuteNonQuery();
            return n > 0;
        }
        public bool update_NhanVien(NhanVien_DTO nv_DTO)
        {
            string strQuery = string.Format("exec dbo.proc_sua_nv '{0}',N'{1}','{2}',N'{3}',N'{4}','{5}',N'{6}',{7},'{8}',{9}",
               nv_DTO.MaNV,nv_DTO.HoTenNV, nv_DTO.NamSinh, nv_DTO.GioiTinh, nv_DTO.DiaChi, nv_DTO.DienThoai, nv_DTO.GhiChu, nv_DTO.LoaiNV, nv_DTO.Email,nv_DTO.TrangThai);
            conn.Close();
            conn.Open();
            this.cmd = new SqlCommand(strQuery, conn);
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            conn.Close();
            return false;
        }
        public bool delete_NhanVien(NhanVien_DTO nv_DTO)
        {
            string strQuery = string.Format("exec dbo.proc_xoa_nv '{0}'",
                nv_DTO.MaNV);
            conn.Close();
            conn.Open();
            this.cmd = new SqlCommand(strQuery,conn);
            int n = this.cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            return false;
        }
    }
}
