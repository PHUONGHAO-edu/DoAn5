using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class SoThuDangPhi_BUS
    {
        public static List<SoThuDangPhi_DTO> LaySoThuDangPhi()
        {
            return SoThuDangPhi_DAO.LaySoThuDangPhi();
        }

        public static bool ThemSoThu(SoThuDangPhi_DTO dto)
        {
            return SoThuDangPhi_DAO.ThemSoThu(dto);
        }

        public static bool SuaSoThu(SoThuDangPhi_DTO dto)
        {
            return SoThuDangPhi_DAO.SuaSoThu(dto);
        }

        public static bool XoaSoThu(SoThuDangPhi_DTO dto)
        {
            return SoThuDangPhi_DAO.XoaSoThu(dto);
        }
    }
}
