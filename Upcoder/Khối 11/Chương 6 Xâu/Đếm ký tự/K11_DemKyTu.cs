using System;
namespace Demtu
{
    class Program
    {
        static void Main(string[]args)
        {
            // Nhập chuỗi a
            string a = Console.ReadLine();
            // Nhập ký tự cần đếm
            char kt = Console.ReadLine()[0]; // Lấy ký tự đầu tiên từ dòng nhập vào
            int dem = 0;

            // Duyệt qua từng ký tự trong chuỗi a
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == kt)
                {
                    dem++; // Tăng biến đếm nếu ký tự trùng khớp
                }
            }
            // In ra số lần ký tự kt xuất hiện
            Console.Write(dem);
        }
    }
}