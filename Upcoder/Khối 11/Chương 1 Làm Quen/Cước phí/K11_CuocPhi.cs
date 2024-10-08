using System;
namespace Cuocphi
{
    public class Program
    {
        static void Main(string[]args)
        {
            double x = double.Parse(Console.ReadLine());
            double tien = 3000;
            if (x < 0)
            {
                Console.Write("NHAP SAI");
            }
            else
            {
                if( x - (int)x >= 0.5)
                    x = (int)x + 1;
                else
                    x = (int)x;
                if(x == 0)
                    tien = 0;
                else if(x == 1)
                    tien = 3000;
                else if(x >= 2 && x <= 10)
                    tien = tien + (x - 1) * 2000;
                else if(x >= 11)
                    tien = tien + 9 * 2000 + (x - 10) * 1500;
                Console.Write(tien);
            }
        }
    }
}