using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DangNhap_BUS
    {
        public static List<DangNhap_DTO> DangNhap(string truyvan)
        {
            return DangNhap_DAO.DangNhap(truyvan);
        }
    }
}
