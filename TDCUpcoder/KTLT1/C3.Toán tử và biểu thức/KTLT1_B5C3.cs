using System;
namespace Timmax{
    class Program
    {
        static void Main(string[]args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if(num1 > num2)
                Console.Write(num1);
            else
                Console.Write(num2);
        }
    }
}