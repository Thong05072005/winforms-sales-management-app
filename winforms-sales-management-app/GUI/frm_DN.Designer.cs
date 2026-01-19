namespace DoAnTheoMoHinh3Lop.GUI
{
    partial class frm_DN
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_NVNH = new System.Windows.Forms.RadioButton();
            this.rdb_NVBH = new System.Windows.Forms.RadioButton();
            this.rdb_Admin = new System.Windows.Forms.RadioButton();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnTheoMoHinh3Lop.Properties.Resources.Login1;
            this.pictureBox1.Location = new System.Drawing.Point(24, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_DangNhap);
            this.groupBox1.Controls.Add(this.txt_TenTK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Location = new System.Drawing.Point(399, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 544);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_NVNH);
            this.groupBox2.Controls.Add(this.rdb_NVBH);
            this.groupBox2.Controls.Add(this.rdb_Admin);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Location = new System.Drawing.Point(43, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 126);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại đăng nhập:";
            // 
            // rdb_NVNH
            // 
            this.rdb_NVNH.AutoSize = true;
            this.rdb_NVNH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_NVNH.Location = new System.Drawing.Point(331, 61);
            this.rdb_NVNH.Name = "rdb_NVNH";
            this.rdb_NVNH.Size = new System.Drawing.Size(194, 26);
            this.rdb_NVNH.TabIndex = 2;
            this.rdb_NVNH.TabStop = true;
            this.rdb_NVNH.Text = "Nhân viên nhập hàng";
            this.rdb_NVNH.UseVisualStyleBackColor = true;
            // 
            // rdb_NVBH
            // 
            this.rdb_NVBH.AutoSize = true;
            this.rdb_NVBH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_NVBH.Location = new System.Drawing.Point(119, 61);
            this.rdb_NVBH.Name = "rdb_NVBH";
            this.rdb_NVBH.Size = new System.Drawing.Size(185, 26);
            this.rdb_NVBH.TabIndex = 1;
            this.rdb_NVBH.TabStop = true;
            this.rdb_NVBH.Text = "Nhân viên bán hàng";
            this.rdb_NVBH.UseVisualStyleBackColor = true;
            // 
            // rdb_Admin
            // 
            this.rdb_Admin.AutoSize = true;
            this.rdb_Admin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Admin.Location = new System.Drawing.Point(7, 61);
            this.rdb_Admin.Name = "rdb_Admin";
            this.rdb_Admin.Size = new System.Drawing.Size(84, 26);
            this.rdb_Admin.TabIndex = 0;
            this.rdb_Admin.TabStop = true;
            this.rdb_Admin.Text = "Admin";
            this.rdb_Admin.UseVisualStyleBackColor = true;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(200, 155);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(280, 34);
            this.txt_MatKhau.TabIndex = 20;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(38, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mật khẩu:";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DangNhap.Location = new System.Drawing.Point(43, 409);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(148, 59);
            this.btn_DangNhap.TabIndex = 18;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click_1);
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTK.Location = new System.Drawing.Point(200, 79);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(280, 34);
            this.txt_TenTK.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(38, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 53);
            this.label1.TabIndex = 15;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // frm_DN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1050, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_DN";
            this.Text = "frm_DN";
            this.Load += new System.EventHandler(this.frm_DN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_NVNH;
        private System.Windows.Forms.RadioButton rdb_NVBH;
        private System.Windows.Forms.RadioButton rdb_Admin;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}