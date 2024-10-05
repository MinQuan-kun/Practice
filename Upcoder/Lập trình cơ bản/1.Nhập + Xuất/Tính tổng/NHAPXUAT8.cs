using System;
namespace Tinhtong
{
    public class Program
    {
        static void Main(string[]args)
        {
            string input = Console.ReadLine(); 
            double a = double.Parse(input.Split(' ')[0]); 
            double b = double.Parse(input.Split(' ')[1]); 
            
            string input2 = Console.ReadLine(); 
            double c = double.Parse(input2.Split(' ')[0]); 
            double d = double.Parse(input2.Split(' ')[1]); 
            
            string input3 = Console.ReadLine(); 
            double e = double.Parse(input3.Split(' ')[0]); 
            double f = double.Parse(input3.Split(' ')[1]); 
            
            double tong = (a + b + c) / (d + e + f);

            Console.Write("{0:0.0}", tong);
        }
    }
}