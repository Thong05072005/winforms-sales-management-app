namespace DoAnTheoMoHinh3Lop.GUI
{
    partial class frm_ThongKe
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
            this.gb_ThongTinKH = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cbb_LoiNhuan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_SanPham = new System.Windows.Forms.RadioButton();
            this.rdb_KhachHang = new System.Windows.Forms.RadioButton();
            this.rdb_LoiNhuan = new System.Windows.Forms.RadioButton();
            this.dtp_NgayThangNam = new System.Windows.Forms.DateTimePicker();
            this.cbb_SanPham = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_KhachHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_DaTa = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_ThongTinKH.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DaTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ThongTinKH
            // 
            this.gb_ThongTinKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gb_ThongTinKH.Controls.Add(this.btn_Clear);
            this.gb_ThongTinKH.Controls.Add(this.btn_Thoat);
            this.gb_ThongTinKH.Controls.Add(this.cbb_LoiNhuan);
            this.gb_ThongTinKH.Controls.Add(this.groupBox1);
            this.gb_ThongTinKH.Controls.Add(this.cbb_SanPham);
            this.gb_ThongTinKH.Controls.Add(this.label4);
            this.gb_ThongTinKH.Controls.Add(this.cbb_KhachHang);
            this.gb_ThongTinKH.Controls.Add(this.label3);
            this.gb_ThongTinKH.Controls.Add(this.label2);
            this.gb_ThongTinKH.Controls.Add(this.pictureBox3);
            this.gb_ThongTinKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_ThongTinKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ThongTinKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gb_ThongTinKH.Location = new System.Drawing.Point(0, 84);
            this.gb_ThongTinKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_ThongTinKH.Name = "gb_ThongTinKH";
            this.gb_ThongTinKH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_ThongTinKH.Size = new System.Drawing.Size(1924, 268);
            this.gb_ThongTinKH.TabIndex = 14;
            this.gb_ThongTinKH.TabStop = false;
            this.gb_ThongTinKH.Text = "          Thông tin khách hàng:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Clear.Image = global::DoAnTheoMoHinh3Lop.Properties.Resources.Clear;
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.Location = new System.Drawing.Point(1505, 155);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(120, 76);
            this.btn_Clear.TabIndex = 69;
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Thoat.Image = global::DoAnTheoMoHinh3Lop.Properties.Resources.Exit;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(1505, 66);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(120, 76);
            this.btn_Thoat.TabIndex = 68;
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // cbb_LoiNhuan
            // 
            this.cbb_LoiNhuan.FormattingEnabled = true;
            this.cbb_LoiNhuan.Items.AddRange(new object[] {
            "Lợi nhuận trong ngày",
            "Lợi nhuận trong tháng",
            "Lợi nhuận trong năm",
            "Lợi nhuận của từng sản phẩm trong tháng"});
            this.cbb_LoiNhuan.Location = new System.Drawing.Point(695, 69);
            this.cbb_LoiNhuan.Name = "cbb_LoiNhuan";
            this.cbb_LoiNhuan.Size = new System.Drawing.Size(739, 33);
            this.cbb_LoiNhuan.TabIndex = 67;
            this.cbb_LoiNhuan.SelectedIndexChanged += new System.EventHandler(this.cbb_LoiNhuan_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_SanPham);
            this.groupBox1.Controls.Add(this.rdb_KhachHang);
            this.groupBox1.Controls.Add(this.rdb_LoiNhuan);
            this.groupBox1.Controls.Add(this.dtp_NgayThangNam);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 206);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ngày:";
            // 
            // rdb_SanPham
            // 
            this.rdb_SanPham.AutoSize = true;
            this.rdb_SanPham.Location = new System.Drawing.Point(20, 164);
            this.rdb_SanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_SanPham.Name = "rdb_SanPham";
            this.rdb_SanPham.Size = new System.Drawing.Size(134, 29);
            this.rdb_SanPham.TabIndex = 81;
            this.rdb_SanPham.TabStop = true;
            this.rdb_SanPham.Text = "Sản phẩm";
            this.rdb_SanPham.UseVisualStyleBackColor = true;
            this.rdb_SanPham.CheckedChanged += new System.EventHandler(this.rdb_SanPham_CheckedChanged);
            // 
            // rdb_KhachHang
            // 
            this.rdb_KhachHang.AutoSize = true;
            this.rdb_KhachHang.Location = new System.Drawing.Point(20, 123);
            this.rdb_KhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_KhachHang.Name = "rdb_KhachHang";
            this.rdb_KhachHang.Size = new System.Drawing.Size(156, 29);
            this.rdb_KhachHang.TabIndex = 80;
            this.rdb_KhachHang.TabStop = true;
            this.rdb_KhachHang.Text = "Khách hàng";
            this.rdb_KhachHang.UseVisualStyleBackColor = true;
            this.rdb_KhachHang.CheckedChanged += new System.EventHandler(this.rdb_KhachHang_CheckedChanged);
            // 
            // rdb_LoiNhuan
            // 
            this.rdb_LoiNhuan.AutoSize = true;
            this.rdb_LoiNhuan.Location = new System.Drawing.Point(20, 82);
            this.rdb_LoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_LoiNhuan.Name = "rdb_LoiNhuan";
            this.rdb_LoiNhuan.Size = new System.Drawing.Size(136, 29);
            this.rdb_LoiNhuan.TabIndex = 79;
            this.rdb_LoiNhuan.TabStop = true;
            this.rdb_LoiNhuan.Text = "Lợi nhuận";
            this.rdb_LoiNhuan.UseVisualStyleBackColor = true;
            this.rdb_LoiNhuan.CheckedChanged += new System.EventHandler(this.rdb_LoiNhuan_CheckedChanged);
            // 
            // dtp_NgayThangNam
            // 
            this.dtp_NgayThangNam.CustomFormat = "MM/dd/yyyyy";
            this.dtp_NgayThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayThangNam.Location = new System.Drawing.Point(20, 32);
            this.dtp_NgayThangNam.Name = "dtp_NgayThangNam";
            this.dtp_NgayThangNam.Size = new System.Drawing.Size(331, 34);
            this.dtp_NgayThangNam.TabIndex = 78;
            // 
            // cbb_SanPham
            // 
            this.cbb_SanPham.FormattingEnabled = true;
            this.cbb_SanPham.Items.AddRange(new object[] {
            "Sản phẩm bán chạy nhất trong tháng",
            "Sản phẩm bán chạy nhất trong năm",
            "Số lượng bán của từng sản phẩm trong tháng"});
            this.cbb_SanPham.Location = new System.Drawing.Point(695, 198);
            this.cbb_SanPham.Name = "cbb_SanPham";
            this.cbb_SanPham.Size = new System.Drawing.Size(739, 33);
            this.cbb_SanPham.TabIndex = 65;
            this.cbb_SanPham.SelectedIndexChanged += new System.EventHandler(this.cbb_SanPham_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 64;
            this.label4.Text = "Thống kê sản phẩm:";
            // 
            // cbb_KhachHang
            // 
            this.cbb_KhachHang.FormattingEnabled = true;
            this.cbb_KhachHang.Items.AddRange(new object[] {
            "Khách hàng trong ngày",
            "Khách hàng trong tháng",
            "Khách hàng trong năm",
            "Khách hàng mua hàng nhiều nhất trong tháng",
            "Khách hàng mua hàng nhiều nhất trong năm",
            "Top khách hàng mua hàng nhiều nhất "});
            this.cbb_KhachHang.Location = new System.Drawing.Point(695, 134);
            this.cbb_KhachHang.Name = "cbb_KhachHang";
            this.cbb_KhachHang.Size = new System.Drawing.Size(739, 33);
            this.cbb_KhachHang.TabIndex = 63;
            this.cbb_KhachHang.SelectedIndexChanged += new System.EventHandler(this.cbb_KhachHang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Thống kê khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Thống kê lợi nhuận:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DoAnTheoMoHinh3Lop.Properties.Resources.icons8_information_64;
            this.pictureBox3.Location = new System.Drawing.Point(12, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 84);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnTheoMoHinh3Lop.Properties.Resources.nhanvien;
            this.pictureBox2.Location = new System.Drawing.Point(549, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(640, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.dgv_DaTa);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1924, 572);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "           Hiển thị data";
            // 
            // dgv_DaTa
            // 
            this.dgv_DaTa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DaTa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DaTa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DaTa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_DaTa.Location = new System.Drawing.Point(3, 56);
            this.dgv_DaTa.Name = "dgv_DaTa";
            this.dgv_DaTa.ReadOnly = true;
            this.dgv_DaTa.RowHeadersWidth = 51;
            this.dgv_DaTa.RowTemplate.Height = 24;
            this.dgv_DaTa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DaTa.Size = new System.Drawing.Size(1918, 513);
            this.dgv_DaTa.TabIndex = 46;
            this.dgv_DaTa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DaTa_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnTheoMoHinh3Lop.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_ThongTinKH);
            this.Controls.Add(this.panel1);
            this.Name = "frm_ThongKe";
            this.Text = "frm_ThongKe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ThongKe_Load);
            this.gb_ThongTinKH.ResumeLayout(false);
            this.gb_ThongTinKH.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DaTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ThongTinKH;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ComboBox cbb_LoiNhuan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_SanPham;
        private System.Windows.Forms.RadioButton rdb_KhachHang;
        private System.Windows.Forms.RadioButton rdb_LoiNhuan;
        private System.Windows.Forms.DateTimePicker dtp_NgayThangNam;
        private System.Windows.Forms.ComboBox cbb_SanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_KhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_DaTa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}