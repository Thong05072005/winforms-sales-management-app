using DoAnTheoMoHinh3Lop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAnTheoMoHinh3Lop.GUI
{
    public partial class DoanhThucs : Form
    {
        Database Database = new Database();
        public DoanhThucs()
        {
            InitializeComponent();
        }

        private void DoanhThucs_Load(object sender, EventArgs e)
        {

        }
        public DataTable TongTienNhap_Year()
        {
            string query = @"
                SELECT Sum(tongtiennhap) FROM HoaDonNhap WHERE NgayLapHD BETWEEN DATEADD(DAY, -365, GETDATE()) AND GETDATE()";
            DataTable dt = new DataTable();
            dt = Database.LoadData(query);
            return dt;
        }
        public DataTable TongTienNhap_Month()
        {
            string query = @"
                SELECT Sum(tongtiennhap) FROM HoaDonNhap WHERE NgayLapHD BETWEEN DATEADD(DAY, -30, GETDATE()) AND GETDATE()";
            DataTable dt = new DataTable();
            dt = Database.LoadData(query);
            return dt;
        }
        public DataTable TongTienNhap_Week()
        {
            string query = @"
                SELECT Sum(tongtiennhap) FROM HoaDonNhap WHERE NgayLapHD BETWEEN DATEADD(DAY, -7, GETDATE()) AND GETDATE()";
            DataTable dt = new DataTable();
            dt = Database.LoadData(query);
            return dt;
        }
        public DataTable TongTienBan_Year()
        {
            string query = @"
                SELECT Sum(tongtienban) FROM HoaDonBan WHERE NgLapHD BETWEEN DATEADD(DAY, -365, GETDATE()) AND GETDATE()";
            DataTable dt = new DataTable();
            dt = Database.LoadData(query);
            return dt;
        }
        public DataTable TongTienBan_Month()
        {
            string query = @"
                SELECT Sum(tongtienban) FROM HoaDonBan WHERE NgLapHD BETWEEN DATEADD(DAY, -30, GETDATE()) AND GETDATE()";
            DataTable dt = new DataTable();
            dt = Database.LoadData(query);
            return dt;
        }
        public DataTable TongTienBan_Week()
        {
            string query = @"
                SELECT Sum(tongtienban) FROM HoaDonBan WHERE NgLapHD BETWEEN DATEADD(DAY, -7, GETDATE()) AND GETDATE()";
            DataTable dt = new DataTable();
            dt = Database.LoadData(query);
            return dt;
        }
        public void DoanhThuNam()
        {
            int a = 0;
            int b = 0;
            if (TongTienNhap_Year().Rows[0][0] != DBNull.Value)
            {
                a = int.Parse(TongTienNhap_Year().Rows[0][0].ToString());
            }
            if (TongTienBan_Year().Rows[0][0] != DBNull.Value)
            {
                b = int.Parse(TongTienBan_Year().Rows[0][0].ToString());
            }
            int s = b - a;
            dgv_DoanhThu.Rows.Add(a, b, s);
        }
        public void DoanhThuThang()
        {
            int a = 0;
            int b = 0;
            if (TongTienNhap_Month().Rows[0][0] != DBNull.Value)
            {
                a = int.Parse(TongTienNhap_Month().Rows[0][0].ToString());
            }
            if (TongTienBan_Month().Rows[0][0] != DBNull.Value)
            {
                b = int.Parse(TongTienBan_Month().Rows[0][0].ToString());
            }
            int s = b - a;
            dgv_DoanhThu.Rows.Add(a, b, s);
        }
        public void DoanhThuTuan()
        {
            int a = 0;
            int b = 0;
            if (TongTienNhap_Week().Rows[0][0] != DBNull.Value)
            {
                a = int.Parse(TongTienNhap_Week().Rows[0][0].ToString());
            }
            if (TongTienBan_Week().Rows[0][0] != DBNull.Value)
            {
                b = int.Parse(TongTienBan_Week().Rows[0][0].ToString());
            }
            int s = b - a;
            dgv_DoanhThu.Rows.Add(a, b, s);
        }
        private void rdb_DoanhThuNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_DoanhThuNam.Checked == true)
                DoanhThuNam();
            else
            {
                dgv_DoanhThu.Rows.Clear();
            }
        }

        private void rdb_DoanhThuThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_DoanhThuThang.Checked == true)
            {
                DoanhThuThang();
            }
            else
            {
                dgv_DoanhThu.Rows.Clear();
            }
        }

        private void rdb_DoanhThuTuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_DoanhThuThang.Checked == true)
            {
                DoanhThuTuan();
            }
            else
            {
                dgv_DoanhThu.Rows.Clear();
            }
        }
    }
}
