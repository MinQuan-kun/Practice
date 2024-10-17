using System;
namespace TichSole
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            int res = 1;
            int count = 0;
            while(n != 0)
            {
                temp = n % 10;
                if(temp % 2 !=0)
                {
                    res *= temp;
                    count ++;
                }
                n /= 10;
            }
            if(count != 0)
                Console.Write(res);
            else
                Console.Write(-1);
        }
    }
}