using DoAnTheoMoHinh3Lop.BUS;
using DoAnTheoMoHinh3Lop.DAO;
using DoAnTheoMoHinh3Lop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTheoMoHinh3Lop.GUI
{
    public partial class frm_CTHDN : Form
    {
        Database Database = new Database();
        CTHDN_BUS CTHDN_BUS = new CTHDN_BUS();
        HoaDonNhap_BUS HoaDonNhap_BUS = new HoaDonNhap_BUS();
        public frm_CTHDN()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dtp_NamSinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt_MaHD_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void cb_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNV = cbb_MaNV.Text;
            string strQuere = string.Format("select hotennv,namsinh,GioiTinh, DiaChi, DienThoai, ghichu from nhanvien where manv = '{0}'", maNV);
            SqlDataReader reader = Database.getThongTin(strQuere);
            while (reader.Read())
            {
                string hoTen = reader.GetString(0);
                DateTime namSinh = reader.GetDateTime(1);
                string gioiTinh = reader.GetString(2);
                string diaChi = reader.GetString(3);
                string dienThoai = reader.GetString(4);
                string ghichu = reader.GetString(5);
                txt_TenNV.Text = hoTen;
                dtp_NamSinh.Text = namSinh.ToString();
                if (gioiTinh == "Nam")
                    rdb_Nam.Checked = true;
                else rdb_Nu.Checked = true;
                txt_DiaChi.Text = diaChi;
                txt_DienThoai.Text = dienThoai;
                txt_GhiChuNV.Text = ghichu;
            }
        }
        public void select_MaNV()
        {
            string str = string.Format("select manv from nhanvien where loaiNV='{0}'", 1);
            cbb_MaNV.DataSource = Database.LoadData(str);
            cbb_MaNV.DisplayMember = "manv";
            cbb_MaNV.ValueMember = "manv";
        }
        public void select_MaHD()
        {
            cbb_MaHD.DataSource = Database.LoadData("select mahdn from hoadonnhap");
            cbb_MaHD.DisplayMember = "mahdn";
            cbb_MaHD.ValueMember = "mahdn";
            cbb_DeleteMaHD.DataSource = cbb_MaHD.DataSource;
            cbb_DeleteMaHD.DisplayMember = "mahdn";
            cbb_DeleteMaHD.ValueMember = "mahdn";
        }
        public void select_MaNCC()
        {
            cbb_MaNCC.DataSource = Database.LoadData("select mancc from nhacungcap");
            cbb_MaNCC.DisplayMember = "MaNCC";
            cbb_MaNCC.ValueMember = "MaNCC";
        }
        public void select_MaSP()
        {
            cbb_MaSP.DataSource = Database.LoadData("select masp from sanpham");
            cbb_MaSP.DisplayMember = "masp";
            cbb_MaSP.ValueMember = "masp";
        }
        public void hienThiCTHDN()
        {
            dgv_CTHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CTHDN.DataSource = CTHDN_BUS.select_CTHDN();
            txt_MaHD.Focus();
        }
        public void clean()
        {
            txt_MaHD.Text = string.Empty;
            cbb_MaNCC.Text = string.Empty;
            txt_GhiChu.Text = string.Empty;
            txt_TenNV.Text = string.Empty;
            cbb_MaNCC.Text = string.Empty;
            txt_DiaChi.Text = string.Empty;
            txt_DienThoai.Text = string.Empty;
            txt_GhiChuNV.Text = string.Empty;
            cbb_MaSP.Text = string.Empty;
            cbb_MaHD.Text = string.Empty;
            txt_TongTienNhap.Text = string.Empty;
            txt_TongTienHD.Text = string.Empty;
            nud_SoLuong.Text = string.Empty;
        }
        public void disabledThongTinNV()
        {
            txt_TenNV.Enabled = false;
            txt_GhiChuNV.Enabled = false;
            dtp_NamSinh.Enabled = false;
            txt_DiaChi.Enabled = false;
            txt_DienThoai.Enabled = false;
            rdb_Nam.Enabled = false;
            rdb_Nu.Enabled = false;
            txt_MaHD.Enabled = false;
            txt_TongTienHD.Enabled = false;
            txt_TongTienNhap.Enabled = false;
        }
        public double tinhTongTien()
        {

            int soLuongNhap = int.Parse(nud_SoLuong.Value.ToString());
            double giaSP = double.Parse(txt_GiaSP.Text);
            return soLuongNhap * giaSP;
        }
        private void dtm_NgLapHD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThemHD_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm ??", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                HoaDonNhap_DTO HoaDonNhap_DTO = new HoaDonNhap_DTO();
                HoaDonNhap_DTO.MaHDN = int.Parse(txt_MaHD.Text);
                HoaDonNhap_DTO.MaNCC = cbb_MaNCC.Text;
                HoaDonNhap_DTO.MaNVN = cbb_MaNV.Text;
                HoaDonNhap_DTO.NgayLapHD = dtp_NgayLapHD.Text;
                if (nud_SoLuong.Value == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng");
                    nud_SoLuong.Focus();
                    return;
                }
                HoaDonNhap_DTO.TongTienNhap = float.Parse(txt_TongTienHD.Text);
                HoaDonNhap_DTO.GhiChu = txt_GhiChu.Text;
                HoaDonNhap_BUS.insert_HoaDonNhap(HoaDonNhap_DTO);
                /*---------------------------------------------------*/
                CTHDN_DTO CTHDN_DTO = new CTHDN_DTO();
                CTHDN_DTO.MaSP = cbb_MaSP.Text;
                CTHDN_DTO.MaHDN = HoaDonNhap_DTO.MaHDN;
                CTHDN_DTO.SoLuongNhap = int.Parse(nud_SoLuong.Text);
                CTHDN_DTO.TongTienNhap = float.Parse(txt_TongTienNhap.Text);
                CTHDN_DTO.GiaNhap = float.Parse(txt_GiaSP.Text) * 0.9f;
                CTHDN_BUS.insert_CTHDN(CTHDN_DTO);
                frm_CTHDN_Load(sender, e);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clean();

        }

        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa??", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txt_MaHD.Visible == true)
                {
                    btn_ThemHD.Enabled = false;
                    cbb_DeleteMaHD.Visible = true;
                    txt_MaHD.Visible = false;
                }
                else
                {
                    HoaDonNhap_DTO HoaDonNhap_DTO = new HoaDonNhap_DTO();
                    HoaDonNhap_DTO.MaHDN = int.Parse(cbb_MaHD.Text);
                    HoaDonNhap_BUS.delete_HoaDonNhap(HoaDonNhap_DTO);
                    CTHDN_DTO CTHDN_DTO = new CTHDN_DTO();
                    CTHDN_DTO.MaHDN = HoaDonNhap_DTO.MaHDN;
                    CTHDN_BUS.delete_CTHDN(CTHDN_DTO);
                    frm_CTHDN_Load(sender, e);
                }
            }
        }
        private void frm_CTHDN_Load(object sender, EventArgs e)
        {
            select_MaSP();
            select_MaNV();
            select_MaNCC();
            select_MaHD();
            hienThiCTHDN();
            disabledThongTinNV();
            txt_MaHD.Text = Database.getmaxHDN();
            btn_ThemHD.Enabled = true;
            txt_MaHD.Visible = true;
            cbb_DeleteMaHD.Visible = false;
            
        }

        private void cbb_MaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSP = cbb_MaSP.Text;
            string strQuery = string.Format("select giasp from sanpham where masp='{0}'", maSP);
            double giaTien = Database.getGiaTien(strQuery);
            txt_GiaSP.Text = giaTien.ToString();
        }

        private void nud_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            double t = tinhTongTien();
            txt_TongTienNhap.Text = t.ToString();
            txt_TongTienHD.Text = (t * 0.9).ToString();
        }

        private void cbb_MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNV = cbb_MaNV.Text;
            string strQuere = string.Format("select hotennv,namsinh,GioiTinh, DiaChi, DienThoai, ghichu from nhanvien where manv = '{0}'", maNV);
            SqlDataReader reader = Database.getThongTin(strQuere);
            while (reader.Read())
            {
                string hoTen = reader.GetString(0);
                DateTime namSinh = reader.GetDateTime(1);
                string gioiTinh = reader.GetString(2);
                string diaChi = reader.GetString(3);
                string dienThoai = reader.GetString(4);
                string ghichu = reader.GetString(5);
                txt_TenNV.Text = hoTen;
                dtp_NamSinh.Text = namSinh.ToString();
                if (gioiTinh == "Nam")
                    rdb_Nam.Checked = true;
                else rdb_Nu.Checked = true;
                txt_DiaChi.Text = diaChi;
                txt_DienThoai.Text = dienThoai;
                txt_GhiChuNV.Text = ghichu;
            }
        }

        private void txt_TongTienHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TimKiemHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_MaHD.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã hóa đơn");
                    return;
                }
                DataTable dt = new DataTable();
                string str = $@"Select * from cthdn where mahdn ={cbb_MaHD.Text}";
                dt = Database.LoadData(str);
                dgv_CTHDN.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }
    }
}
