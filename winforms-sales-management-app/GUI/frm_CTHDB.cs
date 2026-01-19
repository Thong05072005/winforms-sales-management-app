using DoAnTheoMoHinh3Lop.BUS;
using DoAnTheoMoHinh3Lop.DAO;
using DoAnTheoMoHinh3Lop.DTO;
using DoAnTheoMoHinh3Lop.Report;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnTheoMoHinh3Lop.GUI
{
    public partial class frm_CTHDB : Form
    {
        CTHDB_DAO cthd_DAO = new CTHDB_DAO();
        HoaDonBan_DTO hdb_DTO = new HoaDonBan_DTO();
        CTHDB_DTO cthd_DTO = new CTHDB_DTO();
        CTHDB_BUS cthd_BUS = new CTHDB_BUS();
        Database database = new Database();
        NhanVien_BUS nv_BUS = new NhanVien_BUS();
        SanPham_BUS sp_BUS = new SanPham_BUS();
        KhachHang_BUS khachHang_BUS = new KhachHang_BUS();
        public frm_CTHDB()
        {
            InitializeComponent();
        }
        public bool kiemTraNhap()
        {
            if (cbb_MaKH.Text == " ")
            {
                MessageBox.Show("Bạn chưa chọn mã khách hàng");
                cbb_MaKH.Focus();
                return false;
            }
            if (cbb_MaNVB.Text == " ")
            {
                MessageBox.Show("Bạn chưa chọn mã nhân viên bán");
                cbb_MaNVB.Focus();
                return false;
            }
            if (nud_SoLuong.Value == 0 || nud_SoLuong.Value < 0)
            {
                MessageBox.Show("Số lượng không được để bằng 0 hoặc nhỏ hơn 0");
                nud_SoLuong.Focus();
                return false;
            }
            if (cbb_MaKH.Text == "")
            {
                MessageBox.Show("Chưa nhập mã khách hàng");
                cbb_MaKH.Focus();
                return false;
            }
            if (cbb_MaSP.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sản phẩm");
                cbb_MaSP.Focus();
                return false;
            }
            if (cbb_MaNVB.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhân viên");
                cbb_MaNVB.Focus();
                return false;
            }
            return true;
        }
        public bool kiemTraTonTai()
        {
            string strQuery = string.Format("select count(*) from sanpham where masp='{0}'", cbb_MaSP.SelectedValue.ToString());
            if (database.kiemTraTonTai(strQuery) == 0)
            {
                MessageBox.Show("Mã sản phẩm không tồn tại trong danh sách!");
                cbb_MaSP.Focus();
                return false;
            }

            string strQuery2 = string.Format("select count(*) from KhachHang where MaKH = '{0}'", cbb_MaKH.SelectedValue.ToString());
            if (database.kiemTraTonTai(strQuery2) == 0)
            {
                MessageBox.Show("Mã khách hàng không tồn tại trong danh sách!");
                cbb_MaSP.Focus();
                return false;
            }

            string strQuery3 = string.Format("select count(*) from nhanvien where manv = '{0}'", cbb_MaNVB.SelectedValue.ToString());
            if (database.kiemTraTonTai(strQuery3) == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                cbb_MaNVB.Focus();
                return false;
            }


            return true;
        }
        public void select_CTHD()
        {
            dgv_HDB.DataSource = cthd_DAO.select_CTHDB();
            nud_SoLuong.Focus();
        }
        public void select_MaSP()
        {
            cbb_MaSP.DataSource = sp_BUS.hienTTSP();
            cbb_MaSP.DisplayMember = "tensp";
            cbb_MaSP.ValueMember = "masp";
        }
        public void select_MaKH()
        {
            cbb_MaKH.DataSource = khachHang_BUS.select_KH();
            cbb_MaKH.DisplayMember = "hotenkh";
            cbb_MaKH.ValueMember = "makh";
        }
        public void select_MaHD()
        {
            cbb_MaHD.DataSource = database.LoadData("select MaHDB from cthdb order by mahdb desc");
            cbb_MaHD.DisplayMember = "MaHDB";
            cbb_MaHD.ValueMember = "MaHDB";
        }
        public void select_MaNV()
        {
            cbb_MaNVB.DataSource = nv_BUS.HienTTNVHD();
            cbb_MaNVB.DisplayMember = "hotennv";
            cbb_MaNVB.ValueMember = "manv";
        }

        public double tinhTongTien()
        {
            int soLuongBan = int.Parse(nud_SoLuong.Value.ToString());
            double giaSP = double.Parse(txt_GiaSP.Text);
            return soLuongBan * giaSP;
        }
        public void lamSach()
        {
            txt_MaHD.Clear();
            cbb_MaKH.Text = "";
            dtm_NamSinh.Value = DateTime.Now;
            txt_TongTien.Text = "";
            txt_GhiChu.Text = "";
            cbb_MaNVB.Text = "";
            txt_TenKH.Text = "";
            dtm_NgLapHD.Value = DateTime.Now;
            rdb_Nam.Checked = false;
            rdb_Nu.Checked = false;
            txt_DiaChi.Text = "";
            txt_DienThoai.Text = "";
            txt_Email.Text = "";
            cbb_MaSP.Text = "";
            nud_SoLuong.Value = 0;
            txt_TongTienBan.Text = "";
            select_CTHD();
        }
        private void frm_CTHDB_Load(object sender, EventArgs e)
        {

            dgv_HDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            select_CTHD();
            //Hiển thị mã sản phẩm
            select_MaSP();
            // select_GiaSP();
            //Hiển thị mã nhân viên
            select_MaNV();

            //Hiển thị mã khách hàng
            select_MaKH();

            //Mã hóa đơn bán
            select_MaHD();
            //
            txt_TongTien.Text = txt_TongTienBan.Text;

            cbb_MaSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbb_MaSP.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbb_MaKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbb_MaKH.AutoCompleteSource = AutoCompleteSource.ListItems;


            cbb_MaNVB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbb_MaNVB.AutoCompleteSource = AutoCompleteSource.ListItems;



            string giaSP = txt_GiaSP.Text;
            txt_TongTienBan.Text = "0";

            cbb_MaHD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbb_MaHD.AutoCompleteSource = AutoCompleteSource.ListItems;

        }


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Nhấn yes để thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void cbb_MaKH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string maKH = cbb_MaKH.Text;
            string strQuere = string.Format("select HoTenKH, NamSinh,GioiTinh, DiaChi, DienThoai, email\r\nfrom KhachHang where makh = '{0}'", maKH);
            SqlDataReader reader = database.getThongTin(strQuere);
            while (reader.Read())
            {
                string hoTen = reader.GetString(0);
                DateTime namSinh = reader.GetDateTime(1);
                string gioiTinh = reader.GetString(2);
                string diaChi = reader.GetString(3);
                string dienThoai = reader.GetString(4);
                string email = reader.GetString(5);
                txt_TenKH.Text = hoTen;
                dtm_NamSinh.Text = namSinh.ToString();
                if (gioiTinh != "Nam")
                    rdb_Nam.Checked = true;
                else rdb_Nu.Checked = true;
                txt_DiaChi.Text = diaChi;
                txt_DienThoai.Text = dienThoai;
                txt_Email.Text = email;
            }
        }

        private void cbb_MaSP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string maSP = cbb_MaSP.Text;
            string strQuery = string.Format("select giasp from sanpham where masp='{0}'", maSP);
            double giaTien = database.getGiaTien(strQuery);
            txt_GiaSP.Text = giaTien.ToString();
        }

        private void nud_SoLuong_ValueChanged_1(object sender, EventArgs e)
        {
            double tongTien = tinhTongTien();
            txt_TongTienBan.Text = tongTien.ToString();
        }

        private void txt_TongTienBan_TextChanged(object sender, EventArgs e)
        {
            txt_TongTien.Text = txt_TongTienBan.Text;
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {

            if (kiemTraNhap() == false)
            {
                return;
            }
            if (kiemTraTonTai() == false) return;
            cthd_DTO.MaSP = cbb_MaSP.SelectedValue.ToString();
            cthd_DTO.SoLuongBan = int.Parse(nud_SoLuong.Text);
            cthd_DTO.TongDonGiaBan = float.Parse(txt_TongTienBan.Text);

            hdb_DTO.MaKH = cbb_MaKH.SelectedValue.ToString();
            hdb_DTO.NgayLapHD = dtm_NgLapHD.Text;
            hdb_DTO.GhiChu = txt_GhiChu.Text;
            hdb_DTO.MaNVB = cbb_MaNVB.SelectedValue.ToString();

            if (cthd_BUS.insert_HDB(cthd_DTO, hdb_DTO))
            {
                MessageBox.Show("Thêm thành công");
                select_CTHD();
                select_MaHD();
                lamSach();
                select_MaHD();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!!!");
            }
        }




        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            cthd_DTO.MaSP = cbb_MaSP.Text;
            cthd_DTO.MaHDB = int.Parse(txt_MaHD.Text);
            cthd_DTO.SoLuongBan = int.Parse(nud_SoLuong.Value.ToString());
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm??", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (cthd_BUS.delete_HDB(cthd_DTO))
                {
                    MessageBox.Show("Xóa thành công");
                    select_CTHD();
                    lamSach();
                    select_MaHD();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!!!");
                }
            }
        }

        private void dgv_HDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbb_MaSP.Text = dgv_HDB[0, dgv_HDB.CurrentRow.Index].Value.ToString();
                txt_MaHD.Text = dgv_HDB[1, dgv_HDB.CurrentRow.Index].Value.ToString();
                nud_SoLuong.Text = dgv_HDB[2, dgv_HDB.CurrentRow.Index].Value.ToString();
                txt_TongTienBan.Text = dgv_HDB[3, dgv_HDB.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Hiển thị có vấn đề!!!");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lamSach();
        }

        private void btn_InHDB_Click(object sender, EventArgs e)
        {
            string maKH = cbb_MaKH.Text;
            string strQuere = string.Format("select HoTenKH, NamSinh,GioiTinh, DiaChi, DienThoai, email\r\nfrom KhachHang where makh = '{0}'", maKH);
            SqlDataReader reader = database.getThongTin(strQuere);
            while (reader.Read())
            {
                string hoTen = reader.GetString(0);
                //string namSinh = reader.GetString(1);
                DateTime namSinh = reader.GetDateTime(1);
                string gioiTinh = reader.GetString(2);
                string diaChi = reader.GetString(3);
                string dienThoai = reader.GetString(4);
                //string email = reader.GetString(5);
                txt_TenKH.Text = hoTen;
                dtm_NamSinh.Text = namSinh.ToString();
                if (gioiTinh != "Nam")
                    rdb_Nam.Checked = true;
                else rdb_Nu.Checked = true;
                txt_DiaChi.Text = diaChi;
                txt_DienThoai.Text = dienThoai;
                //txt_Email.Text=email;
            }
        }

        private void btn_TimKiemHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_MaHD.Text == "")
                {
                    MessageBox.Show("Không được để trống");
                    return;
                }
                int mahd = int.Parse(cbb_MaHD.Text);
                dgv_HDB.DataSource = database.LoadData(string.Format("select*from CTHDB where mahdb={0}", mahd));
            }

            catch
            {
                MessageBox.Show("Không tìm thấy hóa đơn");
            }
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Nhấn yes để thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_InHoaDonBan_Click(object sender, EventArgs e)
        {
            frm_InCTHDB frm_InCTHDB = new frm_InCTHDB();
            if (txt_MaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã hóa đơn");
                return;
            }
            frm_InCTHDB.maHoaDon = int.Parse(txt_MaHD.Text);
            frm_InCTHDB.Show();
        }

    }
}
