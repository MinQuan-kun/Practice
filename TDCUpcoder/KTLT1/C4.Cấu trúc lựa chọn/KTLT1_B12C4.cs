using System;
namespace xacdinhloaikytu
{
    class Program
    {
        static void Main(string[]args)
        {
            char k = char.Parse(Console.ReadLine());
            
            
            int m = (int)k;
            if(m >=65 && m <= 90 )
                Console.WriteLine("IN HOA");
            else if(m >= 97 && m <= 122)
                Console.WriteLine("IN THUONG");
            else if(m >= 48 && m <= 57)
                Console.WriteLine("SO");
            else
                Console.WriteLine("KHAC");
        }
    }
}