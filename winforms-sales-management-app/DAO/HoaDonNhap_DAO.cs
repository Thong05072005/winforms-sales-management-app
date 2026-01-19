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
    internal class HoaDonNhap_DAO:Database
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
        public DataTable select_HoaDonNhap()
        {
            DataTable dt = new DataTable();
            string strQuery = "select * from hoadonnhap";
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            da.Fill(dt);
            return dt;
        }
        public bool insert_HoaDonNhap(HoaDonNhap_DTO HoaDonNhap_DTO)
        {
            string strQuery = string.Format("INSERT INTO HoaDonNhap (MaHDN, MaNCC, MaNVN, NgayLapHD, TongTienNhap, GhiChu) VALUES ('{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}')",
                HoaDonNhap_DTO.MaHDN, HoaDonNhap_DTO.MaNCC, HoaDonNhap_DTO.MaNVN, HoaDonNhap_DTO.NgayLapHD, HoaDonNhap_DTO.TongTienNhap, HoaDonNhap_DTO.GhiChu);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = strQuery;
            cm.Connection = conn;
            try
            {
                openConnection();
                int n = cm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Thêm hóa đơn nhập thành công");
                    return true;
                }

            }
            catch
            {
                MessageBox.Show("Lỗi thêm hóa đơn nhập");
            }
            return false;
        }
        public bool delete_HoaDonNhap(HoaDonNhap_DTO HoaDonNhap_DTO)
        {
            string strQuery = string.Format("DELETE FROM HoaDonNhap WHERE MaHDN=N'{0}'",
                HoaDonNhap_DTO.MaHDN);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = strQuery;
            cm.Connection = conn;
            try
            {
                openConnection();
                int n = cm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Xóa hóa đơn nhập thành công");
                    return true;
                }

            }
            catch
            {
                MessageBox.Show("Lỗi xóa hóa đơn nhập");
            }
            return false;
        }
        public DataTable search_HoaDonNhap(HoaDonNhap_DTO HoaDonNhap_DTO)
        {
            DataTable dt = new DataTable();
            string strQuery = string.Format("select* from HoaDonNhap WHERE MaHDN=N'{0}'",
                 HoaDonNhap_DTO.MaHDN);
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            da.Fill(dt);
            return dt;
        }

    }
}
