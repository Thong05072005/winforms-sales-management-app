using DoAnTheoMoHinh3Lop.GUI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.DAO
{
    internal class TaiKhoan_DAO:Database
    {
        public int KiemTraTaiKhoan(string tenTK, string matkhau,int loai)
        {
            this.conn.Close();
            this.conn.Open();   
            string strQuery=string.Format("select count(*) from nhanvien where tentk='{0}' and matkhau='{1}' and loainv={2}",tenTK,matkhau,loai);
            this.cmd = new SqlCommand(strQuery, conn);
            int n=(int)this.cmd.ExecuteScalar();
            return n;
        }
    }
}
