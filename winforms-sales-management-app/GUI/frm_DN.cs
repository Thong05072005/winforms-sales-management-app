using DoAnTheoMoHinh3Lop.BUS;
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
    public partial class frm_DN : Form
    {
        TaiKhoan_BUS taiKhoan_bus = new TaiKhoan_BUS();
        public bool kiemTraNhap()
        {
            if (txt_TenTK.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tài khoản");
                txt_TenTK.Focus();
                return false;
            }
            if (txt_MatKhau.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                txt_MatKhau.Focus();
                return false;
            }
            return true;
        }
        public void lamSach()
        {
            txt_MatKhau.Text = "";
            txt_TenTK.Text = "";
        }
        public frm_DN()
        {
            InitializeComponent();
        }
        private void frm_DN_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; // Ẩn cả nút X (Close), Minimize, Maximize

        }
        public int chonLoaiDangNhap;
        
        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {
            int loai;
            frm_main main = new frm_main();
            if (kiemTraNhap() == false)
            {
                lamSach();
                return;
            }
            //Kiểm tra check
           

            //Admin đăng nhập
            
            if (rdb_Admin.Checked)
            {
                if (txt_TenTK.Text == "Admin@gmail.com" && txt_MatKhau.Text == "123")
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide(); // Ẩn form đăng nhập
                    frm_main mainForm = new frm_main();
                    mainForm.FormClosed += (s, args) => this.Show(); // Khi form main đóng thì hiện lại form login
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    return;
                }
            }
            //Nhân viên đăng nhập

            else if (rdb_NVBH.Checked)
            {
                loai = 1;
                if (taiKhoan_bus.KiemTraTK(txt_TenTK.Text, txt_MatKhau.Text, loai) == 1)
                {
                    MessageBox.Show("Đăng nhập thành công");

                    this.Hide(); // Ẩn form login
                    frm_main gd = new frm_main();
                    //gd.loai = 1;// Gửi loại vào form chính

                    this.Hide(); // Ẩn form đăng nhập
                    gd.FormClosed += (s, args) => this.Show(); // Khi form main đóng thì hiện lại form login
                    gd.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    lamSach();
                }
            }
            else if (rdb_NVNH.Checked)
            {
                {
                    loai = 2;
                    if (taiKhoan_bus.KiemTraTK(txt_TenTK.Text, txt_MatKhau.Text, loai) == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công");

                        this.Hide(); // Ẩn form login
                        frm_main gd = new frm_main();
                        //gd.loai = 2;// Gửi loại vào form chính

                        this.Hide(); // Ẩn form đăng nhập
                        gd.FormClosed += (s, args) => this.Show(); // Khi form main đóng thì hiện lại form login
                        gd.Show();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại");
                        lamSach();
                    }
                }
            }
        }
    }
}
