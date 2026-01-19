using DoAnTheoMoHinh3Lop.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTheoMoHinh3Lop.DAO
{
    internal class CTHDN_DAO:Database
    {
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable select_CTHDN()
        {
            DataTable dt = new DataTable();
            string strQuery = "select* from cthdn";
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            da.Fill(dt);
            return dt;
        }
        public bool insert_CTHDN(CTHDN_DTO CTHDN_DTO)
        {
            string strQuery = string.Format("INSERT INTO CTHDN (MaSP, MaHDN, GiaNhap, TongTienNhap, SoLuongNhap) VALUES( N'{0}','{1}',N'{2}',N'{3}','{4}')",
                CTHDN_DTO.MaSP, CTHDN_DTO.MaHDN, CTHDN_DTO.GiaNhap, CTHDN_DTO.TongTienNhap, CTHDN_DTO.SoLuongNhap);
                this.cmd = new SqlCommand(strQuery,conn);
            
       
                openConnection();
                int n = this.cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }

            
            closeConnection();
            return false;
        }
        public bool delete_CTHDN(CTHDN_DTO CTHDN_DTO)
        {
            string strQuery = string.Format("DELETE FROM CTHDN WHERE MaHDN ='{0}'",
            CTHDN_DTO.MaHDN);
            conn.Close();
            conn.Open();
           this.cmd = new SqlCommand(strQuery,conn);
           
            try
            {
                openConnection();
                int n = this.cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }

            }
            catch
            {
                MessageBox.Show("Lỗi xóa chi tiết hóa đơn nhập");
            }
            closeConnection();
            return false;
        }
        public DataTable search_CTHDN(CTHDN_DTO CTHDN_DTO)
        {
            DataTable dt = new DataTable();
            string strQuery = string.Format("select*from cthdn where mahdn='{0}'",
            CTHDN_DTO.MaHDN);
            this.dataAdapter= new SqlDataAdapter(strQuery, conn);
            dataAdapter.Fill(dt);
            return dt;
        }

    }
}
