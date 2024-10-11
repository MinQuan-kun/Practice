using System;
namespace Đếmsốlẻ
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = 0, count = 0;
            while(n != 0)
            {
                temp = n % 10;
                if(temp % 2 != 0)
                    count += 1;
                n /= 10;
            }
            Console.Write(count);
        }
    }
}