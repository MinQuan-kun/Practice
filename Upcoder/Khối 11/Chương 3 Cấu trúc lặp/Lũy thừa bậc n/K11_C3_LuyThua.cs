using System;

namespace LuyThua
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Nhập giá trị x và n từ bàn phím
            string[] input = Console.ReadLine().Split(' ');
            int x = int.Parse(input[0]);
            int n = int.Parse(input[1]);

            // Kiểm tra điều kiện
            if (n < 0)
            {
                Console.WriteLine(1);
                return;
            }
            if (n == 0)
            {
                Console.WriteLine(1);
                return;
            }

            int s = x; // Khởi tạo s = x

            // Vòng lặp từ 1 đến n-1
            for (int i = 1; i < n; i++)
            {
                s *= x; // Nhân s với x
            }

            // In ra kết quả
            Console.WriteLine(s);
        }
    }
}
