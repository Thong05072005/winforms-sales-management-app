namespace DoAnTheoMoHinh3Lop.Report
{
    partial class frm_InCTHDB
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
            this.rpt_InHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpt_InHoaDon
            // 
            this.rpt_InHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_InHoaDon.LocalReport.ReportEmbeddedResource = "DoAnTheoMoHinh3Lop.Report.CTHDB_REPORT.rdlc";
            this.rpt_InHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rpt_InHoaDon.Name = "rpt_InHoaDon";
            this.rpt_InHoaDon.ServerReport.BearerToken = null;
            this.rpt_InHoaDon.Size = new System.Drawing.Size(1381, 781);
            this.rpt_InHoaDon.TabIndex = 0;
            // 
            // frm_InCTHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 781);
            this.Controls.Add(this.rpt_InHoaDon);
            this.Name = "frm_InCTHDB";
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.frm_InCTHDB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_InHoaDon;
    }
}