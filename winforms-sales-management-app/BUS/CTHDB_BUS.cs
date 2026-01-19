using DoAnTheoMoHinh3Lop.DAO;
using DoAnTheoMoHinh3Lop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.BUS
{
    internal class CTHDB_BUS
    {
        CTHDB_DAO cthdb_DAO = new CTHDB_DAO();
        public DataTable get_CTHDB()
        {
            return cthdb_DAO.select_CTHDB();
        }
        public bool insert_HDB(CTHDB_DTO cthdb_DTO, HoaDonBan_DTO hdb_DT)
        {
            return cthdb_DAO.insert_CTHDB(cthdb_DTO, hdb_DT);
        }

        public bool delete_HDB(CTHDB_DTO cthdb_DTO)
        {
            return cthdb_DAO.delete_CTHDB(cthdb_DTO);
        }
    }
}
