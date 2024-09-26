using System;
namespace Daonguoc
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int soNguoc = 0;

            while (temp > 0)
            {
                int chuSoCuoi = temp % 10;  
                soNguoc = soNguoc * 10 + chuSoCuoi; 
                temp /= 10;  
            }
            if (soNguoc == n)
                Console.Write("TRUE");
            else
                Console.Write("FALSE");
        }  
    }
}