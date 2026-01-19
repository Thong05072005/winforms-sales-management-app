namespace DoAnTheoMoHinh3Lop.GUI
{
    partial class DoanhThucs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdb_DoanhThuNam = new System.Windows.Forms.RadioButton();
            this.rdb_DoanhThuTuan = new System.Windows.Forms.RadioButton();
            this.rdb_DoanhThuThang = new System.Windows.Forms.RadioButton();
            this.dgv_DoanhThu = new System.Windows.Forms.DataGridView();
            this.TongTienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.rdb_DoanhThuNam);
            this.groupBox3.Controls.Add(this.rdb_DoanhThuTuan);
            this.groupBox3.Controls.Add(this.rdb_DoanhThuThang);
            this.groupBox3.Controls.Add(this.dgv_DoanhThu);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1924, 629);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "           Hiển Thị Doanh Thu";
            // 
            // rdb_DoanhThuNam
            // 
            this.rdb_DoanhThuNam.AutoSize = true;
            this.rdb_DoanhThuNam.Location = new System.Drawing.Point(988, 93);
            this.rdb_DoanhThuNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_DoanhThuNam.Name = "rdb_DoanhThuNam";
            this.rdb_DoanhThuNam.Size = new System.Drawing.Size(179, 29);
            this.rdb_DoanhThuNam.TabIndex = 49;
            this.rdb_DoanhThuNam.TabStop = true;
            this.rdb_DoanhThuNam.Text = "Doanh thu năm";
            this.rdb_DoanhThuNam.UseVisualStyleBackColor = true;
            this.rdb_DoanhThuNam.CheckedChanged += new System.EventHandler(this.rdb_DoanhThuNam_CheckedChanged);
            // 
            // rdb_DoanhThuTuan
            // 
            this.rdb_DoanhThuTuan.AutoSize = true;
            this.rdb_DoanhThuTuan.Location = new System.Drawing.Point(988, 198);
            this.rdb_DoanhThuTuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_DoanhThuTuan.Name = "rdb_DoanhThuTuan";
            this.rdb_DoanhThuTuan.Size = new System.Drawing.Size(180, 29);
            this.rdb_DoanhThuTuan.TabIndex = 48;
            this.rdb_DoanhThuTuan.TabStop = true;
            this.rdb_DoanhThuTuan.Text = "Doanh thu tuần";
            this.rdb_DoanhThuTuan.UseVisualStyleBackColor = true;
            this.rdb_DoanhThuTuan.CheckedChanged += new System.EventHandler(this.rdb_DoanhThuTuan_CheckedChanged);
            // 
            // rdb_DoanhThuThang
            // 
            this.rdb_DoanhThuThang.AutoSize = true;
            this.rdb_DoanhThuThang.Location = new System.Drawing.Point(988, 150);
            this.rdb_DoanhThuThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_DoanhThuThang.Name = "rdb_DoanhThuThang";
            this.rdb_DoanhThuThang.Size = new System.Drawing.Size(192, 29);
            this.rdb_DoanhThuThang.TabIndex = 47;
            this.rdb_DoanhThuThang.TabStop = true;
            this.rdb_DoanhThuThang.Text = "Doanh thu tháng";
            this.rdb_DoanhThuThang.UseVisualStyleBackColor = true;
            this.rdb_DoanhThuThang.CheckedChanged += new System.EventHandler(this.rdb_DoanhThuThang_CheckedChanged);
            // 
            // dgv_DoanhThu
            // 
            this.dgv_DoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TongTienNhap,
            this.TongTienBan,
            this.DoanhThu});
            this.dgv_DoanhThu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DoanhThu.Location = new System.Drawing.Point(3, 288);
            this.dgv_DoanhThu.Name = "dgv_DoanhThu";
            this.dgv_DoanhThu.ReadOnly = true;
            this.dgv_DoanhThu.RowHeadersWidth = 51;
            this.dgv_DoanhThu.RowTemplate.Height = 24;
            this.dgv_DoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DoanhThu.Size = new System.Drawing.Size(1918, 338);
            this.dgv_DoanhThu.TabIndex = 46;
            // 
            // TongTienNhap
            // 
            this.TongTienNhap.HeaderText = "Tổng tiền nhập";
            this.TongTienNhap.MinimumWidth = 8;
            this.TongTienNhap.Name = "TongTienNhap";
            this.TongTienNhap.ReadOnly = true;
            // 
            // TongTienBan
            // 
            this.TongTienBan.HeaderText = "Tổng tiền bán";
            this.TongTienBan.MinimumWidth = 8;
            this.TongTienBan.Name = "TongTienBan";
            this.TongTienBan.ReadOnly = true;
            // 
            // DoanhThu
            // 
            this.DoanhThu.HeaderText = "Doanh Thu";
            this.DoanhThu.MinimumWidth = 8;
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnTheoMoHinh3Lop.Properties.Resources.database;
            this.pictureBox2.Location = new System.Drawing.Point(12, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1924, 84);
            this.panel3.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnTheoMoHinh3Lop.Properties.Resources.information;
            this.pictureBox1.Location = new System.Drawing.Point(655, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(762, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(684, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "QUẢN LÝ DOANH THU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DoanhThucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 966);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel3);
            this.Name = "DoanhThucs";
            this.Text = "DoanhThucs";
            this.Load += new System.EventHandler(this.DoanhThucs_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdb_DoanhThuNam;
        private System.Windows.Forms.RadioButton rdb_DoanhThuTuan;
        private System.Windows.Forms.RadioButton rdb_DoanhThuThang;
        private System.Windows.Forms.DataGridView dgv_DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}