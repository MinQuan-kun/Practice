using System;
namespace TinhDTB
{
    class Program
    {
        static void Main(string[]args)
        {
            double Toan = double.Parse(Console.ReadLine());
            double Ly = double.Parse(Console.ReadLine());
            double Hoa = double.Parse(Console.ReadLine());
            double res = (Toan + Ly + Hoa)/3f;
            //res = (double)Math.Round(res,2);
            Console.WriteLine("{0:F2}",res);
        }
    }
}