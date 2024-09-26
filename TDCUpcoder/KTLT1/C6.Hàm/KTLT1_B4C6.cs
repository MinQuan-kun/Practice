using System;
namespace CheckSNT
{
    public class Program
    {
        static void Main(string[]args)
        {
            int x = int.Parse(Console.ReadLine());
            if(CheckSNT(x))
                Console.Write("SNT");
            else
                Console.Write("Khong la SNT");
        }
        static bool CheckSNT(int x)
        {
            if( x <= 1)
                return false;
             for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
        
    }
}