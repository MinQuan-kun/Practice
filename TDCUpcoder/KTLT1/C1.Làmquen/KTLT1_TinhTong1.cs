using System;
namespace TinhTong1 
{
    class Program 
    {
        static void Main(string[]args) 
        {
            int a, b, c;
            //Cách 1
            // string sinput;
            // sinput = Console.ReadLine();
            // a = int.Parse(sinput);
            // sinput = Console.ReadLine();
            // b = int.Parse(sinput);
            // c = a + b;
            // Console.WriteLine(c);
        
            //Cách 2
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine(c);
        }
    }
}
