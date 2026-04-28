using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class KhenThuong_BUS
    {
        public static List<KhenThuong_DTO> LayKhenThuong()
        {
            return KhenThuong_DAO.LayKhenThuong();
        }

        public static bool ThemKhenThuong(KhenThuong_DTO kt)
        {
            return KhenThuong_DAO.ThemKhenThuong(kt);
        }

        public static bool SuaKhenThuong(KhenThuong_DTO kt)
        {
            return KhenThuong_DAO.SuaKhenThuong(kt);
        }

        public static bool XoaKhenThuong(KhenThuong_DTO kt)
        {
            return KhenThuong_DAO.XoaKhenThuong(kt);
        }
    }
}