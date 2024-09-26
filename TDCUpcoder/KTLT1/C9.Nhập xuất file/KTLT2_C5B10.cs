using System;
using System.IO;

namespace Hanghoa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Đọc toàn bộ nội dung file Input.txt
            string[] lines = File.ReadAllLines("Input.txt");

            // Dòng đầu tiên là số lượng mặt hàng
            int n = int.Parse(lines[0]);

            // Mở file Output.txt để ghi
            using (StreamWriter writer = new StreamWriter("Output.txt"))
            {
                // Duyệt qua từng mặt hàng trong file Input.txt
                for (int i = 1; i <= n; i++)
                {
                    // Mỗi dòng được tách bởi dấu '#'
                    string[] items = lines[i].Split('#');

                    // Lấy thông tin từ các mục
                    string maHang = items[0];
                    string tenHang = items[1];
                    int soLuong = int.Parse(items[2]);
                    int donGia = int.Parse(items[3]);

                    // Tính tiền hàng
                    int tienHang = soLuong * donGia;

                    // Ghi thông tin vào file Output.txt theo định dạng MaHang-TenHang-SL-DonGia-TienHang
                    writer.WriteLine($"{maHang}-{tenHang}-{soLuong}-{donGia}-{tienHang}");
                }
            }

        }
    }
}
