using DoAnTheoMoHinh3Lop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTheoMoHinh3Lop.BUS
{
    internal class CTHDN_BUS
    {
        CTHDN_DAO CTHDN_DAO = new CTHDN_DAO();
        public DataTable select_CTHDN()
        {
            return CTHDN_DAO.select_CTHDN();
        }
        public bool insert_CTHDN(CTHDN_DTO CTHDN_DTO)
        {
            return CTHDN_DAO.insert_CTHDN(CTHDN_DTO);
        }
        public bool delete_CTHDN(CTHDN_DTO CTHDN_DTO)
        {
            return CTHDN_DAO.delete_CTHDN(CTHDN_DTO);
        }
        public DataTable search_CTHDN(CTHDN_DTO CTHDN_DTO)
        {
            return CTHDN_DAO.search_CTHDN(CTHDN_DTO);
        }
    }
}
