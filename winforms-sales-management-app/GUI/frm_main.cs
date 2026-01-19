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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void mnu_NhanVien_Click(object sender, EventArgs e)
        {
            frm_NhanVien frm_NhanVien = new frm_NhanVien();
            frm_NhanVien.MdiParent = this;
            frm_NhanVien.Show();
        }

        private void mnu_KhachHang_Click(object sender, EventArgs e)
        {
            frm_KH frm_KH = new frm_KH();
            frm_KH.MdiParent = this;
            frm_KH.Show();
        }

        private void mnu_SanPham_Click(object sender, EventArgs e)
        {
            frm_SanPham frm_SanPham = new frm_SanPham();
            frm_SanPham.MdiParent = this;
            frm_SanPham.Show();
        }

        private void mnu_CTHDB_Click(object sender, EventArgs e)
        {
            frm_CTHDB frm_CTHDB = new frm_CTHDB();
            frm_CTHDB.MdiParent = this;
            frm_CTHDB.Show();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            GiaDienChinh gd = new GiaDienChinh();
            gd.MdiParent = this;
            gd.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Nhấn yes để thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhaCungCap frm_NhaCungCap = new frm_NhaCungCap();
            frm_NhaCungCap.MdiParent = this;
            frm_NhaCungCap.Show();
        }

        private void mnu_CTHDN_Click(object sender, EventArgs e)
        {
            frm_CTHDN frm_CTHDN = new frm_CTHDN();
            frm_CTHDN.MdiParent = this;
            frm_CTHDN.Show();
        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongKe frm_ThongKe = new frm_ThongKe();
            frm_ThongKe.MdiParent = this;
            frm_ThongKe.Show();
        }

        private void mnu_DangXuat_Click(object sender, EventArgs e)
        {
            frm_DN dn = new frm_DN();
            frm_main frm_Main = new frm_main();
            frm_Main.Close();
            dn.ShowDialog();

        }
    }
}
