using System;
namespace tinhnhietdo
{
    class Program
    {
        static void Main(string[]args)
        {
            double f = double.Parse(Console.ReadLine());
            //Console.WriteLine((double)Math.Round((((f-32)*5)/9),2));
            //Console.WriteLine($"{((f-32)*5)/9:F2}",f);
            Console.WriteLine($"{((f-32)*5)/9:0.00}",f);
        }
    }
}