using System;
namespace Dathuc
{
    public class Program
    {
        static void Main(string[]args)
        {
            double x = double.Parse(Console.ReadLine());
            if (x < 2.5)
            {
                Console.WriteLine("NHAP SAI");
            }
            else
            {
                double A = Math.Sqrt(2 * x - 5);
                Console.WriteLine(A); 
            }
        }
    }
}

