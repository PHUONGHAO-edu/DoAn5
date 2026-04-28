using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyCanBo_BUS
    {
        public static List<QuanLyCanBo_DTO> LayCanBo()
        {
            return QuanLyCanBo_DAO.LayCanBo();
        }
        public static bool ThemCanBo(QuanLyCanBo_DTO nv)
        {
            return QuanLyCanBo_DAO.ThemCanBo(nv);
        }

        public static bool XoaCanBo(QuanLyCanBo_DTO nv)
        {
            return QuanLyCanBo_DAO.XoaCanBo(nv);
        }

        public static bool SuaCanBo(QuanLyCanBo_DTO nv)
        {
            return QuanLyCanBo_DAO.SuaCanBo(nv);
        }

    }
}
