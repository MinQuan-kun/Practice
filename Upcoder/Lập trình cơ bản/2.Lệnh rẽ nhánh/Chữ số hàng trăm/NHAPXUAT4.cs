using System;
namespace Chứsốhàngtrăm
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp, res = 0;
            while(n != 0)
            {
                temp = n % 10;
                count ++;
                if(count == 3)
                    res = temp;
                n /= 10;
            }
            if(count < 3)
                Console.Write(-1);
            else
                Console.Write(res);
        }
    }
}