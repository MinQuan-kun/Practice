using System;
namespace TCSLNT
{
    public class Program
    {
        static void Main(string[]args)
        {
            string s = Console.ReadLine();
            int tong = 0;
            foreach (char c in s)
            {
                int digit = c - '0';  
                if (!checkSNT(digit)) 
                {
                    Console.WriteLine("YESNOT");
                    return;
                }
                tong += digit;  
            }

            if (checkSNT(tong))
                Console.WriteLine("YES");
            else
                Console.WriteLine("YESNOT");
        }
        static bool checkSNT(int a)
        {
            if(a < 2)
                return false;
            for(int i = 2; i <= Math.Sqrt(a); i++)
                if(a % i == 0)
                    return false;
                return true;
        }
    }
}