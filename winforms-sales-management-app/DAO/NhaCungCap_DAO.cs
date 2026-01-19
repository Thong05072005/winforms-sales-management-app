using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnTheoMoHinh3Lop.DTO;
using System.Windows.Forms;
namespace DoAnTheoMoHinh3Lop.DAO
{
    internal class NhaCungCap_DAO : Database
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
        public DataTable Select_NhaCungCap()
        {
            DataTable dt = new DataTable();
            string strQuery = "select * from nhacungcap";
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            da.Fill(dt);
            return dt;
        }
        public bool insert_NhaCungCap(NhaCungCap_DTO NhaCungCap_DTO)
        {
            string strQuery = string.Format("INSERT INTO NhaCungCap (MaNCC, DiaChi, Phone, Email, TenSP) VALUES ('{0}',N'{1}','{2}','{3}',N'{4}')",
                NhaCungCap_DTO.MaNCC, NhaCungCap_DTO.DiaChi, NhaCungCap_DTO.Phone, NhaCungCap_DTO.Email, NhaCungCap_DTO.TenSP);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = strQuery;
            cm.Connection = conn;
            openConnection();
            //try
            //{
                int n = cm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công");
                    return true;
                }

            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi thêm nhà cung cấp");
            //}
            closeConnection();
            return false;
        }
        public bool update_NhaCungCap(NhaCungCap_DTO NhaCungCap_DTO)
        {
            string strQuery = string.Format("UPDATE NhaCungCap SET DiaChi ='{0}',Phone ='{1}', Email ='{2}',  TenSP ='{3}'   WHERE MaNCC ='{4}'",
              NhaCungCap_DTO.DiaChi, NhaCungCap_DTO.Phone, NhaCungCap_DTO.Email, NhaCungCap_DTO.TenSP, NhaCungCap_DTO.MaNCC);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = strQuery;
            cm.Connection = conn;
            openConnection();
            try
            {
                int n = cm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Sửa nhà cung cấp thành công");
                    return true;
                }

            }
            catch
            {
                MessageBox.Show("Lỗi sửa nhà cung cấp");
            }
            closeConnection();
            return false;
        }
        public bool delete_NhaCungCap(NhaCungCap_DTO NhaCungCap_DTO)
        {
            string strQuery = string.Format("DELETE FROM NhaCungCap WHERE MaNCC ='{0}'",
              NhaCungCap_DTO.MaNCC);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = strQuery;
            cm.Connection = conn;
            openConnection();
            try
            {
                int n = cm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                    return true;
                }

            }
            catch
            {
                MessageBox.Show("Lỗi xóa nhà cung cấp");
            }
            closeConnection();
            return false;
        }
        public DataTable search_NhaCungCap(NhaCungCap_DTO NhaCungCap_DTO)
        {
            DataTable dt = new DataTable();
            string strQuery = string.Format("select * from NhaCungCap WHERE MaNCC ='{0}'",
              NhaCungCap_DTO.MaNCC);
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            da.Fill(dt);
            return dt;
        }
    }
}
