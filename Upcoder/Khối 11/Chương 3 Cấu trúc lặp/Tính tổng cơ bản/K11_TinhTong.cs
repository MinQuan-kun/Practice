using System;

namespace TongSo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Nhập giá trị n từ bàn phím
            int n = int.Parse(Console.ReadLine());

            int s = 0; // Khởi tạo tổng bằng 0

            // Kiểm tra nếu n < 0
            if (n < 0)
            {
                Console.WriteLine("NHAP SAI");
            }
            else
            {
                // Vòng lặp từ 0 đến n
                for (int i = 0; i <= n; i++)
                {
                    s += i; // Cộng dồn các giá trị từ 0 đến n vào s
                }

                // In ra tổng giá trị
                Console.WriteLine(s);
            }
        }
    }
}
