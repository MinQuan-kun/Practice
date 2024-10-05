using System;
namespace SHT
{
    public class Program
    {
        static void Main(string[]args)
        {
            int temp = -1;
            int []arr = new int[5];
            for(int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if(SHT(arr[i]))
                    temp = i;
            }
            if(temp == -1)
                Console.Write("-1");
            else
                Console.Write(arr[temp]);
        }
        static bool SHT(int x)
        {
            int tong = 0;
            for (int i = 1; i <= x / 2; i++) // Chạy đến x / 2
                if (x % i == 0)
                    tong += i;
            return tong == x; // Trả về true nếu là số hoàn hảo
        }
    }
}
