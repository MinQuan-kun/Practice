using System;
namespace Vịtrikytu
{
    public class Program
    {
        static void Main(string[]args)
        {
            // Nhập chuỗi a
            string a = Console.ReadLine();

            // Nhập ký tự kt cần tìm
            char kt = Console.ReadLine()[0]; // Đọc ký tự từ bàn phím
            int vitri = a.IndexOf(kt); // Tìm vị trí đầu tiên của ký tự kt
            while (vitri != -1) // Trong C#, -1 đại diện cho không tìm thấy
            {
                Console.Write(vitri + " "); // In ra vị trí tìm được
                vitri = a.IndexOf(kt, vitri + 1); // Tìm vị trí tiếp theo của ký tự kt
            }
        }
    }
}

