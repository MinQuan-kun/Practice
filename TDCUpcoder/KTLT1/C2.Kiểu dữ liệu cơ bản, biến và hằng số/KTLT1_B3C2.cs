using System;
namespace tuoiHienTai
{
    class Program 
    {
        static void Main(string[] args) {
        int namSinh = int.Parse(Console.ReadLine());
        // Lấy năm hiện tại
        int namHienTai = DateTime.Now.Year - 1;
        // Tính tuổi hiện tại
        int tuoiHienTai = namHienTai - namSinh;
        // Tính năm về hưu (60 tuổi)
        int namVeHuu = namSinh + 60;
        // Hiển thị kết quả
        Console.Write(tuoiHienTai);
        Console.Write(" {0}", namVeHuu);
        }
    }
}
