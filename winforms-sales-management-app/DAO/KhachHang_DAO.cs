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
    internal class KhachHang_DAO : Database
    {
        public DataTable select_KhachHang()
        {
            DataTable dt = new DataTable();
            string strQuery = "select*from khachhang";
            this.dataAdapter = new SqlDataAdapter(strQuery, conn);
            dataAdapter.Fill(dt);
            return dt;
        }
        public bool insert_KhachHang(KhachHang_DTO KH_DTO)
        {
            string strQuery = string.Format("exec dbo.proc_Them_kh '{0}',N'{1}','{2}',N'{3}',N'{4}','{5}','{6}'",
                KH_DTO.MaKH,KH_DTO.HoTenKH,KH_DTO.NamSinh,KH_DTO.GioiTinh,KH_DTO.DiaChi,KH_DTO.DienThoai,KH_DTO.Email);
            conn.Close();
            conn.Open();
            this.cmd= new SqlCommand(strQuery,conn);
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            conn.Close();
            return false;
        }
        public bool update_KhachHang(KhachHang_DTO KH_DTO)
        {
            string strQuery = string.Format("exec dbo.proc_sua_kh '{0}',N'{1}','{2}',N'{3}',N'{4}','{5}','{6}'",
                KH_DTO.MaKH,KH_DTO.HoTenKH, KH_DTO.NamSinh, KH_DTO.GioiTinh, KH_DTO.DiaChi, KH_DTO.DienThoai,KH_DTO.Email);
            conn.Close();
            conn.Open();
            this.cmd = new SqlCommand(strQuery, conn);
            int n = cmd.ExecuteNonQuery();
            
            if (n > 0)
            {
                return true;
            }
            return false;
        }
        public bool delete_KhachHang(KhachHang_DTO KH_DTO)
        {
            string strQuery = string.Format("exec dbo.proc_xoa_kh '{0}'",
                KH_DTO.MaKH);
            conn.Close();
            conn.Open();
            this.cmd = new SqlCommand(strQuery, conn);   
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            return false;
        }
    }
}
