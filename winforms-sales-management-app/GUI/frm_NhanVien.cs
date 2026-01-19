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
    public partial class frm_NhanVien : Form
    {
        NhanVien_BUS NV_BUS = new NhanVien_BUS();
        Database db = new Database();
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        public void select_MaNV()

        {
            cbb_MaNV.DataSource = NV_BUS.HienTTNV();
            cbb_MaNV.DisplayMember = "hotennv";
            cbb_MaNV.ValueMember = "manv";

        }
        public bool kiemTraNhap()
        {
            if (txt_HoTen.Text == "")
            {
                MessageBox.Show("Chưa nhập họ tên!!!");
                txt_HoTen.Focus();
                return false;
            }
            if (rdo_Nam.Checked == false && rdo_Nu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính!!!");
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
            if (txt_GhiChu.Text == "")
            {
                MessageBox.Show("Bạn chưa ghi ghi chú!!!");
                txt_GhiChu.Focus();
                return false;
            }
            if (cbb_LoaiNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn loại nhân viên!!!");
                cbb_LoaiNV.Focus();
                return false;
            }
            return true;
        }
        public void select_TenNV()
        {
            dgv_nhan_vien.DataSource = db.LoadData("select*from NhanVien order by HoTenNV");
        }
        public void select_NhanVienBan()
        {
            dgv_nhan_vien.DataSource = db.LoadData("select*from NhanVien where LoaiNV=1");

        }
        public void select_NhanVienNhap()
        {
            dgv_nhan_vien.DataSource = db.LoadData("select*from NhanVien where LoaiNV=2");

        }
        public void select_NV()
        {
            dgv_nhan_vien.DataSource = NV_BUS.HienTTNV();
            txt_HoTen.Focus();
        }
        public void clear_NV()
        {
            txt_MaNV.Text = "";
            txt_HoTen.Text = "";
            dtm_NamSinh.Value = DateTime.Now;
            rdo_Nam.Checked = false;
            rdo_Nu.Checked = false;
            txt_DiaChi.Text = "";
            txt_DienThoai.Text = "";
            txt_GhiChu.Text = "";
            cbb_LoaiNV.Text = "";
            txt_Email.Text = "";
            txt_HoTen.Focus();
            cbb_LoaiNV.Text = "";
            cbb_MaNV.Text = "";
            cbb_SapXepNV.Text = "";
            select_NV();
        }
        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            dgv_nhan_vien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            select_NV();
            select_MaNV();
            cbb_MaNV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbb_MaNV.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemTraNhap() == false)
                {
                    return;
                }
                Random random = new Random();
                int soNgauNhien = random.Next(100000, 999999);
                NhanVien_DTO nv_DTO = new NhanVien_DTO();
                nv_DTO.MaNV = "NV" + soNgauNhien;
                nv_DTO.HoTenNV = txt_HoTen.Text;
                nv_DTO.NamSinh = dtm_NamSinh.Value.ToString();
                nv_DTO.GioiTinh = rdo_Nam.Checked ? rdo_Nam.Text : rdo_Nu.Text;
                nv_DTO.DiaChi = txt_DiaChi.Text;
                nv_DTO.DienThoai = txt_DienThoai.Text;
                nv_DTO.GhiChu = txt_GhiChu.Text;
                nv_DTO.LoaiNV = (cbb_LoaiNV.Text == "Nhân viên bán hàng") ? 1 : 2;
                nv_DTO.Email = txt_Email.Text;
                nv_DTO.TrangThai = (rdb_HD.Checked) ? 1 : 0;

                string strQuer = string.Format("select count(*) from nhanvien where manv='{0}'", txt_MaNV.Text);
                if (db.kiemTraTonTai(strQuer) == 1)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại");
                    return;
                }

                if (NV_BUS.Insert_NV(nv_DTO))
                {
                    MessageBox.Show("Thêm thành công nhân viên");
                    select_NV();
                    clear_NV();
                    select_MaNV();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa nhân viên??", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (kiemTraNhap() == false)
                    {
                        return;
                    }
                    NhanVien_DTO nv_DTO = new NhanVien_DTO();
                    nv_DTO.MaNV = txt_MaNV.Text;
                    nv_DTO.HoTenNV = txt_HoTen.Text;
                    nv_DTO.NamSinh = dtm_NamSinh.Value.ToString();
                    nv_DTO.GioiTinh = rdo_Nam.Checked ? rdo_Nam.Text.ToString() : rdo_Nu.Text.ToString();
                    nv_DTO.DiaChi = txt_DiaChi.Text;
                    nv_DTO.DienThoai = txt_DienThoai.Text;
                    nv_DTO.GhiChu = txt_GhiChu.Text;
                    nv_DTO.LoaiNV = (cbb_LoaiNV.Text == "Nhân viên bán hàng") ? 1 : 2;
                    nv_DTO.Email = txt_Email.Text;
                    nv_DTO.TrangThai = (rdb_HD.Checked) ? 1 : 0;
                    if (NV_BUS.Update_NV(nv_DTO))
                    {
                        MessageBox.Show("Sửa thành công nhân viên");
                        select_NV();
                        clear_NV();
                        select_MaNV();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sửa không thành công!!!!");
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên??", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    NhanVien_DTO nv_DTO = new NhanVien_DTO();
                    nv_DTO.MaNV = txt_MaNV.Text;


                    if (NV_BUS.Delete_NV(nv_DTO))
                    {
                        MessageBox.Show("Xóa thành công nhân viên");
                        select_NV();
                        clear_NV();
                        select_MaNV();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!!!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại!!!");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear_NV();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Nhấn yes để thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgv_nhan_vien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show("Đã click");

                txt_MaNV.Text = dgv_nhan_vien[0, dgv_nhan_vien.CurrentRow.Index].Value.ToString();
                txt_HoTen.Text = dgv_nhan_vien[1, dgv_nhan_vien.CurrentRow.Index].Value.ToString();
                string gioiTinh = dgv_nhan_vien[3, dgv_nhan_vien.CurrentRow.Index].Value.ToString();
                if (gioiTinh == "Nam")
                    rdo_Nam.Checked = true;
                else rdo_Nu.Checked = true;
                dtm_NamSinh.Text = dgv_nhan_vien[2, dgv_nhan_vien.CurrentRow.Index].Value.ToString();
                txt_DiaChi.Text = dgv_nhan_vien[4, dgv_nhan_vien.CurrentRow.Index].Value.ToString();
                txt_DienThoai.Text = dgv_nhan_vien[5, dgv_nhan_vien.CurrentRow.Index].Value.ToString();

                string loaiNV = dgv_nhan_vien[7, dgv_nhan_vien.CurrentRow.Index].Value.ToString();
                if (int.Parse(loaiNV) == 1)
                {
                    cbb_LoaiNV.Text = "Nhân viên bán hàng";
                }
                else
                {
                    cbb_LoaiNV.Text = "Nhân viên nhập hàng";
                }

                txt_GhiChu.Text = dgv_nhan_vien[6, dgv_nhan_vien.CurrentRow.Index].Value.ToString();
                txt_Email.Text = dgv_nhan_vien[8, dgv_nhan_vien.CurrentRow.Index].Value.ToString();
                if (int.Parse(dgv_nhan_vien[9, dgv_nhan_vien.CurrentRow.Index].Value.ToString()) == 1)
                {
                    rdb_HD.Checked = true;
                }
                else rdb_KHD.Checked = true;
            }
            catch { }
        }



        private void btn_TimKiemNV_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbb_MaNV.Text == "")
                {
                    MessageBox.Show("Không được để trống");
                    return;
                }
                string manv = cbb_MaNV.SelectedValue.ToString();

                dgv_nhan_vien.DataSource = db.LoadData(string.Format("select * from nhanvien where manv='{0}'", manv));
            }
            catch
            {
                MessageBox.Show("Không tìm thấy nhân viên");
            }
        }

        private void cbb_SapXepNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_SapXepNV.Text == "Tên")
            {
                select_TenNV();
            }
            else if (cbb_SapXepNV.Text == "Nhân viên bán")
            {
                select_NhanVienBan();
            }
            else if (cbb_SapXepNV.Text == "Nhân viên nhập")
            {
                select_NhanVienNhap();
            }
        }
    }
}
