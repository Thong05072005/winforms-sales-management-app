using DoAnTheoMoHinh3Lop.BUS;
using DoAnTheoMoHinh3Lop.DAO;
using DoAnTheoMoHinh3Lop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnTheoMoHinh3Lop.GUI
{
    public partial class frm_KH : Form
    {
        KhachHang_BUS kh_BUS = new KhachHang_BUS();
        Database db = new Database();
        public frm_KH()
        {
            InitializeComponent();
        }
        public void Select_KH()
        {
            dgv_KH.DataSource = kh_BUS.select_KH();
            txt_TenKH.Focus();
        }
        public bool kiemTraNhap()
        {
            if (txt_TenKH.Text == "")
            {
                MessageBox.Show("Chưa nhập họ tên!!!");
                txt_TenKH.Focus();
                return false;
            }
            if (txt_DiaChi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ!!!");
                txt_DiaChi.Focus();
                return false;
            }
            if (txt_DienThoai.Text == "" || txt_DienThoai.Text.Length != 10)
            {
                MessageBox.Show("Nhập số điện thoại chưa đúng!!!");
                txt_DienThoai.Focus();
                return false;
            }
            if (txt_Email.Text == "")
            {
                MessageBox.Show("Chưa nhập email!!!");
                txt_Email.Focus();
                return false;
            }

            return true;
        }
        public void lamSach()
        {
            txt_TenKH.Text = "";
            txt_MaKH.Text = "";
            txt_Email.Text = "";
            txt_DienThoai.Text = "";
            txt_DiaChi.Text = "";
            rdb_Nam.Checked = false;
            rdb_Nu.Checked = false;
            dtm_NamSinh.Value = DateTime.Now;
            txt_TenKH.Focus();
            Select_KH();
        }
        public void select_MaKH()
        {
            cbb_TimKH.DataSource = kh_BUS.select_KH();
            cbb_TimKH.DisplayMember = "hotenkh";
            cbb_TimKH.ValueMember = "makh";

        }
        private void frm_KH_Load(object sender, EventArgs e)
        {
            dgv_KH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Select_KH();
            select_MaKH();
            lamSach();
            cbb_TimKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbb_TimKH.AutoCompleteSource = AutoCompleteSource.ListItems;

        }



        private void dgv_KH_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKH.Text = dgv_KH[0, dgv_KH.CurrentRow.Index].Value.ToString();
            txt_TenKH.Text = dgv_KH[1, dgv_KH.CurrentRow.Index].Value.ToString();
            dtm_NamSinh.Text = dgv_KH[2, dgv_KH.CurrentRow.Index].Value.ToString();
            string gioiTinh = dgv_KH[3, dgv_KH.CurrentRow.Index].Value.ToString();
            if (gioiTinh == "Nam")
                rdb_Nam.Checked = true;
            else rdb_Nu.Checked = true;
            txt_DiaChi.Text = dgv_KH[4, dgv_KH.CurrentRow.Index].Value.ToString();
            txt_DienThoai.Text = dgv_KH[5, dgv_KH.CurrentRow.Index].Value.ToString();
            txt_Email.Text = dgv_KH[6, dgv_KH.CurrentRow.Index].Value.ToString();
        }



        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            if (kiemTraNhap() == false)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa nhân viên??", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                KhachHang_DTO kh_DTO = new KhachHang_DTO();
                kh_DTO.MaKH = txt_MaKH.Text;
                kh_DTO.HoTenKH = txt_TenKH.Text;
                kh_DTO.NamSinh = dtm_NamSinh.Value.ToString();
                kh_DTO.GioiTinh = (rdb_Nam.Checked) ? "Nam" : "Nữ";
                kh_DTO.DiaChi = txt_DiaChi.Text;
                kh_DTO.DienThoai = txt_DienThoai.Text;
                kh_DTO.Email = txt_Email.Text;
                MessageBox.Show(kh_BUS.update_KH(kh_DTO).ToString());
                if (kh_BUS.update_KH(kh_DTO))
                {
                    MessageBox.Show("Sửa thành công");
                    Select_KH();
                    lamSach();
                    select_MaKH();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }


        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            if (txt_MaKH.Text == " ")
            {
                MessageBox.Show("Chưa nhập mã khách hàng");
                txt_MaKH.Focus();
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng??", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                KhachHang_DTO kh_DTO = new KhachHang_DTO();
                kh_DTO.MaKH = txt_MaKH.Text;
                if (kh_BUS.delete_KH(kh_DTO))
                {
                    MessageBox.Show("Xóa thành công");
                    Select_KH();
                    lamSach();
                    select_MaKH();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    lamSach();
                    return;
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lamSach();
        }

        private void btn_ThemKH_Click_1(object sender, EventArgs e)
        {

            if (kiemTraNhap() == false)
            {
                return;
            }
            Random random = new Random();
            int soNgauNhien = random.Next(100000, 999999);
            KhachHang_DTO KH_DTO = new KhachHang_DTO();
            KH_DTO.MaKH = "KH" + soNgauNhien;
            KH_DTO.HoTenKH = txt_TenKH.Text;
            KH_DTO.NamSinh = dtm_NamSinh.Value.ToString();
            KH_DTO.GioiTinh = (rdb_Nam.Checked) ? "Nam" : "Nữ";
            KH_DTO.DiaChi = txt_DiaChi.Text;
            KH_DTO.DienThoai = txt_DienThoai.Text;
            KH_DTO.Email = txt_Email.Text;
            string strQuery = string.Format("select count(*) from khachhang where makh='{0}'", txt_MaKH.Text);
            if (db.kiemTraTonTai(strQuery) == 1)
            {
                MessageBox.Show("Khách hàng đã tồn tại");
                return;
                lamSach();
            }
            if (kh_BUS.insert_KH(KH_DTO))
            {
                MessageBox.Show("Thêm thành công");
                Select_KH();
                lamSach();
                select_MaKH();

            }
        }


        private void btn_TimKiemKH_Click_1(object sender, EventArgs e)
        {
            if (cbb_TimKH.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            try
            {
                string maKH = cbb_TimKH.SelectedValue.ToString();
                dgv_KH.DataSource = db.LoadData(string.Format("select* from khachhang where makh='{0}'", maKH));
            }
            catch
            {
                MessageBox.Show("Không tìm thấy khách hàng");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Nhấn yes để thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
