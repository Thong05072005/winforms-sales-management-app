using DoAnTheoMoHinh3Lop.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DAO
{
    internal class CTHDB_DAO:Database
    {
        public DataTable select_CTHDB()
        {
            DataTable dt = new DataTable();
            string strQuery = "exec dbo.proc_hien_thi_cthdb";
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            da.Fill(dt);
            return dt;
        }
        public bool insert_CTHDB(CTHDB_DTO cthd_DTO,HoaDonBan_DTO hdb_DTO)
        {
            string strQuery = string.Format("exec dbo.proc_them_cthdb '{0}',{1},{2},'{3}','{4}',N'{5}','{6}'",
            cthd_DTO.MaSP,cthd_DTO.SoLuongBan,cthd_DTO.TongDonGiaBan,hdb_DTO.MaKH,
            hdb_DTO.NgayLapHD,hdb_DTO.GhiChu,hdb_DTO.MaNVB);
            conn.Close();
            conn.Open();
            this.cmd = new SqlCommand(strQuery,conn);       
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            conn.Close();
            return false;
        }
       
        public bool delete_CTHDB(CTHDB_DTO cthd_DTO)
        {
            string strQuery = string.Format("exec dbo.proc_xoa_cthdb '{0}',{1},{2}",
               cthd_DTO.MaSP, cthd_DTO.MaHDB, cthd_DTO.SoLuongBan);
            conn.Close();
            conn.Open();
            this.cmd = new SqlCommand(strQuery,conn);
            int n = this.cmd.ExecuteNonQuery();
            if (n > 0)
            {
                return true;
            }
            conn.Close();
            return false;
        }
    }
}
