using DoAnTheoMoHinh3Lop.BUS;
using DoAnTheoMoHinh3Lop.DAO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAnTheoMoHinh3Lop.Report
{
    public partial class frm_InCTHDB : Form
    {
        Database db = new Database();
        CTHDB_BUS cthdb_BUS=new CTHDB_BUS();    
        public frm_InCTHDB()
        {
            InitializeComponent();
        }
        public int maHoaDon;
        private void frm_InCTHDB_Load(object sender, EventArgs e)
        {
            
            string strQuery1 = string.Format("select masp, mahdb,soluongban,tongdongiaban from cthdb");

            SqlDataAdapter adapter = new SqlDataAdapter(strQuery1, db.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "CTHDB");

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["CTHDB"];

            this.rpt_InHoaDon.LocalReport.DataSources.Add(rds);
            this.rpt_InHoaDon.RefreshReport();
        }
    }
}
