using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAO;
namespace BUS
{
    public class CSDL_BUS
    {
        public static bool SaoLuu(string sDuongDan)
        {
            return CSDL_DAO.SaoLuuDuLieu(sDuongDan);
        }

        public static bool PhucHoi(string sDuongDan)
        {
            try
            {
                // Kiểm tra xem tệp sao lưu có tồn tại không
                if (!File.Exists(sDuongDan))
                {
                    Console.WriteLine("Không tìm thấy tệp sao lưu.");
                    return false;
                }

                // Dừng bất kỳ dịch vụ hoặc quy trình cơ sở dữ liệu đang chạy nếu cần thiết

                // Phục hồi cơ sở dữ liệu từ tệp sao lưu
                bool phucHoiThanhCong = CSDL_DAO.PhucHoiDuLieu(sDuongDan);

                // Tùy chọn, khởi động lại bất kỳ dịch vụ hoặc quy trình cơ sở dữ liệu đã dừng

                if (phucHoiThanhCong)
                {
                    Console.WriteLine("Phục hồi dữ liệu thành công.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Lỗi khi phục hồi dữ liệu.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi phục hồi dữ liệu: " + ex.Message);
                return false;
            }
        }
    }
}
