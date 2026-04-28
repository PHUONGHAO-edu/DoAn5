using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class ChiBo_BUS
    {
        public static List<ChiBo_DTO> LayChiBo()
        {
            return ChiBo_DAO.LayChiBo();
        }

        public static bool ThemChiBo(ChiBo_DTO chibo)
        {
            return ChiBo_DAO.ThemChiBo(chibo);
        }

        public static bool SuaChiBo(ChiBo_DTO chibo)
        {
            return ChiBo_DAO.SuaChiBo(chibo);
        }

        public static bool XoaChiBo(ChiBo_DTO chibo)
        {
            return ChiBo_DAO.XoaChiBo(chibo);
        }
    }
}