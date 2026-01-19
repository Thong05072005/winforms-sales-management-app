using DoAnTheoMoHinh3Lop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DAO
{
    internal class SanPham_DAO:Database
    {
        public DataTable getData_SanPham()
        {
            DataTable dt = new DataTable();
            string strQuery = "select*from sanpham";
            this.dataAdapter = new SqlDataAdapter(strQuery, conn);
            dataAdapter.Fill(dt);
            return dt;
        }
        public bool insert_SanPham(SanPham_DTO sp_DTO)
        {
            string strQuery = string.Format("exec dbo.proc_Them_sp '{0}',N'{1}',{2},{3},'{4}'",
                sp_DTO.MaSP,sp_DTO.TenSP, sp_DTO.GiaSP, sp_DTO.SoLuongCon, sp_DTO.Anh);
            conn.Close();
            conn.Open();
            cmd =  new SqlCommand(strQuery,conn);
           
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            conn.Close();
            return false;
        }
        public bool update_SanPham(SanPham_DTO sp_DTO)
        {
            string strQuery = string.Format("exec dbo.proc_sua_sp '{0}',N'{1}',{2},{3},'{4}'",
                sp_DTO.MaSP, sp_DTO.TenSP, sp_DTO.GiaSP, sp_DTO.SoLuongCon, sp_DTO.Anh);
            conn.Close();
            conn.Open();
            cmd = new SqlCommand(strQuery,conn);
            
           
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                
                return true;
            }
            conn.Close ();
            return false;
        }
        public bool delete_SanPham(SanPham_DTO sp_DTO)
        {
            string strQuery = string.Format("exec dbo.proc_xoa_sp '{0}'",
                sp_DTO.MaSP);
            conn.Close();
            conn.Open();
            cmd =  new SqlCommand(strQuery,conn);
           
            
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            conn.Close();
            return false;
        }
    }
}
