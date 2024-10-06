using System;
namespace Pheptoan
{
    public class Program
    {
        static void Main(string[]args)
        {
            string value = Console.ReadLine();
            string [] input = value.Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            string var = Console.ReadLine();
            int tong = 0;
            if(var == "+")
                tong = a + b;
            if(var == "-")
                tong = a - b;
            if(var == "%")
                tong = a % b;
            if(var == "*")
                tong = a * b;
            Console.Write("{0}{1}{2}={3}", a, var, b, tong);
                    
        }
    }
}