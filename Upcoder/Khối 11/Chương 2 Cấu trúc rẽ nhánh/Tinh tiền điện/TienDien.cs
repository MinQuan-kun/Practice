using System;
namespace Tiendien
{
    public class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int tien = 2500;
            if(x < 0)
                Console.Write("NHAP SAI");
            else
            {
                if(x <= 50)
                    tien *= x;
                else if(x >= 51 && x <= 100)
                    tien = tien * 50 + (x - 50) * 3000;
                else if(x >= 101 && x <= 200)
                    tien = tien * 50 + 3000 * 50 + (x - 100) * 5000;
                else if(x > 200)
                    tien = -1;
                if(tien == -1)
                     Console.Write("CAT DIEN");
                else
                    Console.Write(tien);
            }
        }
    }
}