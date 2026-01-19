using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DAO
{
    internal class Database
    {
        static private string strConn = "Data Source=PHUONG_NGUYEN\\SQLEXPRESS;Initial Catalog=DoAnQLBanLaptop;Integrated Security=True;";
        public SqlConnection conn=new SqlConnection(strConn);
        protected SqlDataAdapter dataAdapter;
        protected SqlCommand cmd;
        public DataTable LoadData(string strQuery)
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(strConn);
            dataAdapter=new SqlDataAdapter(strQuery,conn);   
            dataAdapter.Fill(dt);
            return dt;
        }
        
        public Double getGiaTien(string strQuery)
        {
            conn.Close();
            conn.Open();
            double giaTien = 0;
            this.cmd=new SqlCommand(strQuery,conn);
            giaTien=(double)this.cmd.ExecuteScalar();
            return giaTien;     
        }
        public string getTenNV(string strQuery) {
            conn.Close();
            conn.Open();
            string tenNV = "";
            this.cmd= new SqlCommand(strQuery,conn);
            tenNV = (string)cmd.ExecuteScalar();
            return tenNV;
        }
        public SqlDataReader getThongTin(string strQuery)
        {
            conn.Close();
            conn.Open();
            this.cmd=new SqlCommand(strQuery,conn);
            SqlDataReader reader = this.cmd.ExecuteReader();
            return reader;
        }
        public string getmaxHDN()
        {
            Database da = new Database();
            DataTable a = da.LoadData("select max(mahdn) from HoaDonNhap");
            int max = 0;
            if (a.Rows.Count < 1 || a.Rows[0][0] == DBNull.Value)
            {
                max = 1;
            }
            else
            {
                max = int.Parse(a.Rows[0][0].ToString());
                max += 1;
            }

            return max.ToString();
        }
        public int kiemTraTonTai(string strQuery)
        {
            conn.Close();
            conn.Open();
            this.cmd = new SqlCommand(strQuery, conn);
            int n = (int)this.cmd.ExecuteScalar();
            return n;
        }
    }
}
