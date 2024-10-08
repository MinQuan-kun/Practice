using System;
namespace Laixuat
{
    public class Program
    {
        static void Main(string[]args)
        {
            string [] input = Console.ReadLine().Split(' ');
            double x = double.Parse(input[0]);
            double n = double.Parse(input[1]);
            double tien = 0.0;
            if(x < 0 || n < 0)
                Console.Write("0");
            else
            {
                tien = 0;
                double temp = x;
                for(int i = (int)(n + 1); i <= 12; i++)
                {
                    tien = x + (temp * 0.05);
                    temp = x + temp * 0.05;
                }
                Console.Write(tien); 
            }
        }
    }
}