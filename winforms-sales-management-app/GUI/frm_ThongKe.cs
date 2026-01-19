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
    public partial class frm_ThongKe : Form
    {
        Database Database=new Database();
        public frm_ThongKe()
        {
            InitializeComponent();
        }

        private void rdb_LoiNhuan_CheckedChanged(object sender, EventArgs e)
        {
            DateTime dt = dtp_NgayThangNam.Value.Date;
            int day = dtp_NgayThangNam.Value.Day;
            int year = dtp_NgayThangNam.Value.Year;
            int month = dtp_NgayThangNam.Value.Month;
            string dateString = dt.ToString("yyyy-MM-dd");

          

            if (rdb_LoiNhuan.Checked == true)
            {
                if (!string.IsNullOrEmpty(cbb_LoiNhuan.Text))
                {
                    if (cbb_LoiNhuan.SelectedIndex == 0)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("Tổng tiền nhập ngày " + day+'/'+month+'/'+year);
                        dataTable.Columns.Add("Tổng tiền bán ngày " +day + '/' + month + '/' + year);
                        dataTable.Columns.Add("Lợi nhuận ngày " + day + '/' + month + '/' + year);


                        string strTongTienNhap = $@"SELECT SUM(TongTienNhap)
                            FROM HoaDonNhap
                            WHERE CAST(NgayLapHD AS DATE) = '{dateString}'";

                        string strTongTienBan = $@"SELECT SUM(TongTienBan)
                            FROM HoaDonBan
                            WHERE CAST(NgLapHD AS DATE) = '{dateString}'";

                        float TongTienNhap = 0;
                        float TongTienBan = 0;

                        DataTable dtNhap = Database.LoadData(strTongTienNhap);
                        if (dtNhap.Rows.Count > 0 && dtNhap.Rows[0][0] != DBNull.Value)
                        {
                            TongTienNhap = float.Parse(dtNhap.Rows[0][0].ToString());
                        }

                        DataTable dtBan = Database.LoadData(strTongTienBan);
                        if (dtBan.Rows.Count > 0 && dtBan.Rows[0][0] != DBNull.Value)
                        {
                            TongTienBan = float.Parse(dtBan.Rows[0][0].ToString());
                        }

                        float LoiNhuan = TongTienBan - TongTienNhap;

                        dataTable.Rows.Add(
                                        TongTienNhap.ToString("N0"),
                                        TongTienBan.ToString("N0"),
                                        LoiNhuan.ToString("N0"));

                        dgv_DaTa.DataSource = dataTable;
                    }

                    /*--------------------------------------------------------------*/
                    if (cbb_LoiNhuan.SelectedIndex == 1)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("Tổng tiền nhập tháng " + dt.Month.ToString() + " năm " + dt.Year.ToString());
                        dataTable.Columns.Add("Tổng tiền bán tháng " + dt.Month.ToString() + " năm " + dt.Year.ToString());
                        dataTable.Columns.Add("Lợi nhuận tháng " + dt.Month.ToString() + " năm " + dt.Year.ToString());

                        string strTongTienNhap = $@"SELECT SUM(TongTienNhap)
                                            FROM HoaDonNhap
                                            WHERE YEAR(NgayLapHD) = {year} 
                                              AND MONTH(NgayLapHD) = {month}";

                        string strTongTienBan = $@"SELECT SUM(TongTienBan)
                                          FROM HoaDonBan
                                          WHERE YEAR(NgLapHD) = {year} 
                                            AND MONTH(NgLapHD) = {month}";

                        float TongTienNhap = 0;
                        float TongTienBan = 0;

                        DataTable dtNhap = Database.LoadData(strTongTienNhap);
                        if (dtNhap.Rows.Count > 0 && dtNhap.Rows[0][0] != DBNull.Value)
                        {
                            TongTienNhap = float.Parse(dtNhap.Rows[0][0].ToString());
                        }

                        DataTable dtBan = Database.LoadData(strTongTienBan);
                        if (dtBan.Rows.Count > 0 && dtBan.Rows[0][0] != DBNull.Value)
                        {
                            TongTienBan = float.Parse(dtBan.Rows[0][0].ToString());
                        }

                        float LoiNhuan = TongTienBan - TongTienNhap;

                        dataTable.Rows.Add(
                                        TongTienNhap.ToString("N0"),
                                        TongTienBan.ToString("N0"),
                                        LoiNhuan.ToString("N0"));
                        dgv_DaTa.DataSource = dataTable;
                    }
                    /*--------------------------------------------------------------*/
                    if (cbb_LoiNhuan.SelectedIndex == 2)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("Tổng tiền nhập năm " + dt.Year.ToString());
                        dataTable.Columns.Add("Tổng tiền bán năm " + dt.Year.ToString());
                        dataTable.Columns.Add("Lợi nhuận năm " + dt.Year.ToString());

                        string strTongTienNhap = $@"SELECT SUM(TongTienNhap)
                                            FROM HoaDonNhap
                                            WHERE YEAR(NgayLapHD) = {year} ";


                        string strTongTienBan = $@"SELECT SUM(TongTienBan)
                                          FROM HoaDonBan
                                          WHERE YEAR(NgLapHD) = {year} ";
                        float TongTienNhap = 0;
                        float TongTienBan = 0;

                        DataTable dtNhap = Database.LoadData(strTongTienNhap);
                        if (dtNhap.Rows.Count > 0 && dtNhap.Rows[0][0] != DBNull.Value)
                        {
                            TongTienNhap = float.Parse(dtNhap.Rows[0][0].ToString());
                        }

                        DataTable dtBan = Database.LoadData(strTongTienBan);
                        if (dtBan.Rows.Count > 0 && dtBan.Rows[0][0] != DBNull.Value)
                        {
                            TongTienBan = float.Parse(dtBan.Rows[0][0].ToString());
                        }

                        float LoiNhuan = TongTienBan - TongTienNhap;

                        dataTable.Rows.Add(
                                       TongTienNhap.ToString("N0"),
                                       TongTienBan.ToString("N0"),
                                       LoiNhuan.ToString("N0"));
                        dgv_DaTa.DataSource = dataTable;
                    }
                    /*--------------------------------------------------------------*/
                    if (cbb_LoiNhuan.SelectedIndex == 3)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("Mã sản phẩm");
                        dataTable.Columns.Add("Tên sản phẩm");
                        dataTable.Columns.Add("Tổng số lượng bán");
                        dataTable.Columns.Add("Tổng tiền bán");
                        dataTable.Columns.Add("Tổng số lượng nhập");
                        dataTable.Columns.Add("Tổng tiền nhập");
                        dataTable.Columns.Add("Lợi nhuận");

                        string strLoiNhuanSP = $@"
                    SELECT 
                        sp.masp,
                        sp.tensp,
                        ISNULL(SUM(cthd.SoLuongBan), 0) AS TongSoLuongBan,
                        ISNULL(SUM(hdb.TongTienBan), 0) AS TongTienBan,
                        ISNULL(SUM(cthn.SoLuongNhap), 0) AS TongSoLuongNhap,
                        ISNULL(SUM(hdn.TongTienNhap), 0) AS TongTienNhap,
                        (ISNULL(SUM(hdb.TongTienBan), 0) - ISNULL(SUM(hdn.TongTienNhap), 0)) AS LoiNhuan
                    FROM 
                        sanpham sp
                    LEFT JOIN 
                        CTHDB cthd ON sp.masp = cthd.MaSP
                    LEFT JOIN 
                        HoaDonBan hdb ON cthd.MaHDB = hdb.MaHDB AND MONTH(hdb.NgLapHD) = {month} AND YEAR(hdb.NgLapHD) = {year}
                    LEFT JOIN 
                        CTHDN cthn ON sp.masp = cthn.MaSP
                    LEFT JOIN 
                        HoaDonNhap hdn ON cthn.MaHDN = hdn.MaHDN AND MONTH(hdn.NgayLapHD) = {month} AND YEAR(hdn.NgayLapHD) = {year}
                    GROUP BY 
                        sp.masp, sp.tensp";

                        DataTable data = Database.LoadData(strLoiNhuanSP);

                        if (data.Rows.Count > 0)
                        {
                            foreach (DataRow row in data.Rows)
                            {
                                dataTable.Rows.Add(
                                    row["masp"].ToString(),
                                    row["tensp"].ToString(),
                                    row["TongSoLuongBan"].ToString(),
                                    row["TongTienBan"].ToString(),
                                    row["TongSoLuongNhap"].ToString(),
                                    row["TongTienNhap"].ToString(),
                                    row["LoiNhuan"].ToString());
                            }
                            dgv_DaTa.DataSource = dataTable;
                        }
                    }
                }
            }
        }

        private void rdb_KhachHang_CheckedChanged(object sender, EventArgs e)
        {
            DateTime dt = dtp_NgayThangNam.Value.Date;
            int day = dtp_NgayThangNam.Value.Day;
            int year = dtp_NgayThangNam.Value.Year;
            int month = dtp_NgayThangNam.Value.Month;
            string dateString = dt.ToString("yyyy-MM-dd");
            if (rdb_KhachHang.Checked == true)
            {
                if (!string.IsNullOrEmpty(cbb_KhachHang.Text))
                {
                    if (cbb_KhachHang.SelectedIndex == 0)
                    {
                        string query = $@"
                        SELECT DISTINCT kh.MaKH, kh.HoTenKH, kh.NamSinh,kh.GioiTinh,kh.DiaChi, kh.DienThoai,kh.email,hdb.NgLapHD
                        FROM HoaDonBan hdb
                        JOIN KhachHang kh ON hdb.MaKH = kh.MaKH
                        WHERE CAST(hdb.NgLapHD AS DATE) ='{dateString}'";
                        DataTable datatbale = Database.LoadData(query);
                        dgv_DaTa.DataSource = datatbale;

                    }
                    /*--------------------------------------------------------------*/
                    if (cbb_KhachHang.SelectedIndex == 1)
                    {
                        string query = $@"
                        SELECT DISTINCT kh.MaKH, kh.HoTenKH, kh.NamSinh,kh.GioiTinh,kh.DiaChi, kh.DienThoai,kh.email,hdb.NgLapHD
                        FROM HoaDonBan hdb
                        JOIN KhachHang kh ON hdb.MaKH = kh.MaKH
                        WHERE YEAR(hdb.NgLapHD) = {year} AND MONTH(hdb.NgLapHD) = {month}";
                        DataTable datatbale = Database.LoadData(query);
                        dgv_DaTa.DataSource = datatbale;

                    }
                    /*--------------------------------------------------------------*/
                    if (cbb_KhachHang.SelectedIndex == 2)
                    {
                        string query = $@"
                        SELECT DISTINCT kh.MaKH, kh.HoTenKH, kh.NamSinh,kh.GioiTinh,kh.DiaChi, kh.DienThoai,hdb.NgLapHD
                        FROM HoaDonBan hdb
                        JOIN KhachHang kh ON hdb.MaKH = kh.MaKH
                        WHERE YEAR(hdb.NgLapHD) = {year}";
                        DataTable datatbale = Database.LoadData(query);
                        dgv_DaTa.DataSource = datatbale;
                    }
                    /*--------------------------------------------------------------*/
                    if (cbb_KhachHang.SelectedIndex == 3)
                    {
                        string query = $@"SELECT TOP 1 WITH TIES 
                                        kh.MaKH, kh.HoTenKH, kh.NamSinh,kh.GioiTinh,kh.DiaChi, kh.DienThoai,kh.email,hdb.NgLapHD,SUM(hdb.TongTienBan) AS TongTienMua
                                        FROM HoaDonBan hdb
                                        JOIN KhachHang kh ON hdb.MaKH = kh.MaKH
                                        WHERE MONTH(hdb.NgLapHD) ={month}
                                        AND YEAR(hdb.NgLapHD) = {year}
                                        GROUP BY kh.MaKH, kh.HoTenKH, kh.DiaChi, kh.DienThoai,kh.NamSinh,kh.GioiTinh,kh.email,hdb.NgLapHD
                                        ORDER BY TongTienMua DESC";
                        DataTable datatbale = Database.LoadData(query);
                        dgv_DaTa.DataSource = datatbale;
                    }
                    if (cbb_KhachHang.SelectedIndex == 4)
                    {
                        string query = $@"SELECT 
                                          RANK() OVER (ORDER BY SUM(hdb.TongTienBan) DESC) AS [Top],
                                          kh.MaKH, kh.HoTenKH, kh.NamSinh,kh.GioiTinh,kh.DiaChi, kh.DienThoai,kh.email,hdb.NgLapHD,SUM(hdb.TongTienBan) AS TongTienMua
                                          FROM HoaDonBan hdb
                                          JOIN KhachHang kh ON hdb.MaKH = kh.MaKH
                                          WHERE MONTH(hdb.NgLapHD) = MONTH(GETDATE()) 
                                          AND YEAR(hdb.NgLapHD) = YEAR(GETDATE())
                                          GROUP BY kh.MaKH, kh.HoTenKH, kh.DiaChi, kh.DienThoai,kh.email,kh.NamSinh,kh.GioiTinh,hdb.NgLapHD
                                          ORDER BY [Top]";
                        DataTable datatbale = Database.LoadData(query);
                        dgv_DaTa.DataSource = datatbale;
                    }
                }
            }
        }

        private void rdb_SanPham_CheckedChanged(object sender, EventArgs e)
        {
            DateTime dt = dtp_NgayThangNam.Value.Date;
            int day = dtp_NgayThangNam.Value.Day;
            int year = dtp_NgayThangNam.Value.Year;
            int month = dtp_NgayThangNam.Value.Month;
            string dateString = dt.ToString("yyyy-MM-dd");
            if (rdb_SanPham.Checked == true)
            {
                if (!string.IsNullOrEmpty(cbb_SanPham.Text))
                {
                    if (cbb_SanPham.SelectedIndex == 0)
                    {
                        string query = $@"
                        SELECT TOP 1 WITH TIES
                        sp.masp,
                        sp.tensp,
                        SUM(ct.SoLuongBan) AS TongSoLuongBan
                        FROM CTHDB ct
                        JOIN HoaDonBan hdb ON ct.MaHDB = hdb.MaHDB
                        JOIN sanpham sp ON ct.MaSP = sp.masp
                        WHERE MONTH(hdb.NgLapHD) = {month}
                        AND YEAR(hdb.NgLapHD) = {year}
                        GROUP BY sp.masp, sp.tensp
                        ORDER BY TongSoLuongBan DESC;";
                        DataTable datatbale = Database.LoadData(query);
                        dgv_DaTa.DataSource = datatbale;

                    }
                    /*--------------------------------------------------------------*/
                    if (cbb_SanPham.SelectedIndex == 1)
                    {
                        string query = $@"
                        SELECT TOP 1 WITH TIES
                        sp.masp,
                        sp.tensp,
                        SUM(ct.SoLuongBan) AS TongSoLuongBan
                        FROM CTHDB ct
                        JOIN HoaDonBan hdb ON ct.MaHDB = hdb.MaHDB
                        JOIN sanpham sp ON ct.MaSP = sp.masp
                        WHERE YEAR(hdb.NgLapHD) = {year}
                        GROUP BY sp.masp, sp.tensp
                        ORDER BY TongSoLuongBan DESC;";
                        DataTable datatbale = Database.LoadData(query);
                        dgv_DaTa.DataSource = datatbale;

                    }
                    /*--------------------------------------------------------------*/
                    if (cbb_KhachHang.SelectedIndex == 2)
                    {
                        string query = $@"
                        SELECT 
                        sp.masp,
                        sp.tensp,
                        SUM(ct.SoLuongBan) AS TongSoLuongBan
                        FROM CTHDB ct
                        JOIN HoaDonBan hdb ON ct.MaHDB = hdb.MaHDB
                        JOIN sanpham sp ON ct.MaSP = sp.masp
                        WHERE MONTH(hdb.NgLapHD) = {month}
                        AND YEAR(hdb.NgLapHD) = {year}
                        GROUP BY sp.masp, sp.tensp
                        ORDER BY TongSoLuongBan DESC;";
                        DataTable datatbale = Database.LoadData(query);
                        dgv_DaTa.DataSource = dt;
                    }
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dtp_NgayThangNam.Value = DateTime.Now;
            rdb_LoiNhuan.Checked = true;
            cbb_SanPham.Text = string.Empty;
            cbb_KhachHang.Text = string.Empty;
            cbb_SanPham.Text = string.Empty;
        }

        private void cbb_LoiNhuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdb_LoiNhuan_CheckedChanged(sender, e);
        }

        private void cbb_KhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdb_KhachHang_CheckedChanged(sender, e);
        }

        private void cbb_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdb_SanPham_CheckedChanged(sender,e);
        }

        private void dgv_DaTa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            rdb_LoiNhuan.Checked=true;
        }
    }
}
