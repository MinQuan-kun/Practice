using System;

namespace KiemTraSoNguyenTo
{
    public class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            string check = "true";
            if (a < 2)
            {
                check = "false";
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        check = "false";
                        break;
                    }
                }
            }
            Console.Write(check);
        }
    }
}
