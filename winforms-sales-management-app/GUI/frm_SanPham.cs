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
    public partial class frm_SanPham : Form
    {
        SanPham_BUS sp_BUS = new SanPham_BUS();
        Database db = new Database();
        public frm_SanPham()
        {
            InitializeComponent();
        }
        public void hienThiSP()
        {
            dgv_SP.DataSource = sp_BUS.hienTTSP();
            txt_TenSP.Focus();
        }
        public bool kiemTraNhap()
        {
            if (txt_TenSP.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sản phẩm!!!");
                txt_TenSP.Focus();
                return false;
            }
            if (float.Parse(txt_GiaSP.Text) < 0)
            {
                MessageBox.Show("Giá sản phẩm không được âm!!!");
                txt_GiaSP.Focus();
            }
            return true;
        }
        public void select_MaSP()
        {
            cbb_MaSP.DataSource = sp_BUS.hienTTSP();
            cbb_MaSP.ValueMember = "masp";
            cbb_MaSP.DisplayMember = "tensp";
        }
        private void frm_SanPham_Load(object sender, EventArgs e)
        {

            dgv_SP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hienThiSP();
            select_MaSP();
            cbb_MaSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbb_MaSP.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        public void select_SPTheoGia(float giaTu, float giaDen)
        {
            dgv_SP.DataSource = db.LoadData(string.Format("select*from sanpham where giasp>={0} and giasp<={1}", giaTu, giaDen));
        }

        public void select_GiaSP_C_T()
        {
            dgv_SP.DataSource = db.LoadData("select*from sanpham order by GiaSP desc");
        }
        public void select_GiaSP_T_C()
        {
            dgv_SP.DataSource = db.LoadData("select*from sanpham order by GiaSP");
        }
        public void select_Ten()
        {
            dgv_SP.DataSource = db.LoadData("select*from sanpham order by tensp");
        }
        public bool checkGia(float gia)
        {
            if (gia >= 0)
            {
                return true;
            }
            MessageBox.Show("Không được để trống giá!!!");
            txt_Tu.Focus();
            return false;
        }
        private void btn_tai_anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                string anh = open.FileName;
                pic_AnhSP.ImageLocation = anh;
            }
        }
        public void lamSach()
        {
            txt_TenSP.Text = "";
            txt_GiaSP.Text = "";
            txt_MaSP.Text = "";
            nud_SoLuongCon.Value = 1;
            pic_AnhSP.ImageLocation = null;
            txt_TenSP.Focus();
            hienThiSP();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lamSach();
        }

        private void dgv_SP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_MaSP.Text = dgv_SP[0, dgv_SP.CurrentRow.Index].Value.ToString();
                txt_TenSP.Text = dgv_SP[1, dgv_SP.CurrentRow.Index].Value.ToString();
                txt_GiaSP.Text = dgv_SP[2, dgv_SP.CurrentRow.Index].Value.ToString();
                nud_SoLuongCon.Text = dgv_SP[3, dgv_SP.CurrentRow.Index].Value.ToString();
                pic_AnhSP.Image = Image.FromFile(dgv_SP[4, dgv_SP.CurrentRow.Index].Value.ToString());
            }
            catch
            {

            }
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            try
            {
                float giaTu = float.Parse(txt_Tu.Text);
                if (checkGia(giaTu) == false)
                {
                    MessageBox.Show("Giá không được âm, mời nhập lại:");
                    txt_Tu.Focus();
                    txt_Tu.Text = "";
                }
                float giaDen = float.Parse(txt_GiaDen.Text);
                if (checkGia(giaDen) == false)
                {
                    MessageBox.Show("Giá không được âm, mời nhập lại:");
                    txt_GiaDen.Focus();
                    txt_GiaDen.Text = "";
                }
                select_SPTheoGia(giaTu, giaDen);


            }
            catch
            {
                MessageBox.Show("Không được nhập kí tự!!!");
            }


        }

        private void btn_ThemSP_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (kiemTraNhap())
                {
                    SanPham_DTO sp_DTO = new SanPham_DTO();


                    sp_DTO.MaSP = txt_MaSP.Text;
                    sp_DTO.MaSP = txt_MaSP.Text;
                    sp_DTO.TenSP = txt_TenSP.Text;
                    sp_DTO.GiaSP = float.Parse(txt_GiaSP.Text);
                    sp_DTO.SoLuongCon = int.Parse(nud_SoLuongCon.Text);
                    sp_DTO.Anh = pic_AnhSP.ImageLocation;

                    //Kiêm tra trùng tên

                    string strQuery = string.Format("select count(*) from sanpham where masp='{0}'", txt_MaSP.Text);

                    if (db.kiemTraTonTai(strQuery) == 1)
                    {
                        MessageBox.Show("Sản phẩm tồn tại");
                        return;
                    }

                    if (sp_BUS.insert_SP(sp_DTO))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công");
                        hienThiSP();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_XoaSP_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm??", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (kiemTraNhap())
                    {
                        try
                        {
                            SanPham_DTO sp_DTO = new SanPham_DTO();
                            sp_DTO.MaSP = txt_MaSP.Text;
                            if (sp_BUS.delete_SP(sp_DTO))
                            {
                                MessageBox.Show("Xóa sản phẩm thành công");
                                hienThiSP();
                                lamSach();
                                select_MaSP();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Sản phẩm không thể xóa vì đang còn trong chi tiết hóa đơn!!!");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_SuaSP_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa sản phẩm??", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (kiemTraNhap() == false)
                    {
                        return;
                    }
                    SanPham_DTO sp_DTO = new SanPham_DTO();
                    sp_DTO.MaSP = txt_MaSP.Text;
                    sp_DTO.TenSP = txt_TenSP.Text;
                    sp_DTO.GiaSP = float.Parse(txt_GiaSP.Text);
                    sp_DTO.SoLuongCon = int.Parse(nud_SoLuongCon.Text);
                    sp_DTO.Anh = pic_AnhSP.ImageLocation;
                    if (sp_BUS.update_SP(sp_DTO))
                    {
                        MessageBox.Show("Sửa sản phẩm thành công");
                        hienThiSP();
                        select_MaSP();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sữa thất bại");
            }
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            lamSach();
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Nhấn yes để thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_TimSP_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (cbb_MaSP.Text == "")
                {
                    MessageBox.Show("Không được để trống");
                    return;
                }
                string masp = cbb_MaSP.SelectedValue.ToString();
                dgv_SP.DataSource = db.LoadData(string.Format("select * from sanpham where masp='{0}'", masp));
            }
            catch
            {
                MessageBox.Show("Không tìm thấy sản phẩm");
            }

        }

        private void cbb_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_SapXep.Text == "giá (cao->thấp)")
            {
                select_GiaSP_C_T();
            }
            else if (cbb_SapXep.Text == "giá (thấp->cao)")
                select_GiaSP_T_C();
            else
            {
                select_Ten();
            }
        }


        private void txt_TenSP_TextChanged(object sender, EventArgs e)
        {
            txt_MaSP.Text = "SP" + txt_TenSP.Text.Replace(" ", "");
        }
    }
}
