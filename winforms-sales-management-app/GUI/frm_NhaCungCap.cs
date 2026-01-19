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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTheoMoHinh3Lop.GUI
{
    public partial class frm_NhaCungCap : Form
    {
        Database Database = new Database();
        NhaCungCap_BUS NhaCungCap_BUS = new NhaCungCap_BUS();
        public frm_NhaCungCap()
        {
            InitializeComponent();
            txt_DienThoai.KeyPress += TxtPhoneNumber_KeyPress;
        }
        public void clear()
        {
            txt_MaNCC.Text = string.Empty;
            txt_DienThoai.Text = string.Empty;
            txt_DiaChi.Text = string.Empty;
            txt_TenSP.Text = string.Empty;
            txt_Email.Text = string.Empty;
            cbb_MaNCC.Text = string.Empty;
            cbb_SapXep.Text = string.Empty;
        }
        public void select_NhaCungCap()
        {
            dgv_NhaCungCap.DataSource = NhaCungCap_BUS.select_NhaCungCap();
            txt_MaNCC.Focus();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbb_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_SapXep.SelectedIndex == 0)
            {
                dgv_NhaCungCap.DataSource = Database.LoadData("SELECT *FROM nhacungcap ORDER BY mancc ASC");
            }
            if (cbb_SapXep.SelectedIndex == 1)
            {
                dgv_NhaCungCap.DataSource = Database.LoadData("SELECT *FROM nhacungcap ORDER BY mancc DESC");
            }
        }
        public void select_MaNCC()
        {
            cbb_MaNCC.DataSource = Database.LoadData("select mancc from nhacungcap");
            cbb_MaNCC.DisplayMember = "MaNCC";
            cbb_MaNCC.ValueMember = "MaNCC";
        }

        private void dgv_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            dgv_NhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            select_NhaCungCap();
            select_MaNCC();
            dgv_SP_SelectionChanged(sender, e);
            cbb_MaNCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbb_MaNCC.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra email hợp lệ
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);  // Trả về true nếu email hợp lệ, false nếu không hợp lệ
        }
        private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số và không phải là ký tự xóa (Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Hủy sự kiện nếu không phải số
            }
        }
 
        private void dgv_SP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NhaCungCap.SelectedRows.Count > 0)
            {
                txt_MaNCC.Text = dgv_NhaCungCap.SelectedRows[0].Cells[0].Value.ToString();
                txt_DiaChi.Text = dgv_NhaCungCap.SelectedRows[0].Cells[1].Value.ToString();
                txt_DienThoai.Text = dgv_NhaCungCap.SelectedRows[0].Cells[2].Value.ToString();
                txt_Email.Text = dgv_NhaCungCap.SelectedRows[0].Cells[3].Value.ToString();
                txt_TenSP.Text = dgv_NhaCungCap.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btn_TimSP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbb_MaNCC.Text))
            {
                NhaCungCap_DTO NhaCungCap_DTO = new NhaCungCap_DTO();
                NhaCungCap_DTO.MaNCC = cbb_MaNCC.Text;
                dgv_NhaCungCap.DataSource = NhaCungCap_BUS.search_NhaCungCap(NhaCungCap_DTO);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm nhà cung cấp??", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                NhaCungCap_DTO NhaCungCap_DTO = new NhaCungCap_DTO();
                NhaCungCap_DTO.MaNCC = txt_MaNCC.Text;
                if (NhaCungCap_BUS.search_NhaCungCap(NhaCungCap_DTO).Rows.Count > 0)
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại!");
                    txt_MaNCC.Focus();
                    return;
                }
                string sdt = txt_DienThoai.Text;
                if (sdt.Length != 10 || sdt[0] != '0')
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                    txt_DienThoai.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_Email.Text))
                {
                    MessageBox.Show("Email không được để trống!");
                    txt_Email.Focus();
                    return;
                }
                if (!IsValidEmail(txt_Email.Text))
                {
                    MessageBox.Show("Email không hợp lệ!");
                    txt_Email.Focus();
                    return;
                }
                NhaCungCap_DTO.Email = txt_Email.Text;
                NhaCungCap_DTO.DiaChi = txt_DiaChi.Text;
                NhaCungCap_DTO.Phone = txt_DienThoai.Text;
                NhaCungCap_DTO.TenSP = txt_TenSP.Text;
                NhaCungCap_BUS.insert_NhaCungCap(NhaCungCap_DTO);
                frm_NhaCungCap_Load(sender, e);
                clear();
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            NhaCungCap_DTO NhaCungCap_DTO = new NhaCungCap_DTO();
            NhaCungCap_DTO.MaNCC = txt_MaNCC.Text;
            if (NhaCungCap_BUS.search_NhaCungCap(NhaCungCap_DTO).Rows.Count < 1)
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại!");
                txt_MaNCC.Focus();
                return;
            }
            DialogResult result=MessageBox.Show("Bạn chắc chắn muốn xóa không", "Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_NhaCungCap_Load(sender, e);
                NhaCungCap_BUS.delete_NhaCungCap(NhaCungCap_DTO);
            }
            clear();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa nhà cung cấp??", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                NhaCungCap_DTO NhaCungCap_DTO = new NhaCungCap_DTO();
                NhaCungCap_DTO.MaNCC = txt_MaNCC.Text;
                if (NhaCungCap_BUS.search_NhaCungCap(NhaCungCap_DTO).Rows.Count < 1)
                {
                    MessageBox.Show("Mã nhà cung cấp không tồn tại!");
                    txt_MaNCC.Focus();
                    return;
                }
                string sdt = txt_DienThoai.Text;
                if (sdt.Length != 10 || sdt[0] != '0')
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                    txt_DienThoai.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txt_Email.Text))
                {
                    MessageBox.Show("Email không được để trống!");
                    txt_Email.Focus();
                    return;
                }
                if (!IsValidEmail(txt_Email.Text))
                {
                    MessageBox.Show("Email không hợp lệ!");
                    txt_Email.Focus();
                    return;
                }
                NhaCungCap_DTO.Email = txt_Email.Text;
                NhaCungCap_DTO.DiaChi = txt_DiaChi.Text;
                NhaCungCap_DTO.Phone = txt_DienThoai.Text;
                NhaCungCap_DTO.TenSP = txt_TenSP.Text;
                NhaCungCap_BUS.update_NhaCungCap(NhaCungCap_DTO);
                frm_NhaCungCap_Load(sender, e);
                clear();
            }
        }
        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_NhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_NhaCungCap_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_NhaCungCap.SelectedRows.Count > 0)
                {
                    txt_MaNCC.Text = dgv_NhaCungCap.SelectedRows[0].Cells[0].Value.ToString();
                    txt_DiaChi.Text = dgv_NhaCungCap.SelectedRows[0].Cells[1].Value.ToString();
                    txt_DienThoai.Text = dgv_NhaCungCap.SelectedRows[0].Cells[2].Value.ToString();
                    txt_Email.Text = dgv_NhaCungCap.SelectedRows[0].Cells[3].Value.ToString();
                    txt_TenSP.Text = dgv_NhaCungCap.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
            catch { }
        }

        private void btn_TimSP_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbb_MaNCC.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã nhà cung cấp");
                    return;
                }
                string str = $@"select * from nhacungcap where mancc='{cbb_MaNCC.Text}'";
                dgv_NhaCungCap.DataSource = Database.LoadData(str);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy ");
            }
        }
    }
}
