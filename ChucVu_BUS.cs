using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChucVu_BUS
    {
        public static List<ChucVu_DTO> LayChucVu()
        {
            return ChucVu_DAO.LayChucVu();
        }

        public static bool ThemChucVu(ChucVu_DTO cv)
        {
            return ChucVu_DAO.ThemChucVu(cv);
        }

        public static bool SuaChucVu(ChucVu_DTO cv)
        {
            return ChucVu_DAO.SuaChucVu(cv);
        }

        public static bool XoaChucVu(ChucVu_DTO cv)
        {
            return ChucVu_DAO.XoaChucVu(cv);
        }
    }
}
