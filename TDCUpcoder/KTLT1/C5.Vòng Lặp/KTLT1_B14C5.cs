using System;
namespace Songuoc
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int soNguoc = 0;

            while (n > 0)
            {
                int chuSoCuoi = n % 10;  
                soNguoc = soNguoc * 10 + chuSoCuoi; 
                n /= 10;  
            }

            Console.WriteLine(soNguoc);
        }  
    }
}