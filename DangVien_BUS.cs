using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class DangVien_BUS
    {
        public static List<DangVien_DTO> LayDangVien()
        {
            return DangVien_DAO.LayDangVien();
        }

        public static bool ThemDangVien(DangVien_DTO dv)
        {
            return DangVien_DAO.ThemDangVien(dv);
        }
    
    public static List<DangVien_DTO> TimKiemTen(string ten)
        {
            return DangVien_DAO.TimKiemTen(ten);
        }

        public static bool SuaDangVien(DangVien_DTO dv)
        {
            return DangVien_DAO.SuaDangVien(dv);
        }

        public static bool XoaDangVien(DangVien_DTO dv)
        {
            return DangVien_DAO.XoaDangVien(dv);
        }
    }
}