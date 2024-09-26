using System;
namespace TinhTong2
{
    class Program 
    {
        static void Main(string[]args)
        {
            float a, b;
            //Cách 1
            //string sinput;
            //sinput = Console.ReadLine();
            // a = float.Parse(sinput);
            // sinput = Console.ReadLine();
            // b = float.Parse(sinput);
            // Console.WriteLine(a + b);
        
            //Cách 2
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            Console.WriteLine(a + b);
        }
    }
}
